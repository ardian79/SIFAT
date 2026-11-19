using System;
using System.Collections.Generic;
using System.Text;

namespace SIFAT.Models
{
    public class BudidayaTebu : BaseModel
    {
        public int IdLahan { get; set; }
        public int IdPengguna { get; set; }
        public DateTime TanggalTanam { get; set; }
        public DateTime? TanggalPanen { get; set; }
        public int JumlahTebu { get; set; }
        public string Status { get; set; }

        public string NamaLokasi { get; set; }
        public string NamaPengguna { get; set; }

        public BudidayaTebu()
        {
            Status = string.Empty;
            NamaLokasi = string.Empty;
            NamaPengguna = string.Empty;
        }
    }
}
