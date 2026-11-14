using SIFAT.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIFAT.Controllers
{
    internal class DashboardController
    {
        private DashboardRepository _repo = new DashboardRepository();

        public decimal GetTotalPemasukan()
        {
            return _repo.GetTotalPemasukan();
        }

        public decimal GetTotalPengeluaran()
        {
            return _repo.GetTotalPengeluaran();
        }
    }
}
