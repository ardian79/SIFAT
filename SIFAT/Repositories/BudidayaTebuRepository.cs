using Npgsql;
using SIFAT.Database;
using SIFAT.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIFAT.Repositories
{
    public class BudidayaTebuRepository
    {
        public void Insert(BudidayaTebu budidaya)
        {
            using (NpgsqlConnection conn = Koneksi.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO budidaya_tebu (id_lahan, id_pengguna, tanggal_tanam, tanggal_panen, jumlah_tebu, status) VALUES (@id_lahan, @id_pengguna, @tgl_tanam, @tgl_panen, @jumlah, @status)";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_lahan", budidaya.IdLahan);
                    cmd.Parameters.AddWithValue("@id_pengguna", budidaya.IdPengguna);
                    cmd.Parameters.AddWithValue("@tgl_tanam", budidaya.TanggalTanam);
                    cmd.Parameters.AddWithValue("@tgl_panen", (object)budidaya.TanggalPanen ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@jumlah", budidaya.JumlahTebu);
                    cmd.Parameters.AddWithValue("@status", budidaya.Status);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<BudidayaTebu> GetAll()
        {
            List<BudidayaTebu> list = new List<BudidayaTebu>();
            using (NpgsqlConnection conn = Koneksi.GetConnection())
            {
                conn.Open();
                string query = @"SELECT b.id, b.id_lahan, b.id_pengguna, b.tanggal_tanam, b.tanggal_panen, b.jumlah_tebu, b.status, 
                                 l.nama_lokasi, p.nama_lengkap 
                                 FROM budidaya_tebu b 
                                 JOIN lahan l ON b.id_lahan = l.id 
                                 JOIN pengguna p ON b.id_pengguna = p.id
                                 WHERE b.is_delete = false ORDER BY b.id DESC";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new BudidayaTebu
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                IdLahan = Convert.ToInt32(reader["id_lahan"]),
                                IdPengguna = Convert.ToInt32(reader["id_pengguna"]),
                                TanggalTanam = DateTime.Parse(reader["tanggal_tanam"].ToString()),
                                TanggalPanen = reader["tanggal_panen"] == DBNull.Value ? (DateTime?)null : DateTime.Parse(reader["tanggal_panen"].ToString()),
                                JumlahTebu = Convert.ToInt32(reader["jumlah_tebu"]),
                                Status = reader["status"].ToString(),
                                NamaLokasi = reader["nama_lokasi"].ToString(),
                                NamaPengguna = reader["nama_lengkap"].ToString()
                            });
                        }
                    }
                }
            }
            return list;
        }

        public void Update(BudidayaTebu budidaya)
        {
            using (NpgsqlConnection conn = Koneksi.GetConnection())
            {
                conn.Open();
                string query = "UPDATE budidaya_tebu SET id_lahan = @id_lahan, tanggal_tanam = @tgl_tanam, tanggal_panen = @tgl_panen, jumlah_tebu = @jumlah, status = @status WHERE id = @id";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_lahan", budidaya.IdLahan);
                    cmd.Parameters.AddWithValue("@tgl_tanam", budidaya.TanggalTanam);
                    cmd.Parameters.AddWithValue("@tgl_panen", (object)budidaya.TanggalPanen ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@jumlah", budidaya.JumlahTebu);
                    cmd.Parameters.AddWithValue("@status", budidaya.Status);
                    cmd.Parameters.AddWithValue("@id", budidaya.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id)
        {
            using (NpgsqlConnection conn = Koneksi.GetConnection())
            {
                conn.Open();
                string query = "UPDATE budidaya_tebu SET is_delete = true WHERE id = @id";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
