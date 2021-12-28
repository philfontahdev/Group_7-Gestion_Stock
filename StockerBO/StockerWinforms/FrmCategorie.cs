using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using StockerBLL;
using StockerBO;



namespace StockerWinforms
{
    public partial class FrmCategorie : Form
    {
        private CategoryManager categoryManager;
        private List<Categorie> categories;
        private Categorie editcat;

        public FrmCategorie()
        {
            InitializeComponent();
            categoryManager = new CategoryManager();
            categories = new List<Categorie>();
            editcat = new Categorie();
            LoadCategorie();
            txtbId.Visible = false;
        }

        private void FrmCategorie_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtbId.Clear() ;
            txtbName.Clear();
            txtbId.Visible = false;
            editcat = null;
        }

        private void listViewcategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewcategorie.SelectedItems.Count == 0)
                return;
            var cat = listViewcategorie.SelectedItems[0].Tag as Categorie;
        }

        //
        #region TextChanged
        private void txtbChercher_TextChanged(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtbChercher.Text))
                label1.Show();
            else
                label1.Hide();
        }

        private void txtbId_TextChanged(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtbId.Text))
                label3.Show();
            else
                label3.Hide();
        }

        private void txtbName_TextChanged(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtbName.Text))
                label4.Show();
            else
                label4.Hide();
        }
        #endregion
        //

        //
        #region AddCategory
        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            if (txtbName.Text.Length > 0)
            {
                if(editcat == null)
                {
                    Random run = new Random();
                    var tune = run.Next();
                    int ed = tune;
                    txtbId.Text = ed.ToString();
                    Categorie categoriex = new Categorie(int.Parse(txtbId.Text), txtbName.Text);

                    categoryManager.Add(categoriex);
                    categories.Add(categoriex);

                    foreach (var p in categories)
                    {
                        ListViewItem lvi = new ListViewItem(new string[] { txtbId.Text, txtbName.Text });
                        lvi.Tag = p;
                        listViewcategorie.Items.Add(lvi);
                        btnCancel_Click(sender, e);
                    }
                }
                else
                {
                    Categorie categoriex = new Categorie(int.Parse(txtbId.Text), txtbName.Text);
                    categoryManager.Editcat(editcat, categoriex);
                    LoadCategorie();
                    txtbId.Visible = false;

                }
               
            }
            else
            {
                txtbName.BackColor = Color.MistyRose;
                MessageBox.Show("Enter Categorie discription", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtbName.BackColor = Color.White;
            }

        }
        #endregion
        //

        //
        #region EditCategorie
        private void stButton1_Click(object sender, EventArgs e)
        {
            if (listViewcategorie.SelectedItems.Count == 0)
                return;
            var cat = listViewcategorie.SelectedItems[0].Tag as Categorie;
            txtbId.Text = cat.idCategorie.ToString();
            txtbName.Text = cat.nomCategorie;
            editcat = cat;
            txtbId.Visible = true;
            LoadCategorie();
        }
        #endregion
        //


        //
        #region LoadCategory
        private void LoadCategorie()
        {
            var cat = categoryManager.Getcat();
            listViewcategorie.Items.Clear();
            foreach (var c in cat)
            {
                ListViewItem lvi = new ListViewItem(new string[] { c.idCategorie.ToString(), c.nomCategorie });
                lvi.Tag = c;
                listViewcategorie.Items.Add(lvi);
            }
        }


        #endregion
        //

        //
        #region DeleteCategory
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listViewcategorie.SelectedItems.Count == 0)
                return;
            var cat = listViewcategorie.SelectedItems[0].Tag as Categorie;
            categoryManager.Delete(cat);
            LoadCategorie();

        }

        #endregion
        //

        //
        #region SearchCategory
        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                var search = categoryManager.Find(txtbChercher.Text);
                listViewcategorie.Items.Clear();
                foreach (var c in search)
                {

                    ListViewItem lvi = new ListViewItem(new string[] { c.idCategorie.ToString(), c.nomCategorie });
                    lvi.Tag = c;
                    listViewcategorie.Items.Add(lvi);

                }
            }
            catch
            {
                MessageBox.Show($"{txtbChercher.Text} Not Found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            LoadCategorie();
        }
        #endregion
        //
    }
}
