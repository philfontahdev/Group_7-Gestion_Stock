using StockerBO;
using System.Collections.Generic;
using System.IO;

namespace StockerDAL
{
    public class ClientRepository : BaseRepository<Client>
    {
        public ClientRepository() : base()
        {
            FileInfo fileInfo = new FileInfo(PATH);
            if (!fileInfo.Exists || fileInfo.Length == 0)
            {
                Client client = new Client("Issemou ludovic", "issemou@gmail.com", "CAMEROUN_bertoua", "+237 653 000 527");
                Add(client);
            }
        }
        public List<Client> FindByName(string name)
        {
            List<Client> list = new List<Client>();
            foreach (var data in datas)
                if (data.FullnameC.ToLower().Contains(name.ToLower()))
                    list.Add(data);
            return new List<Client>(list);
        }

        public List<Client> FindByEmail(string email)
        {
            List<Client> list = new List<Client>();
            foreach (var data in datas)
                if (data.EmailC.ToLower().Contains(email.ToLower()))
                    list.Add(data);
            return new List<Client>(list);
        }
    }
}
