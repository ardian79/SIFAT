using System;
using System.Collections.Generic;
using System.Text;

namespace SIFAT.Models
{
    public class Lahan
    {
        public int Id { get; set; }
        public string NamaLokasi { get; set; }
        public decimal LuasLahan { get; set; }
        public string Catatan { get; set; }
        public bool IsDelete { get; set; }

        public Lahan()
        {
            NamaLokasi = string.Empty;
            Catatan = string.Empty;
        }
    }
}
