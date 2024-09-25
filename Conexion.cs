using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Npgsql; 
using WindowsFormsApp1s;

namespace WindowsFormsApp1
{
    public class Conexion
    {
        private static string connectionString = "Host=ep-silent-leaf-a4t140o9.us-east-1.aws.neon.tech;Port=5432;Username=default;Password=GDixbTqlu78r;Database=verceldb;SslMode=Require";

        public static string GetConnectionString()
        {
            return connectionString;
        }
    }
}
