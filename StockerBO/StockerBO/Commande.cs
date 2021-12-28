namespace StockerBO
{
    public class Commande
    {
        public int Idcommande { get; set; }
        
        public Commande ()
        {
           
        }
        public Commande(int idcommande) : this()
        {
            Idcommande = idcommande;
            

        }
        public Commande(Commande commande) : this(commande?.Idcommande??0)
        {

        }
       
        public override bool Equals(object obj)
        {
            return obj is Commande commande &&
                    Idcommande == commande.Idcommande;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
