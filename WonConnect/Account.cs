using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WonConnect
{
    internal class Account
    {
        public string Username = "";
        public string Password = "";
        public string Chakra = "Inconnu";
        public string level = "Inconnu";
        public string status = "Non Connecté";
        public string last_connexion = "Aucune";

        public Account(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }
    }
}
