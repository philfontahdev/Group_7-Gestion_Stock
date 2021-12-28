using System;
using System.Windows.Forms;
using StockerBLL;

namespace StockerWinforms
{
    public partial class FrmStock : Form
    {
        FournisseurManager stock;
        public FrmStock()
        {
            InitializeComponent();
            stock = new FournisseurManager();
            LoadStock();
        }

        private void FrmStock_Load(object sender, EventArgs e)
        {

        }
        private void LoadStock()
        {
            var stocks = stock.GetStock();
            listViewProducts.Items.Clear();
            foreach (var s in stocks)
            {
                ListViewItem lvi = new ListViewItem(new string[] { s.ReferenceP.ToString(), s.NameP, s.PriceP.ToString(), s.QuantiteP.ToString(), s.DateProduction.ToString(), s.DateExpiration.ToString(), s.nomCategorie });
                lvi.Tag = s;
                listViewProducts.Items.Add(lvi);
            }
        }
        //
        #region ignore for now
        private void txtbChercher_TextChanged(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtbChercher.Text))
                label1.Show();
            else
                label1.Hide();
        }

        private void txtbReference_TextChanged(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtbReference.Text))
                label6.Show();
            else
                label6.Hide();
        }

        private void txtbName_TextChanged(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtbName.Text))
                label5.Show();
            else
                label5.Hide();
        }

        private void txtbPrice_TextChanged(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtbPrice.Text))
                label3.Show();
            else
                label3.Hide();
        }

        private void txtbQuantity_TextChanged(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtbQuantity.Text))
                label4.Show();
            else
                label4.Hide();
        }

        private void txtbFAB_TextChanged(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtbFAB.Text))
                label7.Show();
            else
                label7.Hide();
        }

        private void txtbEXP_TextChanged(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtbEXP.Text))
                label8.Show();
            else
                label8.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtbReference.Text = "";
            txtbName.Text = "";
            txtbPrice.Text = "";
            txtbQuantity.Text = "";
            txtbFAB.Text = "";
            txtbEXP.Text = "";
        }
        #endregion
        //
    }
}
