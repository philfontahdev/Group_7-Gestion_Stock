using System;

namespace StockerBO
{
    public class Stock:Produit
    {
        public Stock()
        {

        }
        public Stock(string nomCategori,int referencep, string namep, double pricep, double quantitep, DateTime datep, DateTime dateex)
        {
            ReferenceP = referencep;
            NameP = namep;
            PriceP = pricep;
            QuantiteP = quantitep;
            DateProduction = datep;
            DateExpiration = dateex;
            nomCategorie = nomCategori;
        }

        public Stock(string nomCategori, int referencep, string namep, double pricep, double quantitep)
        {
            ReferenceP = referencep;
            NameP = namep;
            PriceP = pricep;
            QuantiteP = quantitep;
            nomCategorie = nomCategori;
        }

       public Stock(Produit produit) : base(produit)
        {

        }
    }
}
