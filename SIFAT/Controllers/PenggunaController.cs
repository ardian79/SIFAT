using System;
using System.Collections.Generic;
using System.Text;
using SIFAT.Models;
using SIFAT.Repositories;

namespace SIFAT.Controllers
{
    public class PenggunaController
    {
        private PenggunaRepository _repo = new PenggunaRepository();

        public string TambahBuruh(string nama, string username, string password)
        {
            if (string.IsNullOrWhiteSpace(nama) || string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return "Semua kolom wajib diisi!";
            }

            Pengguna buruh = new Pengguna
            {
                NamaLengkap = nama,
                Username = username,
                Password = password
            };

            _repo.InsertBuruh(buruh);
            return "OK";
        }

        public string UbahBuruh(int id, string nama, string username, string password)
        {
            if (string.IsNullOrWhiteSpace(nama) || string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return "Semua kolom wajib diisi!";
            }

            Pengguna buruh = new Pengguna
            {
                Id = id,
                NamaLengkap = nama,
                Username = username,
                Password = password
            };

            _repo.UpdateBuruh(buruh);
            return "OK";
        }

        public void NonaktifkanBuruh(int id)
        {
            _repo.DeleteBuruh(id);
        }

        public List<Pengguna> GetAllBuruh()
        {
            return _repo.GetAllBuruh();
        }
    }
}
