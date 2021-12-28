using System.Collections.Generic;

namespace StockerBO
{
    public class Utilisateur
    {
        public string EmailU { get; set; }

        public string PasswordU { get; set; }

        public string FullnameU { get; set; }
        public Utilisateur(string emailu, string passwordu, string fullnameu) : this()
        {
            EmailU = emailu;
            PasswordU = passwordu;
            FullnameU = fullnameu;
        }

        public Utilisateur()
        {
        }
        public Utilisateur(Utilisateur utilisateur) : this(utilisateur?.EmailU, utilisateur?.PasswordU, utilisateur?.FullnameU)
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
