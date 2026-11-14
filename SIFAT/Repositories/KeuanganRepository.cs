using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;
using SIFAT.Models;

namespace SIFAT.Repositories
{
    public class KeuanganRepository
    {
        public void Insert(Keuangan keuangan)
        {
            using (NpgsqlConnection conn = SIFAT.Database.Koneksi.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO keuangan (id_pengguna, id_jenis_keuangan, tanggal, jumlah, keterangan) VALUES (@id_pengguna, @id_jenis, @tanggal, @jumlah, @ket)";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_pengguna", keuangan.IdPengguna);
                    cmd.Parameters.AddWithValue("@id_jenis", keuangan.IdJenisKeuangan);
                    cmd.Parameters.AddWithValue("@tanggal", keuangan.Tanggal);
                    cmd.Parameters.AddWithValue("@jumlah", keuangan.Jumlah);
                    cmd.Parameters.AddWithValue("@ket", keuangan.Keterangan);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Keuangan> GetAll()
        {
            List<Keuangan> list = new List<Keuangan>();
            using (NpgsqlConnection conn = SIFAT.Database.Koneksi.GetConnection())
            {
                conn.Open();
                string query = @"SELECT k.id, k.id_pengguna, k.id_jenis_keuangan, k.tanggal, k.jumlah, k.keterangan, j.nama_jenis, j.kategori FROM keuangan k JOIN jenis_keuangan j ON k.id_jenis_keuangan = j.id WHERE k.is_delete = false ORDER BY k.tanggal DESC, k.id DESC";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Keuangan
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                IdPengguna = Convert.ToInt32(reader["id_pengguna"]),
                                IdJenisKeuangan = Convert.ToInt32(reader["id_jenis_keuangan"]),
                                Tanggal = DateTime.Parse(reader["tanggal"].ToString()),
                                Jumlah = Convert.ToDecimal(reader["jumlah"]),
                                Keterangan = reader["keterangan"].ToString(),
                                NamaJenis = reader["nama_jenis"].ToString(),
                                Kategori = reader["kategori"].ToString()
                            });
                        }
                    }
                }
            }
            return list;
        }

        public void Update(Keuangan keuangan)
        {
            using (NpgsqlConnection conn = SIFAT.Database.Koneksi.GetConnection())
            {
                conn.Open();
                string query = "UPDATE keuangan SET id_jenis_keuangan = @id_jenis, tanggal = @tanggal, jumlah = @jumlah, keterangan = @ket WHERE id = @id";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_jenis", keuangan.IdJenisKeuangan);
                    cmd.Parameters.AddWithValue("@tanggal", keuangan.Tanggal);
                    cmd.Parameters.AddWithValue("@jumlah", keuangan.Jumlah);
                    cmd.Parameters.AddWithValue("@ket", keuangan.Keterangan);
                    cmd.Parameters.AddWithValue("@id", keuangan.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id)
        {
            using (NpgsqlConnection conn = SIFAT.Database.Koneksi.GetConnection())
            {
                conn.Open();
                string query = "UPDATE keuangan SET is_delete = true WHERE id = @id";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
