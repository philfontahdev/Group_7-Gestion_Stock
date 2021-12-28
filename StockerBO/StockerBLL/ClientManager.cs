using StockerBO;
using StockerDAL;
using System.Collections.Generic;

namespace StockerBLL
{
    public class ClientManager
    {
        private CommandRepo CommandRepo;
        private ClientRepository clientRepository;
        private StockRepo StockRepo;
      
        public ClientManager()
        {
            clientRepository = new ClientRepository();
            CommandRepo = new CommandRepo();
            StockRepo = new StockRepo();
          
        }

        public void AddClient(Client client)
        {
            clientRepository.Add(client);
        }

        public void EditFournisseur(Client oldClient, Client newClient)
        {
            clientRepository.Set(oldClient, newClient);
        }

        public void DeleteFournisseur(Client fournisseur)
        {
           clientRepository.Delete(fournisseur);
        }

        public List<Client> GetAllClient()
        {
            return clientRepository.GetAll();
        }
      
        /*public void AddClientProduct(Client client, Produit produit)
        {
            if (clientRepository.IndexOf(client) < 0)
                throw new KeyNotFoundException($"{nameof(Client)} not found !");
            client.AddCommande(produit);
            clientRepository.Set(client, client);
        }*/

        public void AddClientCommand(Commande command)
        {
            CommandRepo.Add(command);
        }

        public void DeleteClientCommand(Commande command)
        {
            CommandRepo.Delete(command);
        }

        public void EditCleintCommand(Commande command,Commande commande)
        {
            CommandRepo.Set(command, command);
        }

        public double Takeclientcommandandprice (string name)
        {
            foreach (var p in StockRepo.FindByProductName(name))
                if (name == p.NameP)
                {
                    int i = 0;
                    return StockRepo.FindByProductName(name)[i].PriceP;
                }
            return double.Parse(null);
        }

        public string Collectcategorie(string name)
        {
            foreach (var p in StockRepo.FindByProductName(name))
                if (name == p.NameP)
                {
                    int i = 0;
                    return StockRepo.FindByProductName(name)[i].nomCategorie;
                }
            return null;
        }

        public int Collectreference(string name)
        {
            foreach (var p in StockRepo.FindByProductName(name))
                if (name == p.NameP)
                {
                    int i = 0;
                    return StockRepo.FindByProductName(name)[i].ReferenceP;
                }
            return int.Parse(null);
        }
        /*public void RemoveClientProduct(Client client, Produit produit)
        {
            if (clientRepository.IndexOf(client) < 0)
                throw new KeyNotFoundException($"{nameof(Client)} not found !");
            client.RemoveProduit(produit);
            clientRepository.Set(client, client);
        }*/

        /*public void deduce(Client client)
        {
            StockRepo.delaftecmd(client);
        }*/
    }
}
