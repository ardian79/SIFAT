using Npgsql;
using SIFAT.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIFAT.Repositories
{
    public class DashboardRepository
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

        public List<Keuangan> GetRecentKeuangan(int limit)
        {
            List<Keuangan> list = new List<Keuangan>();
            using (NpgsqlConnection conn = SIFAT.Database.Koneksi.GetConnection())
            {
                conn.Open();
                string query = @"SELECT k.id, k.tanggal, j.nama_jenis, j.kategori, k.jumlah, k.keterangan, p.nama_lengkap 
                         FROM keuangan k 
                         JOIN jenis_keuangan j ON k.id_jenis_keuangan = j.id 
                         JOIN pengguna p ON k.id_pengguna = p.id 
                         WHERE k.is_delete = false 
                         ORDER BY k.tanggal DESC, k.id DESC 
                         LIMIT @limit";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@limit", limit);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Keuangan
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                Tanggal = DateTime.Parse(reader["tanggal"].ToString()),
                                NamaJenis = reader["nama_jenis"].ToString(),
                                Kategori = reader["kategori"].ToString(),
                                Jumlah = Convert.ToDecimal(reader["jumlah"]),
                                Keterangan = reader["keterangan"].ToString(),
                                NamaPengguna = reader["nama_lengkap"].ToString()
                            });
                        }
                    }
                }
            }
            return list;
        }
    }
}
