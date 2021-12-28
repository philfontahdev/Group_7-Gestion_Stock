using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StockerBO
{
    public class Fournisseur : Produit
    {

        public string FullnameF { get; set; }
        public string EmailF { get; set; }
        public string LocalisationF { get; set; }
        public double TelephoneF { get; set; }
        
        public List<Produit> produits { get; set; }
       

        public Fournisseur()
        {
            produits = new List<Produit>();
        }
        public Fournisseur(string fullnamef,string emailf, string localisationf,double telephonef) : this()
        {
            FullnameF = fullnamef;
            EmailF = emailf;
            LocalisationF = localisationf;
            TelephoneF = telephonef;
            
        }

       
        public Fournisseur(Fournisseur fournisseur) : this(fournisseur?.FullnameF,fournisseur?.EmailF, fournisseur?.LocalisationF,fournisseur?.TelephoneF ??0)
        {
           
        }

        //
        #region Supplier Product Properties
        public void Addfourniseurproduct(Produit produit)
        {
            produits.Add(produit);

        }

        public void RemovefourniseurProduct(Produit product)
        {
            produits.Remove(product);
            
        }

        public List<Produit> GetProducts()
        {
            var list = new List<Produit>();
            foreach (var p in produits)
                list.Add(new Produit(p));
            return list;
        }
        #endregion
        //


        public override bool Equals(object obj)
        {
            return obj is Fournisseur fournisseur &&
                   EmailF == fournisseur.EmailF;
        }

        public override int GetHashCode()
        {
            return -506688385 + EqualityComparer<string>.Default.GetHashCode(EmailF);
        }
    }
}
