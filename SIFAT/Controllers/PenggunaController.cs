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

            Pengguna buruh = new BuruhTani
            {
                NamaLengkap = nama,
                Username = username,
                Password = password
            };

            _repo.Insert(buruh);
            return "OK";
        }

        public string UbahBuruh(int id, string nama, string username, string password)
        {
            if (string.IsNullOrWhiteSpace(nama) || string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return "Semua kolom wajib diisi!";
            }

            Pengguna buruh = new BuruhTani
            {
                Id = id,
                NamaLengkap = nama,
                Username = username,
                Password = password
            };

            _repo.Update(buruh);
            return "OK";
        }

        public void NonaktifkanBuruh(int id)
        {
            _repo.Delete(id);
        }

        public List<Pengguna> GetAllBuruh()
        {
            return _repo.GetAll();
        }
    }
}
