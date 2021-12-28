using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockerBO;
using System.IO;

namespace StockerDAL
{
    public class CommandRepo : BaseRepository<Commande>
    {
        public CommandRepo() :base()
        {
            FileInfo fileinfo = new FileInfo(PATH);
            if (!fileinfo.Exists || fileinfo.Length == 0)
            {
                Commande command = new Commande(123);
                Add(command);
            }
        }

        public List<Commande> FindById(int id)
        {
            List<Commande> list = new List<Commande>();
            foreach (var data in datas)
                if (data.Idcommande.Equals(id))
                    list.Add(data);
            return new List<Commande>(list);
        }


    }
}
