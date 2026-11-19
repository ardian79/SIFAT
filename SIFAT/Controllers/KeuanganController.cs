using System;
using System.Collections.Generic;
using System.Text;
using SIFAT.Models;
using SIFAT.Repositories;

namespace SIFAT.Controllers
{
    public class KeuanganController
    {
        private KeuanganRepository _repoKeuangan = new KeuanganRepository();
        private JenisKeuanganRepository _repoJenis = new JenisKeuanganRepository();

        public string TambahKeuangan(int idPengguna, int idJenis, DateTime tanggal, string jumlahStr, string keterangan)
        {
            string validasi = ValidasiKeuangan(idJenis, jumlahStr, out decimal jumlah);
            if (validasi != "OK") return validasi;

            Keuangan trx = new Keuangan
            {
                IdPengguna = idPengguna,
                IdJenisKeuangan = idJenis,
                Tanggal = tanggal,
                Jumlah = jumlah,
                Keterangan = keterangan?.Trim() ?? string.Empty
            };

            _repoKeuangan.Insert(trx);
            return "OK";
        }

        public string UbahKeuangan(int id, int idJenis, DateTime tanggal, string jumlahStr, string keterangan)
        {
            string validasi = ValidasiKeuangan(idJenis, jumlahStr, out decimal jumlah);
            if (validasi != "OK") return validasi;

            Keuangan trx = new Keuangan
            {
                Id = id,
                IdJenisKeuangan = idJenis,
                Tanggal = tanggal,
                Jumlah = jumlah,
                Keterangan = keterangan?.Trim() ?? string.Empty
            };

            _repoKeuangan.Update(trx);
            return "OK";
        }

        private string ValidasiKeuangan(int idJenis, string jumlahStr, out decimal jumlah)
        {
            jumlah = 0;

            if (idJenis <= 0 || string.IsNullOrWhiteSpace(jumlahStr))
            {
                return "Jenis dan Jumlah wajib diisi!";
            }

            if (!decimal.TryParse(jumlahStr, out jumlah) || jumlah <= 0)
            {
                return "Jumlah harus berupa angka lebih dari 0!";
            }

            return "OK";
        }

        public void HapusKeuangan(int id)
        {
            _repoKeuangan.Delete(id);
        }

        public List<Keuangan> GetAllKeuangan()
        {
            return _repoKeuangan.GetAll();
        }

        public List<JenisKeuangan> GetListJenisKeuangan()
        {
            return _repoJenis.GetAll();
        }
    }
}
