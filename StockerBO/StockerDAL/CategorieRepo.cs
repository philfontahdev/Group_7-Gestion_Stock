using StockerBO;
using System.Collections.Generic;
using System.IO;

namespace StockerDAL
{
    public class CategorieRepo:BaseRepository<Categorie>
    {
        public CategorieRepo() : base()
        {
            FileInfo fileInfo = new FileInfo(PATH);
            if (!fileInfo.Exists || fileInfo.Length == 0)
            {
                Categorie categorie = new Categorie(1276356478, "issemou@gmail.com");
                Add(categorie);
            }
        }

        public List<Categorie> FindByName(string name)
        {
            List<Categorie> list = new List<Categorie>();
            foreach (var data in datas)
                if (data.nomCategorie.ToLower().Contains(name.ToLower()))
                    list.Add(data);
            return new List<Categorie>(list);
        }
    }

   

}
