using System;
using System.Collections.Generic;
using StockerBO;
using System.IO;

namespace StockerDAL
{
    public class StockRepo:BaseRepository<Stock>
    {
        int Q = 0;
        bool ver = false;

        public StockRepo() : base()
        {
            FileInfo fileinfo = new FileInfo(PATH);
            if (!fileinfo.Exists || fileinfo.Length == 0)
            {
                Stock user = new Stock("boissons",2,"booster",650,30, DateTime.Now, DateTime.Now);
                Add(user);
            }
        }
        public List<Stock> FindByProductName(string name)
        {
            List<Stock> list = new List<Stock>();
            foreach (var data in datas)
                if (data.NameP.ToLower().Contains(name.ToLower()))
                    list.Add(data);
            return new List<Stock>(list);
        }

        //Add Supplier product to stock 
        #region Add Product
        public void AddQ(List<Stock> produits,Stock stock)
        {
            try
            {
                foreach (var data in datas)
                {
                    if (data.NameP.ToLower().Contains(stock.NameP.ToLower()) && data.ReferenceP.ToString().ToLower().Contains(stock.ReferenceP.ToString().ToLower()))
                    {
                        int i = 0;
                       
                            try
                            {
                                if (data.NameP.ToLower() == produits[i].NameP.ToLower())
                                {
                                    data.QuantiteP = data.QuantiteP + produits[i].QuantiteP;
                                    i++;
                                }
                            }
                            catch
                            {
                                for (var y = 1; y > produits.Count; y++)
                                    if (data.NameP == produits[y].NameP)
                                    {
                                        data.QuantiteP = data.QuantiteP + produits[y].QuantiteP;
                                    }
                            }
                        Save();
                        ver = true;
                    }
                }
                if(ver == false)
                {
                    throw new Exception("Does not Exist!");
                }
            }
            catch
            {
                Add(stock);
            }
        }
        #endregion
        //

        //Restores Product to stock if command deleted
        #region Restore Product
        public void AddQC(List<Stock> produits)
        {
            int i = 0;
            foreach (var pod in datas)
            {
                try
                {
                    if (pod.NameP == produits[i].NameP)
                    {
                        pod.QuantiteP = pod.QuantiteP + produits[i].QuantiteP;
                        i++;
                    }
                }
                catch
                {
                    for(var y=1;y>produits.Count;y++)
                        if (pod.NameP == produits[y].NameP)
                        {
                            pod.QuantiteP = pod.QuantiteP + produits[y].QuantiteP;
                        }

                }
                
            }
            Save();
        }
        #endregion
        //

        //Remove Product from stock if command Accepted
        #region Remove Product
        public void Del(string NameP, int Quantity)
        {
            int i = 0;
            //foreach (var m in datas)
            //{
           
                for (var y = 0; y < datas.Count; y++)
                {
                    if (datas[y].NameP.ToLower().Contains(NameP.ToLower()))
                    {
                        if (datas[y].QuantiteP <= 0 || Quantity > datas[y].QuantiteP)
                        {
                            throw new KeyNotFoundException($"{NameP} Left {datas[y].QuantiteP}Out Of Stock !");
                        }
                        else
                        {
                            datas[y].QuantiteP = datas[y].QuantiteP - Quantity;
                            Q++;
                            i++;
                            
                        }
                    }
                }

               /* if (m.NameP.ToLower().Contains(NameP))
                {
                    if (m.QuantiteP <= 0 || Quantity > m.QuantiteP)
                    {
                        throw new KeyNotFoundException($"{NameP} Left {m.QuantiteP}Out Of Stock !");
                    }
                    else
                    {
                        m.QuantiteP = m.QuantiteP - Quantity;
                        Q++;
                        i++;
                    }
                }*/
            //}
            Save();

        }

        public void delaftecmd(Stock stock)
        {
            /* var i = 0;
             foreach (var p in datas)
                 if (p.NameP == client.NameP)
                     p.QuantiteP -= client.QuantiteP;
             i++;
             Save();
            int index =  IndexOf(stock);
            if(index >= 0)*/

        }
        #endregion
        //


    }


}
