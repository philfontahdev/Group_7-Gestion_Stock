using StockerBO;
using StockerDAL;
using System.Collections.Generic;

namespace StockerBLL
{
    public class FournisseurManager
    {
        private FournisseurRepository fournisseurRepository;
        private StockRepo StockRepo;
        public FournisseurManager()
        {
            fournisseurRepository = new FournisseurRepository();
            StockRepo = new StockRepo();

        }

        public void AddFournisseur(Fournisseur fournisseur)
        {
            //Add supplier
            fournisseurRepository.Add(fournisseur);
        }

        public void EditFournisseur(Fournisseur oldFournisseur, Fournisseur newFournisseur)
        {
            //Edit supplier
            fournisseurRepository.Set(oldFournisseur, newFournisseur);
        }

        public void DeleteFournisseur(Fournisseur fournisseur)
        {
            //Add supplier
            fournisseurRepository.Delete(fournisseur);
        }

        public List<Fournisseur> GetAllFournissseur()
        {
            //Display all suppliers and their products
            return fournisseurRepository.GetAll();
        }
        public void AddFourniseurProductToStock(List<Stock> stock,Stock stock1)
        {
            //Add Supplier product to stock
            StockRepo.AddQ(stock,stock1);
        }

        public List<Stock> GetStock()
        {
            return StockRepo.GetAll();
        }
        public List<Stock> Findstock(string name)
        {
            return StockRepo.FindByProductName(name);
        }


        public void AddFournisseurProduct(Fournisseur fournisseur, Produit produit)
         {
            //Add supplier product to his list of products
             if (fournisseurRepository.IndexOf(fournisseur) < 0)
                 throw new KeyNotFoundException($"{nameof(Fournisseur)} not found !");
            fournisseur.Addfourniseurproduct(produit);
             fournisseurRepository.Set(fournisseur, fournisseur);
         }

        public void RemoveFournisseurProduct(Fournisseur fournisseur, Produit produit,Stock stock)
        {
            //Remove supplier products from his list of products
            if (fournisseurRepository.IndexOf(fournisseur) < 0)
                throw new KeyNotFoundException($"{nameof(Fournisseur)} not found !");
            fournisseur.RemovefourniseurProduct(produit);
            StockRepo.Delete(stock);
            fournisseurRepository.Set(fournisseur, fournisseur);
        }
    }
}
