using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockerBO;
using StockerDAL;

namespace StockerBLL
{
    public class CategoryManager
    {
        CategorieRepo CategorieRepo;

        public CategoryManager()
        {
            CategorieRepo = new CategorieRepo();
        }

        public void Add (Categorie categorie)
        {
            CategorieRepo.Add(categorie);
        }

        public void Editcat(Categorie oldcat,Categorie newcat)
        {
            CategorieRepo.Set(oldcat, newcat);
        }

        public void Delete(Categorie Cat)
        {
            CategorieRepo.Delete(Cat);
        }
        public List<Categorie> Getcat()
        {
            return CategorieRepo.GetAll();
        }

        public List<Categorie> Find(string name)
        {
            return CategorieRepo.FindByName(name); 
        }
    }
}
