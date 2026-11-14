using System;
using System.Collections.Generic;
using System.Text;
using SIFAT.Models;
using SIFAT.Repositories;

namespace SIFAT.Controllers
{
    public class JenisKeuanganController
    {
        private JenisKeuanganRepository _repo = new JenisKeuanganRepository();

        public string TambahJenis(string nama, string kategori)
        {
            if (string.IsNullOrWhiteSpace(nama) || string.IsNullOrWhiteSpace(kategori))
            {
                return "Nama Jenis dan Kategori wajib diisi!";
            }

            JenisKeuangan jenisBaru = new JenisKeuangan
            {
                NamaJenis = nama,
                Kategori = kategori
            };

            _repo.Insert(jenisBaru);
            return "OK";
        }

        public string UbahJenis(int id, string nama, string kategori)
        {
            JenisKeuangan jenisEdit = new JenisKeuangan
            {
                Id = id,
                NamaJenis = nama,
                Kategori = kategori
            };

            _repo.Update(jenisEdit);
            return "OK";
        }

        public void HapusJenis(int id)
        {
            _repo.Delete(id);
        }

        public List<JenisKeuangan> GetAllJenis()
        {
            return _repo.GetAll();
        }
    }
}
