using System;
using System.Windows.Forms;
using StockerBLL;
using StockerBO;

namespace StockerWinforms
{
    public partial class FrmFourniseur : Form
    {
        private FournisseurManager FournisseurManager;
        public Fournisseur edfournisseur;
        public FrmFourniseur()
        {
            InitializeComponent();
            FournisseurManager = new FournisseurManager();
            edfournisseur = new Fournisseur();
            Loadfourniseur();
        }  

        private void FrmFourniseur_Load(object sender, EventArgs e)
        {

        }

        //
        #region TextChanged
        private void txtbNom_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtbNom.Text))
                label13.Show();
            else
                label13.Hide();
        }

        private void txtbEmail_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtbEmail.Text))
                label12.Show();
            else
                label12.Hide();
        }

        private void txtbLocation_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtbLocation.Text))
                label11.Show();
            else
                label11.Hide();
        }

        private void txtbPhone_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtbPhone.Text))
                label2.Show();
            else
                label2.Hide();
        }

        #endregion
        //

        private void listViewFournisseur_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewFournisseur.SelectedItems.Count == 0)
                return;
            var fourniseur = listViewFournisseur.SelectedItems[0].Tag as Fournisseur;
            LoadFourniseurProducct(fourniseur);
        }


        private void listViewProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewProduct.SelectedItems.Count == 0)
                return;
            var products = listViewProduct.SelectedItems[0].Tag as Produit;
        }
        private void Reset()
        {
            txtbNom.Clear();
            txtbEmail.Clear();
            txtbLocation.Clear();
            txtbPhone.Clear();
            edfournisseur = null;
        }
        //
        #region Load
        private void Loadfourniseur()
        {
            var supply = FournisseurManager.GetAllFournissseur();
            listViewFournisseur.Items.Clear();
            foreach (var F in supply)
            {
                ListViewItem lvi = new ListViewItem(new string[] { F.FullnameF, F.EmailF, F.TelephoneF.ToString(), F.LocalisationF});
                lvi.Tag = F;
                listViewFournisseur.Items.Add(lvi);
            }
        }

        private void LoadFourniseurProducct(Fournisseur fournisseur)
        {
            var products = fournisseur.GetProducts();
            listViewProduct.Items.Clear();
            foreach (var p in products)
            {
                ListViewItem lvi = new ListViewItem(new string[] { p.ReferenceP.ToString(), p.NameP, p.PriceP.ToString(), p.QuantiteP.ToString(), p.DateProduction.ToString("dd-MM-yyyy"), p.DateExpiration.ToString("dd-MM-yyyy"), p.DateLivraison.ToString("dd-MM-yyyy") });
                lvi.Tag = p;
                listViewProduct.Items.Add(lvi);
            }

        }
        #endregion
        //

        //button add supplier
        #region SaveSupplierInfo
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            var supplier = new Fournisseur(txtbNom.Text, txtbEmail.Text, txtbLocation.Text, double.Parse(txtbPhone.Text));
            try
            {

                if (edfournisseur == null)
                {
                    FournisseurManager.AddFournisseur(supplier);

                }
                else
                {
                    edfournisseur = listViewFournisseur.SelectedItems[0].Tag as Fournisseur;
                    foreach (var sup in edfournisseur.produits)
                    {
                        supplier.produits.Add(sup);
                    }

                    FournisseurManager.EditFournisseur(edfournisseur, supplier);

                }

                MessageBox.Show($"Save done !", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Reset();
                Loadfourniseur();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        //

        //
        #region EditSupplier
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listViewFournisseur.SelectedItems.Count == 0)
                return;
            var fourniseur = listViewFournisseur.SelectedItems[0].Tag as Fournisseur;
            txtbNom.Text = fourniseur.FullnameF;
            txtbEmail.Text = fourniseur.EmailF;
            txtbLocation.Text = fourniseur.LocalisationF;
            txtbPhone.Text = fourniseur.TelephoneF.ToString();
            edfournisseur = fourniseur;
        }
        #endregion
        //

        //
        #region DeleteSupplier
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listViewFournisseur.SelectedItems.Count == 0)
                return;
            var fourniseur = listViewFournisseur.SelectedItems[0].Tag as Fournisseur;
            FournisseurManager.DeleteFournisseur(fourniseur);
            Loadfourniseur();
            listViewFournisseur.SelectedItems.Clear();
        }
        #endregion
        //

        //
        #region AddSupplierProduct
        private void btnAddProd_Click(object sender, EventArgs e)
        {
            if (listViewFournisseur.SelectedItems.Count == 0)
                return;
            var fourniseur = listViewFournisseur.SelectedItems[0].Tag as Fournisseur;
            Form frm = new FrmAddProdFourn(fourniseur);
            frm.Show();
            LoadFourniseurProducct(fourniseur);
        }
        #endregion
        //

        //
        #region DeleteSupplierProduct
        private void btnDeleteProd_Click(object sender, EventArgs e)
        {
            if (listViewProduct.SelectedItems.Count == 0)
                return;
            var products = listViewProduct.SelectedItems[0].Tag as Produit;
            var stock = new Stock(products);
            edfournisseur = listViewFournisseur.SelectedItems[0].Tag as Fournisseur;
            if (edfournisseur != null)
            {
                FournisseurManager.RemoveFournisseurProduct(edfournisseur, products, stock);
                LoadFourniseurProducct(edfournisseur);
                listViewProduct.SelectedItems.Clear();
            }
            else
                MessageBox.Show("Error", "Supplier not choosen", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        #endregion
        //
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }

       
    }
}
