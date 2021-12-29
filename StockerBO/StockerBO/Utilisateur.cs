using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockerBO
{
    public class Utilisateur
    {
        public string EmailU { get; set; }
        public string PasswordU { get; set; }
        public string FullnameU { get; set; }
        public string Status { get; set; }
        public Utilisateur(string emailu, string passwordu, string fullnameu,string stat) : this()
        {
            EmailU = emailu;
            PasswordU = passwordu;
            FullnameU = fullnameu;
            Status = stat;
        }

        public Utilisateur()
        {
        }
        public Utilisateur(Utilisateur utilisateur) : this(utilisateur?.EmailU, utilisateur?.PasswordU, utilisateur?.FullnameU,utilisateur?.Status)
        {

        }

        public override bool Equals(object obj)
        {
            return obj is Utilisateur utilisateur &&
                   EmailU == utilisateur.EmailU;
        }

        public override int GetHashCode()
        {
            return -506688385 + EqualityComparer<string>.Default.GetHashCode(EmailU);
        }
    }
}
