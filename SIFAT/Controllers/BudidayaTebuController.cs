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

        public string TambahBudidaya(int idLahan, DateTime tglTanam, bool sudahPanen, DateTime tglPanen, string jumlahStr, string status)
        {
            if (idLahan == 0 || string.IsNullOrWhiteSpace(jumlahStr))
            {
                return "Lahan dan Jumlah Tebu wajib diisi!";
            }

            if (!int.TryParse(jumlahStr, out int jumlah))
            {
                return "Jumlah Tebu harus berupa angka!";
            }

            BudidayaTebu data = new BudidayaTebu
            {
                IdLahan = idLahan,
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
            if (!int.TryParse(jumlahStr, out int jumlah))
            {
                return "Jumlah Tebu harus berupa angka!";
            }

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
