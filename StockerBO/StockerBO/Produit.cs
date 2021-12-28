using System;
using System.Globalization;

namespace StockerBO
{
    public class Produit:Categorie
    {
        CultureInfo culture = new CultureInfo("en-US");
        public int ReferenceP { get; set; }
        public string NameP { get; set; }
        public double PriceP { get; set; }
        public double QuantiteP{get;set;}
        public DateTime DateLivraison { get; set; }
        public DateTime DateProduction { get; set; }
        public DateTime DateExpiration { get; set; }
      
       
        

        public Produit()
        {
           
        }
        public Produit(Produit produit) : this(produit?.nomCategorie, produit?.ReferenceP ?? 0, produit?.NameP, produit?.PriceP ?? 0, produit?.QuantiteP ?? 0
           ,produit?.DateProduction.ToString("dd-MM-yyyy"), produit?.DateExpiration.ToString("dd-MM-yyyy"), produit?.DateLivraison.ToString("dd-MM-yyyy"))
        {

        }

        public Produit(string nomCategori, int referencep, string namep, double pricep, double quantitep, string datep, string dateex,string livrason)
        {
            nomCategorie = nomCategori;
            ReferenceP = referencep;
            NameP = namep;
            PriceP = pricep;
            QuantiteP = quantitep;
            DateProduction = DateTime.ParseExact( datep, "dd-MM-yyyy", culture);
            DateExpiration = DateTime.ParseExact( dateex, "dd-MM-yyyy", culture);
            DateLivraison = DateTime.ParseExact(livrason, "dd-MM-yyyy", culture);


        }
        public Produit(string nomCategori ,int referencep, string namep, double pricep,double quantitep,DateTime datep,DateTime dateex,DateTime livreson)
        {
            ReferenceP = referencep;
            NameP = namep;
            PriceP = pricep;
            QuantiteP = quantitep;
            DateProduction = datep;
            DateExpiration = dateex;
            DateLivraison = livreson;
            nomCategorie = nomCategori;
        }

        public Produit(int referenceP, string nameP, double priceP, double quantiteP)
        {
            ReferenceP = referenceP;
            NameP = nameP;
            PriceP = priceP;
            QuantiteP = quantiteP;
        }

        public override bool Equals(object obj)
        {
            return obj is Produit produit &&
                   base.Equals(obj) &&
                   ReferenceP == produit.ReferenceP;
        }

        public override int GetHashCode()
        {
            int hashCode = 574452340;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + ReferenceP.GetHashCode();
            return hashCode;
        }

        /*public Produit(Produit produit ,Categorie categorie) : this(categorie?.nomCategorie, produit?.ReferenceP, produit?.NameP, produit?.PriceP ?? 0,produit?.QuantiteP??0
            ,(DateTime)produit?.DateProduction,(DateTime)produit?.DateExpiration)
        {

        }*/



    }
}
