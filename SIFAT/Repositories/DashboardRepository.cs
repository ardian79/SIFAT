using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIFAT.Repositories
{
    internal class DashboardRepository
    {
        public decimal GetTotalPemasukan()
        {
            decimal total = 0;
            using (NpgsqlConnection conn = SIFAT.Database.Koneksi.GetConnection())
            {
                conn.Open();
                string query = "SELECT COALESCE(SUM(k.jumlah), 0) FROM keuangan k JOIN jenis_keuangan j ON k.id_jenis_keuangan = j.id WHERE j.kategori = 'Pemasukan' AND k.is_delete = false";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        total = Convert.ToDecimal(result);
                    }
                }
            }
            return total;
        }

        public decimal GetTotalPengeluaran()
        {
            decimal total = 0;
            using (NpgsqlConnection conn = SIFAT.Database.Koneksi.GetConnection())
            {
                conn.Open();
                string query = "SELECT COALESCE(SUM(k.jumlah), 0) FROM keuangan k JOIN jenis_keuangan j ON k.id_jenis_keuangan = j.id WHERE j.kategori = 'Pengeluaran' AND k.is_delete = false";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        total = Convert.ToDecimal(result);
                    }
                }
            }
            return total;
        }
    }
}
