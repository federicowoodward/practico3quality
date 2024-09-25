using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public class Conexion
    {
        private string connectionString = "Data Source=YOUR_SERVER;Initial Catalog=Empleados_DB;Integrated Security=True";

        public List<ClassDocente> LeerDocentes()
        {
            List<ClassDocente> docentes = new List<ClassDocente>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Docente";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        ClassDocente docente = new ClassDocente(
                            reader["Nombre"].ToString(),
                            Convert.ToInt32(reader["Edad"]),
                            reader["Position"].ToString()
                        );
                        docente.Seniority = Convert.ToInt32(reader["Seniority"]);
                        docente.Salary = Convert.ToDouble(reader["Salary"]);

                        docentes.Add(docente);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return docentes;
        }
    }
}