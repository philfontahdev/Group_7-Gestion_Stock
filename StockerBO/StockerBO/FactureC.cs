using System;

namespace StockerBO
{
    public class FactureC:Client
    {
        public int idfacture { get; set; }
        public DateTime DateF { get; set; }


        public FactureC(int idfacture, DateTime dateTime)
        {
            this.idfacture = idfacture;
            DateF = dateTime;
        }
       
        public override bool Equals(object obj)
        {
            return obj is FactureC facture &&
                   idfacture == facture.idfacture;
        }

        public override int GetHashCode()
        {
            return 972997076 + idfacture.GetHashCode();
        }
    }
}
