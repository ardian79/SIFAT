using System;
using System.Collections.Generic;
using System.Text;
using SIFAT.Models;
using SIFAT.Repositories;

namespace SIFAT.Controllers
{
    public class BudidayaTebuController
    {
        private BudidayaTebuRepository _repo = new BudidayaTebuRepository();
        private LahanRepository _repoLahan = new LahanRepository();

        public string TambahBudidaya(int idLahan, int idPengguna, DateTime tglTanam, bool sudahPanen, DateTime tglPanen, string jumlahStr, string status)
        {
            string validasi = ValidasiBudidaya(idLahan, tglTanam, sudahPanen, tglPanen, jumlahStr, status, out int jumlah);
            if (validasi != "OK") return validasi;

            BudidayaTebu data = new BudidayaTebu
            {
                IdLahan = idLahan,
                IdPengguna = idPengguna,
                TanggalTanam = tglTanam,
                TanggalPanen = sudahPanen ? tglPanen : (DateTime?)null,
                JumlahTebu = jumlah,
                Status = status
            };

            _repo.Insert(data);
            return "OK";
        }

        public string UbahBudidaya(int id, int idLahan, DateTime tglTanam, bool sudahPanen, DateTime tglPanen, string jumlahStr, string status)
        {
            string validasi = ValidasiBudidaya(idLahan, tglTanam, sudahPanen, tglPanen, jumlahStr, status, out int jumlah);
            if (validasi != "OK") return validasi;

            BudidayaTebu data = new BudidayaTebu
            {
                Id = id,
                IdLahan = idLahan,
                TanggalTanam = tglTanam,
                TanggalPanen = sudahPanen ? tglPanen : (DateTime?)null,
                JumlahTebu = jumlah,
                Status = status
            };

            _repo.Update(data);
            return "OK";
        }

        private string ValidasiBudidaya(int idLahan, DateTime tglTanam, bool sudahPanen, DateTime tglPanen, string jumlahStr, string status, out int jumlah)
        {
            jumlah = 0;

            if (idLahan <= 0 || string.IsNullOrWhiteSpace(jumlahStr))
            {
                return "Lahan dan Jumlah Tebu wajib diisi!";
            }

            if (!int.TryParse(jumlahStr, out jumlah) || jumlah <= 0)
            {
                return "Jumlah Tebu harus berupa angka bulat lebih dari 0!";
            }

            if (sudahPanen && tglPanen.Date < tglTanam.Date)
            {
                return "Tanggal Panen tidak boleh lebih awal dari Tanggal Tanam!";
            }

            if (sudahPanen && status != "Panen")
            {
                return "Status harus 'Panen' jika opsi 'Sudah Panen?' dicentang!";
            }

            if (!sudahPanen && status == "Panen")
            {
                return "Centang 'Sudah Panen?' dan tentukan Tanggal Panen jika status adalah 'Panen'!";
            }

            return "OK";
        }

        public void HapusBudidaya(int id)
        {
            _repo.Delete(id);
        }

        public List<BudidayaTebu> GetAllBudidaya()
        {
            return _repo.GetAll();
        }

        public List<Lahan> GetListLahan()
        {
            return _repoLahan.GetAll();
        }
    }
}
