using System.Collections.Generic;
using StockerBO;
using StockerDAL;

namespace StockerBLL
{
    public class FactureManager
    {
        private StockRepo StockRepo;
        private CommandRepo CommandRepo;

        public FactureManager()
        {
            StockRepo = new StockRepo();
            CommandRepo = new CommandRepo();
        }
        public void sold(string name,int quantity)
        {
            StockRepo.Del(name,quantity);
        }

        public void Take_Command(Commande command)
        {
            CommandRepo.Add(command);
        }

      
    }
}
