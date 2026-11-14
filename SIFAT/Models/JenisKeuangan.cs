using System;
using System.Collections.Generic;
using System.Text;

namespace SIFAT.Models
{
    public class JenisKeuangan
    {
        public int Id { get; set; }
        public string NamaJenis { get; set; }
        public string Kategori { get; set; }
        public bool IsDelete { get; set; }

        public JenisKeuangan()
        {
            NamaJenis = string.Empty;
            Kategori = string.Empty;
        }
    }
}
