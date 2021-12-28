using StockerBO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockerDAL
{
    public class FournisseurRepository : BaseRepository<Fournisseur>
    {
        public FournisseurRepository() : base()
        {
            FileInfo fileInfo = new FileInfo(PATH);
            if (!fileInfo.Exists || fileInfo.Length == 0)
            {
                Fournisseur fournisseur = new Fournisseur("Aguili franck", "aguili@gmail.com", "CAMEROUN_dla",694536872);
                Add(fournisseur);
            }
        }
        public List<Fournisseur> FindByName(string name)
        {
            List<Fournisseur> list = new List<Fournisseur>();
            foreach (var data in datas)
                if (data.FullnameF.ToLower().Contains(name.ToLower()))
                    list.Add(data);
            return new List<Fournisseur>(list);
        }

        public List<Fournisseur> FindByEmail(string email)
        {
            List<Fournisseur> list = new List<Fournisseur>();
            foreach (var data in datas)
                if (data.EmailF.ToLower().Contains(email.ToLower()))
                    list.Add(data);
            return new List<Fournisseur>(list);
        }
    }
}
