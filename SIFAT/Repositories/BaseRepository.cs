using Npgsql;
using SIFAT.Database;
using SIFAT.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIFAT.Repositories
{
    public abstract class BaseRepository<T> where T : BaseModel
    {
        protected abstract string NamaTabel { get; }

        protected NpgsqlConnection GetConnection()
        {
            return Koneksi.GetConnection();
        }

        public abstract void Insert(T entity);
        public abstract List<T> GetAll();
        public abstract void Update(T entity);

        public virtual void Delete(int id)
        {
            using (NpgsqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = $"UPDATE {NamaTabel} SET is_delete = true WHERE id = @id";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
