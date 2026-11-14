using System;
using System.Collections.Generic;
using System.Text;

namespace SIFAT.Models
{
    public class Pengguna
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string NamaLengkap { get; set; }
        public string Role { get; set; }
        public bool IsDelete { get; set; }

        public Pengguna()
        {
            Username = string.Empty;
            Password = string.Empty;
            NamaLengkap = string.Empty;
            Role = string.Empty;
        }
    }
}
