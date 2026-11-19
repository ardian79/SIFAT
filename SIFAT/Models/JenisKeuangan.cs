using System;
using System.Collections.Generic;
using System.Text;

namespace SIFAT.Models
{
    public class JenisKeuangan : BaseModel
    {
        public string NamaJenis { get; set; }
        public string Kategori { get; set; }

        public JenisKeuangan()
        {
            NamaJenis = string.Empty;
            Kategori = string.Empty;
        }
    }
}
