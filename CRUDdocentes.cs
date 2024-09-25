using Npgsql;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApp1s;

namespace WindowsFormsApp1
{
    public class CRUDdocentes
    {
        private readonly string connectionString;

        public CRUDdocentes()
        {
            this.connectionString = Conexion.GetConnectionString();
        }

        public List<ClassDocente> LeerDocentes()
        {
            List<ClassDocente> docentes = new List<ClassDocente>();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                string query = "SELECT nombre, fechanacimiento, especialidad FROM docente";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DateTime fechaNacimiento = Convert.ToDateTime(reader["fechanacimiento"]);
                                int edad = CalcularEdad(fechaNacimiento);

                                ClassDocente docente = new ClassDocente(
                                    reader["nombre"].ToString(),
                                    edad,
                                    reader["especialidad"].ToString()
                                );
                                docentes.Add(docente);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }

            return docentes;
        }
        public bool AgregarDocente(ClassDocente docente)
        {
            if (docente == null)
            {
                throw new ArgumentNullException(nameof(docente));
            }

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Insert new docente with auto-generated ID
                        string query = @"INSERT INTO docente (nombre, fechanacimiento, especialidad) 
                                         VALUES (@nombre, @fechanacimiento, @especialidad) 
                                         RETURNING idempleado";
                        using (NpgsqlCommand command = new NpgsqlCommand(query, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@nombre", docente.Nombre);
                            command.Parameters.AddWithValue("@fechanacimiento", DateTime.Now.AddYears(-docente.Edad).Date);
                            command.Parameters.AddWithValue("@especialidad", docente.Position);

                            int newId = Convert.ToInt32(command.ExecuteScalar());

                            if (newId > 0)
                            {
                                transaction.Commit();
                                return true;
                            }
                            else
                            {
                                transaction.Rollback();
                                return false;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        LogError(ex);
                        return false;
                    }
                }
            }
        }

        public ClassDocente BuscarDocentePorId(int id)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                string query = "SELECT * FROM docente WHERE id = @id";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        command.Parameters.AddWithValue("@id", id);

                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                DateTime fechaNacimiento = Convert.ToDateTime(reader["fechanacimiento"]);
                                int edad = CalcularEdad(fechaNacimiento);

                                return new ClassDocente(
                                    reader["nombre"].ToString(),
                                    edad,
                                    reader["especialidad"].ToString()
                                );
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al buscar docente: " + ex.Message);
                        Console.WriteLine("Error al buscar docente: " + ex.Message);
                    }
                }
            }
            return null;
        }

        private int CalcularEdad(DateTime fechaNacimiento)
        {
            int edad = DateTime.Now.Year - fechaNacimiento.Year;
            if (DateTime.Now.DayOfYear < fechaNacimiento.DayOfYear)
                edad--;
            return edad;
        }

        private void LogError(Exception ex)
        {
            string errorMessage = $"Error al agregar docente: {ex.Message}";
            MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Console.WriteLine(errorMessage);
        }
    }
}