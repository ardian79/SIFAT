using Npgsql;
using SIFAT.Database;
using SIFAT.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIFAT.Repositories
{
    public class PenggunaRepository
    {
        public Pengguna Login(string username, string password)
        {
            Pengguna user = null;
            using (NpgsqlConnection conn = Koneksi.GetConnection())
            {
                conn.Open();
                string query = "SELECT id, username, password, nama_lengkap, role FROM pengguna WHERE username = @username AND password = @password AND is_delete = false";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string roleDb = reader["role"].ToString();

                            if (roleDb == "Pemilik Lahan")
                            {
                                user = new PemilikLahan();
                            }
                            else
                            {
                                user = new BuruhTani();
                            }

                            user.Id = Convert.ToInt32(reader["id"]);
                            user.Username = reader["username"].ToString();
                            user.Password = reader["password"].ToString();
                            user.NamaLengkap = reader["nama_lengkap"].ToString();
                        }
                    }
                }
            }
            return user;
        }

        public void Insert(Pengguna pengguna)
        {
            using (NpgsqlConnection conn = Koneksi.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO pengguna (username, password, nama_lengkap, role) VALUES (@username, @password, @nama, 'Buruh Tani')";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", pengguna.Username);
                    cmd.Parameters.AddWithValue("@password", pengguna.Password);
                    cmd.Parameters.AddWithValue("@nama", pengguna.NamaLengkap);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Pengguna> GetAll()
        {
            List<Pengguna> list = new List<Pengguna>();
            using (NpgsqlConnection conn = Koneksi.GetConnection())
            {
                conn.Open();
                string query = "SELECT id, username, password, nama_lengkap, role FROM pengguna WHERE role = 'Buruh Tani' AND is_delete = false ORDER BY id DESC";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new BuruhTani
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                Username = reader["username"].ToString(),
                                Password = reader["password"].ToString(),
                                NamaLengkap = reader["nama_lengkap"].ToString()
                            });
                        }
                    }
                }
            }
            return list;
        }

        public bool IsUsernameExist(string username, int excludeId = 0)
        {
            using (NpgsqlConnection conn = Koneksi.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(1) FROM pengguna WHERE LOWER(username) = LOWER(@username) AND id <> @excludeId";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@excludeId", excludeId);
                    long count = Convert.ToInt64(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        public void Update(Pengguna pengguna)
        {
            using (NpgsqlConnection conn = Koneksi.GetConnection())
            {
                conn.Open();
                bool ubahPassword = !string.IsNullOrWhiteSpace(pengguna.Password);
                string query = ubahPassword
                    ? "UPDATE pengguna SET username = @username, password = @password, nama_lengkap = @nama WHERE id = @id"
                    : "UPDATE pengguna SET username = @username, nama_lengkap = @nama WHERE id = @id";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", pengguna.Username);
                    if (ubahPassword)
                    {
                        cmd.Parameters.AddWithValue("@password", pengguna.Password);
                    }
                    cmd.Parameters.AddWithValue("@nama", pengguna.NamaLengkap);
                    cmd.Parameters.AddWithValue("@id", pengguna.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id)
        {
            using (NpgsqlConnection conn = Koneksi.GetConnection())
            {
                conn.Open();
                string query = "UPDATE pengguna SET is_delete = true WHERE id = @id";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
