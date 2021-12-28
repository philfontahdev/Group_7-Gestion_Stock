namespace StockerBO
{
    public class Client:Commande
    {
        public int idclient { get; set; }
        public string FullnameC { get; set; }
        public string EmailC { get; set; }
        protected string LocalisationC { get; set; }
        protected string TelephoneC { get; set; }


        public Client()
        {
           
        }

        public Client(int idclient)
        {
            this.idclient = idclient;
        }

        public Client(string fullnamec, string emailc, string localisationc, string telephonec) : this()
        {
            FullnameC = fullnamec;
            EmailC = emailc;
            LocalisationC = localisationc;
            TelephoneC = telephonec;
          

        }

        public Client(Client client) : this( client?.FullnameC, client?.EmailC, client?.LocalisationC,client?.TelephoneC)
        {

        }
    }
}
