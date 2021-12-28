namespace StockerBO
{
    public class Categorie
    {
        public int idCategorie { get; set; }
        public string nomCategorie { get; set; }

        public Categorie()
        {

        }

        public Categorie(int idCategorie, string nomCategorie)
        {
            this.idCategorie = idCategorie;
            this.nomCategorie = nomCategorie;
        }

        public override bool Equals(object obj)
        {
            return obj is Categorie categorie &&
                   idCategorie == categorie.idCategorie;
        }

        public override int GetHashCode()
        {
            return 2144980847 + idCategorie.GetHashCode();
        }
    }
}
