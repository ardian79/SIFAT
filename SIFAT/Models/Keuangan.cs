using System;
using System.Collections.Generic;
using System.Text;

namespace SIFAT.Models
{
    public class Keuangan
    {
        public int Id { get; set; }
        public bool IsDelete { get; set; }
        public int IdPengguna { get; set; }
        public int IdJenisKeuangan { get; set; }
        public DateTime Tanggal { get; set; }
        public decimal Jumlah { get; set; }
        public string Keterangan { get; set; }

        public string NamaJenis { get; set; }
        public string Kategori { get; set; }
        public string NamaPengguna { get; set; }

        public Keuangan()
        {
            IsDelete = false;
            Keterangan = string.Empty;
            NamaJenis = string.Empty;
            Kategori = string.Empty;
            NamaPengguna = string.Empty;
        }
    }
}
