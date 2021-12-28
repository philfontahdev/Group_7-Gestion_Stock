using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockerBO
{
    public class POS
    {
       public List<Commande> Commandes { get; set; }
       public  List<Client> Clients { get; set; }

        public POS()
        {

        }
        public POS(List<Commande> commandes, List<Client> clients)
        {
            this.Commandes = commandes;
            this.Clients = clients;
        }

    }
}
