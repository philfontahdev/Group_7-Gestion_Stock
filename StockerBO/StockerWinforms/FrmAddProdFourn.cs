using System;
using System.Collections.Generic;
using System.Windows.Forms;
using StockerBLL;
using StockerBO;
using StockerDAL;


namespace StockerWinforms
{
    public partial class FrmAddProdFourn : Form
    {
        public FournisseurManager fournisseur;
        private Fournisseur Fournisseur;
        private List<Categorie> categories;
        private CategorieRepo CategorieRepo;

        public FrmAddProdFourn()
        {
            InitializeComponent();
            fournisseur = new FournisseurManager();
            categories = new List<Categorie>();
            CategorieRepo = new CategorieRepo();
            LoadCategorie();
        }
        public FrmAddProdFourn(Fournisseur fournisseur) : this()
        {
            this.Fournisseur = fournisseur;

        }

        private void LoadCategorie()
        {
            categories = CategorieRepo.GetAll();
            foreach (Categorie c in categories)
            {
                comboBoxCategorie.Items.Add(c.nomCategorie);
            }
        }
        //
        #region TextChanged
        private void textBref_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBref.Text))
                label2.Show();
            else
                label2.Hide();
        }
        private void txtbProd_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtbProd.Text))
                label9.Show();
            else
                label9.Hide();
        }


        private void txtbPrice_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtbPrice.Text))
                label7.Show();
            else
                label7.Hide();
        }

        private void txtbQuantity_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtbQuantity.Text))
                label6.Show();
            else
                label6.Hide();
        }
        #endregion
        //

        //Adds Products to supplier list of products and in stock 
        #region AddProduct
        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<Stock> stocks = new List<Stock>();
            stocks.Add(new Stock(comboBoxCategorie.Text, int.Parse(textBref.Text), txtbProd.Text, double.Parse(txtbPrice.Text), double.Parse(txtbQuantity.Text), DateTime.Parse(dateproduit.Text), DateTime.Parse(dateperime.Text)));
            var stq = new Stock(comboBoxCategorie.Text, int.Parse(textBref.Text), txtbProd.Text, double.Parse(txtbPrice.Text), double.Parse(txtbQuantity.Text), DateTime.Parse(dateproduit.Text), DateTime.Parse(dateperime.Text));
            try
            {
                FournisseurManager fournisseurManager = new FournisseurManager();
                if (!double.TryParse(txtbPrice.Text, out _))
                    throw new Exception("invalid price!");

                var product = new Produit(comboBoxCategorie.Text, int.Parse(textBref.Text), txtbProd.Text, double.Parse(txtbPrice.Text), int.Parse(txtbQuantity.Text), dateproduit.Value.Date.ToString("dd-MM-yyyy"), dateperime.Value.Date.ToString("dd-MM-yyyy"),dateTimePicker1.Value.Date.ToString("dd-MM-yyyy"));
                fournisseurManager.AddFournisseurProduct(Fournisseur, product);
                fournisseur.AddFourniseurProductToStock(stocks, stq);

                MessageBox.Show($"{txtbProd.Text} added !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        //

    }
}
