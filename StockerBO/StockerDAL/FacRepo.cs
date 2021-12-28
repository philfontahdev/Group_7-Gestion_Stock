using System;
using StockerBO;
using System.IO;

namespace StockerDAL
{
    public class FacRepo : BaseRepository<FactureC>
    {
        public FacRepo() : base()
        {
            FileInfo fileinfo = new FileInfo(PATH);
            if (!fileinfo.Exists || fileinfo.Length == 0)
            {
                FactureC facture = new FactureC(9876459,DateTime.Now);
                Add(facture);
            }
        }
    }
}
