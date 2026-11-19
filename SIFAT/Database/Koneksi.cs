using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;

namespace SIFAT.Database
{
    internal class Koneksi
    {
        private static string connString = "Host=localhost;Port=5432;Database=SIFAT;Username=postgres;Password=passwordmu";

        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connString);
        }
    }
}
