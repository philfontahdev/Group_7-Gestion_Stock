using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockerBO;

namespace StockerDAL
{
    public class UserRepository:BaseRepository<Utilisateur>
    {
        public UserRepository() : base()
        {
            FileInfo fileInfo = new FileInfo(PATH);
            if (!fileInfo.Exists || fileInfo.Length == 0)
            {
                Utilisateur user1 = new Utilisateur("phil@admin.net", "admin","Fontah Ndefru Phil" ,"Director");
                Add(user1);
                Utilisateur user2 = new Utilisateur("ridovic@admin.net", "admin", "Issemou Ridovic","Manager");
                Add(user2);
                Utilisateur user3 = new Utilisateur("franck@admin.net", "admin","Aguili Franck", "Employee");
                Add(user3);
                Utilisateur user4 = new Utilisateur("petula@admin.net", "admin", "Toukam Petula","Manager");
                Add(user4);
                Utilisateur user5 = new Utilisateur("willy@admin.net", "admin", "Nogue Willy","Employee");
                Add(user5);
                Utilisateur user6 = new Utilisateur("billy@admin.net", "admin", "Markus Billy","Administrator");
                Add(user6);
                Utilisateur user7 = new Utilisateur("edgwi@admin.net", "admin", "Daine Edgwi","Employee");
                Add(user7);
                Utilisateur user8 = new Utilisateur("biacop@admin.net", "admin","Solange Biacop" ,"Employee");
                Add(user8);
                Utilisateur user9 = new Utilisateur("Mokom@admin.net", "admin", "Lesly Mokom","Administrator");
                Add(user9);
                Utilisateur user10 = new Utilisateur("zangue@admin.net", "admin","Brice Zangue", "Employee");
                Add(user10);
                /*Utilisateur users = new Utilisateur 
                { EmailU = "admin@admin.net", PasswordU = "admin", FullnameU = "Administrator" ,
                    
                };
                List<Utilisateur> use = new List<Utilisateur>
                {
                    new Utilisateur("admin@admin.net", "admin", "Administrator"),
                    new Utilisateur("admin@admin.net", "admin", "Administrator"),
                    new Utilisateur("admin@admin.net", "admin", "Administrator"),
                    new Utilisateur("admin@admin.net", "admin", "Administrator"),
                    new Utilisateur("admin@admin.net", "admin", "Administrator"),
                    new Utilisateur("admin@admin.net", "admin", "Administrator"),
                    new Utilisateur("admin@admin.net", "admin", "Administrator")
                };*/


            }
        }

        public List<Utilisateur> FindByName(string name)
        {
            List<Utilisateur> list = new List<Utilisateur>();
            foreach (var data in datas)
                if (data.FullnameU.ToLower().Contains(name.ToLower()))
                    list.Add(data);
            return new List<Utilisateur>(list);
        }

        public List<Utilisateur> FindByEmail(string email)
        {
            List<Utilisateur> list = new List<Utilisateur>();
            foreach (var data in datas)
                if (data.EmailU.ToLower().Contains(email.ToLower()))
                    list.Add(data);
            return new List<Utilisateur>(list);
        }
    }
}
