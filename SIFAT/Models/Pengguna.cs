using System;
using System.Collections.Generic;
using System.Text;

namespace SIFAT.Models
{
    public abstract class Pengguna : BaseModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string NamaLengkap { get; set; }
        public string Role { get; protected set; }

        public Pengguna()
        {
            Username = string.Empty;
            Password = string.Empty;
            NamaLengkap = string.Empty;
            Role = string.Empty;
        }

        public Pengguna(string username, string password, string namaLengkap)
        {
            Username = username;
            Password = password;
            NamaLengkap = namaLengkap;
            Role = string.Empty;
        }

        public abstract string GetHakAkses();

        public virtual bool BisaAksesMenuAdmin()
        {
            return false;
        }

        public virtual bool BisaLihatPenginput()
        {
            return false;
        }
    }

    public class Petani : Pengguna
    {
        public Petani()
        {
            Role = "Petani";
        }

        public Petani(string username, string password, string namaLengkap)
            : base(username, password, namaLengkap)
        {
            Role = "Petani";
        }

        public override string GetHakAkses()
        {
            return "Akses Penuh";
        }

        public override bool BisaAksesMenuAdmin()
        {
            return true;
        }

        public override bool BisaLihatPenginput()
        {
            return true;
        }
    }

    public class BuruhTani : Pengguna
    {
        public BuruhTani()
        {
            Role = "Buruh Tani";
        }

        public BuruhTani(string username, string password, string namaLengkap)
            : base(username, password, namaLengkap)
        {
            Role = "Buruh Tani";
        }

        public override string GetHakAkses()
        {
            return "Akses Terbatas";
        }
    }
}
