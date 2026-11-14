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
            if (string.IsNullOrWhiteSpace(nama) || string.IsNullOrWhiteSpace(luasStr))
            {
                return "Nama Lokasi dan Luas wajib diisi!";
            }

            if (!decimal.TryParse(luasStr, out decimal luas))
            {
                return "Luas Lahan harus berupa angka yang valid!";
            }

            Lahan lahanBaru = new Lahan
            {
                NamaLokasi = nama,
                LuasLahan = luas,
                Catatan = catatan
            };

            _repo.Insert(lahanBaru);
            return "OK";
        }

        public string UbahLahan(int id, string nama, string luasStr, string catatan)
        {
            if (!decimal.TryParse(luasStr, out decimal luas))
            {
                return "Luas Lahan harus berupa angka yang valid!";
            }

            Lahan lahanEdit = new Lahan
            {
                Id = id,
                NamaLokasi = nama,
                LuasLahan = luas,
                Catatan = catatan
            };

            _repo.Update(lahanEdit);
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
