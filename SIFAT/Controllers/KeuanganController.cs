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
            if (idJenis == 0 || string.IsNullOrWhiteSpace(jumlahStr))
            {
                return "Jenis dan Jumlah wajib diisi!";
            }

            if (!decimal.TryParse(jumlahStr, out decimal jumlah))
            {
                return "Jumlah harus berupa angka yang valid!";
            }

            Keuangan trx = new Keuangan
            {
                IdPengguna = idPengguna,
                IdJenisKeuangan = idJenis,
                Tanggal = tanggal,
                Jumlah = jumlah,
                Keterangan = keterangan
            };

            _repoKeuangan.Insert(trx);
            return "OK";
        }

        public string UbahKeuangan(int id, int idJenis, DateTime tanggal, string jumlahStr, string keterangan)
        {
            if (!decimal.TryParse(jumlahStr, out decimal jumlah))
            {
                return "Jumlah harus berupa angka yang valid!";
            }

            Keuangan trx = new Keuangan
            {
                Id = id,
                IdJenisKeuangan = idJenis,
                Tanggal = tanggal,
                Jumlah = jumlah,
                Keterangan = keterangan
            };

            _repoKeuangan.Update(trx);
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
