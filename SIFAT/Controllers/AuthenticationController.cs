using System;
using System.Collections.Generic;
using System.Text;
using SIFAT.Models;
using SIFAT.Repositories;

namespace SIFAT.Controllers
{
    public class AuthenticationController
    {
        private PenggunaRepository _repo = new PenggunaRepository();

        public string Login(string username, string password, out Pengguna userLogin)
        {
            userLogin = null;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return "Username dan Password tidak boleh kosong!";
            }

            userLogin = _repo.Login(username, password);

            if (userLogin == null)
            {
                return "Username atau Password salah!";
            }

            return "OK";
        }
    }
}
