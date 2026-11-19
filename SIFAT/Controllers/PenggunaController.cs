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
            nama = nama?.Trim();
            username = username?.Trim();

            if (string.IsNullOrWhiteSpace(nama) || string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return "Semua kolom wajib diisi!";
            }

            if (_repo.IsUsernameExist(username))
            {
                return "Username sudah digunakan, silakan gunakan username lain!";
            }

            Pengguna buruh = new BuruhTani(username, password, nama);
            _repo.Insert(buruh);
            return "OK";
        }

        public string UbahBuruh(int id, string nama, string username, string password)
        {
            nama = nama?.Trim();
            username = username?.Trim();

            if (string.IsNullOrWhiteSpace(nama) || string.IsNullOrWhiteSpace(username))
            {
                return "Nama Lengkap dan Username wajib diisi! (Kosongkan Password jika tidak ingin mengubahnya)";
            }

            if (_repo.IsUsernameExist(username, id))
            {
                return "Username sudah digunakan oleh pengguna lain!";
            }

            Pengguna buruh = new BuruhTani(username, password ?? string.Empty, nama)
            {
                Id = id
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
