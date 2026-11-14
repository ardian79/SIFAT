using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;
using SIFAT.Models;

namespace SIFAT.Repositories
{
    public class LahanRepository
    {
        public void Insert(Lahan lahan)
        {
            using (NpgsqlConnection conn = SIFAT.Database.Koneksi.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO lahan (nama_lokasi, luas_lahan, catatan) VALUES (@nama, @luas, @catatan)";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nama", lahan.NamaLokasi);
                    cmd.Parameters.AddWithValue("@luas", lahan.LuasLahan);
                    cmd.Parameters.AddWithValue("@catatan", lahan.Catatan);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Lahan> GetAll()
        {
            List<Lahan> list = new List<Lahan>();
            using (NpgsqlConnection conn = SIFAT.Database.Koneksi.GetConnection())
            {
                conn.Open();
                string query = "SELECT id, nama_lokasi, luas_lahan, catatan FROM lahan WHERE is_delete = false ORDER BY id DESC";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Lahan
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                NamaLokasi = reader["nama_lokasi"].ToString(),
                                LuasLahan = Convert.ToDecimal(reader["luas_lahan"]),
                                Catatan = reader["catatan"].ToString()
                            });
                        }
                    }
                }
            }
            return list;
        }

        public void Update(Lahan lahan)
        {
            using (NpgsqlConnection conn = SIFAT.Database.Koneksi.GetConnection())
            {
                conn.Open();
                string query = "UPDATE lahan SET nama_lokasi = @nama, luas_lahan = @luas, catatan = @catatan WHERE id = @id";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nama", lahan.NamaLokasi);
                    cmd.Parameters.AddWithValue("@luas", lahan.LuasLahan);
                    cmd.Parameters.AddWithValue("@catatan", lahan.Catatan);
                    cmd.Parameters.AddWithValue("@id", lahan.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id)
        {
            using (NpgsqlConnection conn = SIFAT.Database.Koneksi.GetConnection())
            {
                conn.Open();
                string query = "UPDATE lahan SET is_delete = true WHERE id = @id";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
