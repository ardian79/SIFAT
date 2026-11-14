using System;
using System.Collections.Generic;
using System.Text;

using System;

namespace SIFAT.Models
{
    public class BudidayaTebu
    {
        public int Id { get; set; }
        public int IdLahan { get; set; }
        public DateTime TanggalTanam { get; set; }
        public DateTime? TanggalPanen { get; set; }
        public int JumlahTebu { get; set; }
        public string Status { get; set; }
        public bool IsDelete { get; set; }

        public string NamaLokasi { get; set; }

        public BudidayaTebu()
        {
            Status = string.Empty;
            NamaLokasi = string.Empty;
        }
    }
}
