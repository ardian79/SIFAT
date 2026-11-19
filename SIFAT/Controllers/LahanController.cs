using System;
using System.Collections.Generic;
using System.Text;
using SIFAT.Models;
using SIFAT.Repositories;

namespace SIFAT.Controllers
{
    public class LahanController
    {
        private LahanRepository _repo = new LahanRepository();

        public string TambahLahan(string nama, string luasStr, string catatan)
        {
            string validasi = ValidasiLahan(nama, luasStr, out decimal luas);
            if (validasi != "OK") return validasi;

            Lahan lahanBaru = new Lahan
            {
                NamaLokasi = nama.Trim(),
                LuasLahan = luas,
                Catatan = catatan?.Trim() ?? string.Empty
            };

            _repo.Insert(lahanBaru);
            return "OK";
        }

        public string UbahLahan(int id, string nama, string luasStr, string catatan)
        {
            string validasi = ValidasiLahan(nama, luasStr, out decimal luas);
            if (validasi != "OK") return validasi;

            Lahan lahanEdit = new Lahan
            {
                Id = id,
                NamaLokasi = nama.Trim(),
                LuasLahan = luas,
                Catatan = catatan?.Trim() ?? string.Empty
            };

            _repo.Update(lahanEdit);
            return "OK";
        }

        private string ValidasiLahan(string nama, string luasStr, out decimal luas)
        {
            luas = 0;

            if (string.IsNullOrWhiteSpace(nama) || string.IsNullOrWhiteSpace(luasStr))
            {
                return "Nama Lokasi dan Luas wajib diisi!";
            }

            if (!decimal.TryParse(luasStr, out luas) || luas <= 0)
            {
                return "Luas Lahan harus berupa angka lebih dari 0!";
            }

            return "OK";
        }

        public void HapusLahan(int id)
        {
            _repo.Delete(id);
        }

        public List<Lahan> GetAllLahan()
        {
            return _repo.GetAll();
        }
    }
}
