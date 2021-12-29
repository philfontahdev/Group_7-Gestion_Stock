using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using StockerBO;
using StockerBLL;
using StockerDAL;


namespace StockerWinforms
{
    public partial class FrmFacture : Form
    {
        ClientManager clientManager;
        double price;
        double side;
        List<Produit> products;
        List<Stock> stocks;
        StockRepo s;
        FacRepo Facture;
        CommandRepo command;
        Random run;
        int idf;
        int idc;
        
        public FrmFacture()
        {
            InitializeComponent();
            clientManager = new ClientManager();
            price = new double();
            side = new double();
            products = new List<Produit>();
            s = new StockRepo();
            stocks = new List<Stock>();
            Facture = new FacRepo();
            command = new CommandRepo();
            run = new Random();
            idf = new int();
            
            LoadStock();

        }
        private void LoadStock()
        {
             List<Stock> get;
            get = s.GetAll();
            foreach (Stock s in get)
            {
                comboBoxproductname.Items.Add(s.NameP);
            }
        }


        private void btAdd_Click(object sender, EventArgs e)
        {

            try
            {
                price = clientManager.Takeclientcommandandprice(comboBoxproductname.Text);
                string cat = clientManager.Collectcategorie(comboBoxproductname.Text);
                int refe = clientManager.Collectreference(comboBoxproductname.Text);

                if (!string.IsNullOrEmpty(comboBoxproductname.Text) && !string.IsNullOrEmpty(tBquantity.Text))
                {
                    stocks.Add(new Stock(cat, refe, comboBoxproductname.Text, price, int.Parse(tBquantity.Text)));
                    try
                    {
                        s.Del(comboBoxproductname.Text,int.Parse(tBquantity.Text));
                        Stock stock = new Stock() { NameP = comboBoxproductname.Text, QuantiteP = int.Parse(tBquantity.Text), ReferenceP = refe, PriceP = price, nomCategorie = cat };
                        stockBindingSource.Add(stock);
                        products.Add(stock);
                        foreach (var i in products)
                            side = double.Parse(tBTotal.Text) + (i.PriceP * i.QuantiteP);
                        tBTotal.Text = side.ToString();
                        comboBoxproductname.Text = "Products";
                        tBquantity.Text = string.Empty;
                        //tBreference.Text = string.Empty;
                    }
                    catch
                    {
                        comboBoxproductname.BackColor = Color.MistyRose;
                        MessageBox.Show($"{comboBoxproductname.Text} is out of Stock", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); tBTotal.Text = side.ToString();
                        comboBoxproductname.BackColor = Color.White;
                        tBquantity.Text = string.Empty;
                        // tBreference.Text = string.Empty;

                    }
                }
                
            }
            catch
            {
                comboBoxproductname.BackColor = Color.MistyRose;
                MessageBox.Show($"{comboBoxproductname.Text} not selected", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBoxproductname.BackColor = Color.White;
            }

        }
        private void btprint_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            { 
                idf = run.Next();
                idc = run.Next();
                var r = new FactureC(idf, DateTime.Now);
                Facture.Add(r);
                var c = new Commande(idc);
                command.Add(c);
                using (Facture form = new Facture(products, idf.ToString(), DateTime.Now, idc.ToString(), "Fac.rdlc", "facture"))
                {
                    form.ShowDialog();
                }
                dataGridView1.Rows.Clear();
                tBTotal.Text = 0.ToString();
                products.Clear();
            }
            else
            {
                dataGridView1.BackgroundColor = Color.MistyRose;
                btAdd.BackColor = Color.MistyRose;
                MessageBox.Show("Add Products to Cart", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.BackgroundColor = Color.CadetBlue;
                btAdd.BackColor = Color.White;
            }
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int exc;
                double y;
                string ma;
                List<Stock> ns = new List<Stock>();


                if (MessageBox.Show("Do you really want to delete this command", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    for (var i = 0; i < dataGridView1.SelectedRows.Count; i++)
                    {

                        exc = dataGridView1.SelectedRows[i].Index;
                        y = int.Parse(dataGridView1.Rows[exc].Cells[2].Value.ToString());
                        if (true == dataGridView1.SelectedRows[i].Displayed)
                            ma = dataGridView1.Rows[exc].Cells[i].Value.ToString();
                        ns.Add(new Stock(dataGridView1.Rows[exc].Cells[4].Value.ToString(), int.Parse(dataGridView1.Rows[exc].Cells[0].Value.ToString()), dataGridView1.Rows[exc].Cells[1].Value.ToString().ToString(), double.Parse(dataGridView1.Rows[exc].Cells[2].Value.ToString()), int.Parse(dataGridView1.Rows[exc].Cells[3].Value.ToString())));
                        s.AddQC(ns);
                        foreach (var m in products)
                            side = double.Parse(tBTotal.Text) - (m.PriceP * m.QuantiteP);
                        tBTotal.Text = side.ToString();
                        products.Remove(dataGridView1.SelectedRows[i].DataBoundItem as Produit);
                        dataGridView1.Rows.Remove(dataGridView1.SelectedRows[i]);
                        dataGridView1.ClearSelection();
                    }

            }
            else
            {
                dataGridView1.BackgroundColor = Color.MistyRose;
                MessageBox.Show("No product has been selected", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.BackgroundColor = Color.CadetBlue;
            }

        }

        private void POS_Load(object sender, EventArgs e)
        {
            tBTotal.Text = 0.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabelINventoryC_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //ClientForm form = new ClientForm();
            //form.Show();
        }
    }
}
