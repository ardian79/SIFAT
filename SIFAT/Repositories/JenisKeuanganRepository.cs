using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;
using SIFAT.Models;

namespace SIFAT.Repositories
{
    public class JenisKeuanganRepository
    {
        public void Insert(JenisKeuangan jenis)
        {
            using (NpgsqlConnection conn = SIFAT.Database.Koneksi.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO jenis_keuangan (nama_jenis, kategori) VALUES (@nama, @kategori)";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nama", jenis.NamaJenis);
                    cmd.Parameters.AddWithValue("@kategori", jenis.Kategori);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<JenisKeuangan> GetAll()
        {
            List<JenisKeuangan> list = new List<JenisKeuangan>();
            using (NpgsqlConnection conn = SIFAT.Database.Koneksi.GetConnection())
            {
                conn.Open();
                string query = "SELECT id, nama_jenis, kategori FROM jenis_keuangan WHERE is_delete = false ORDER BY id DESC";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new JenisKeuangan
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                NamaJenis = reader["nama_jenis"].ToString(),
                                Kategori = reader["kategori"].ToString()
                            });
                        }
                    }
                }
            }
            return list;
        }

        public void Update(JenisKeuangan jenis)
        {
            using (NpgsqlConnection conn = SIFAT.Database.Koneksi.GetConnection())
            {
                conn.Open();
                string query = "UPDATE jenis_keuangan SET nama_jenis = @nama, kategori = @kategori WHERE id = @id";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nama", jenis.NamaJenis);
                    cmd.Parameters.AddWithValue("@kategori", jenis.Kategori);
                    cmd.Parameters.AddWithValue("@id", jenis.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id)
        {
            using (NpgsqlConnection conn = SIFAT.Database.Koneksi.GetConnection())
            {
                conn.Open();
                string query = "UPDATE jenis_keuangan SET is_delete = true WHERE id = @id";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
