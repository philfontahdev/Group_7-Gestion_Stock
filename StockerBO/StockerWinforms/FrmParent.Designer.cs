
namespace StockerWinforms
{
    partial class FrmParent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmParent));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnQuitte = new StockerWinforms.STButton();
            this.btnFournisseur = new StockerWinforms.STButton();
            this.btnThem = new StockerWinforms.STButton();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnClient = new StockerWinforms.STButton();
            this.btnCategorie = new StockerWinforms.STButton();
            this.POS = new StockerWinforms.STButton();
            this.btnCommande = new StockerWinforms.STButton();
            this.btnStock = new StockerWinforms.STButton();
            this.pnlTitre = new System.Windows.Forms.Panel();
            this.btnCloseChildForm = new StockerWinforms.STButton();
            this.labelTitre = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.btnMaximise = new StockerWinforms.STButton();
            this.btnMinimise = new StockerWinforms.STButton();
            this.btnQuit = new StockerWinforms.STButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlParent = new System.Windows.Forms.Panel();
            this.btnFacture = new StockerWinforms.STButton();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlTitre.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.DarkTurquoise;
            this.pnlMenu.Controls.Add(this.btnFacture);
            this.pnlMenu.Controls.Add(this.btnQuitte);
            this.pnlMenu.Controls.Add(this.btnFournisseur);
            this.pnlMenu.Controls.Add(this.btnThem);
            this.pnlMenu.Controls.Add(this.pbLogo);
            this.pnlMenu.Controls.Add(this.btnClient);
            this.pnlMenu.Controls.Add(this.btnCategorie);
            this.pnlMenu.Controls.Add(this.POS);
            this.pnlMenu.Controls.Add(this.btnCommande);
            this.pnlMenu.Controls.Add(this.btnStock);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(141, 573);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnQuitte
            // 
            this.btnQuitte.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnQuitte.BackColor = System.Drawing.Color.Red;
            this.btnQuitte.BackgroundColor = System.Drawing.Color.Red;
            this.btnQuitte.BorderColor = System.Drawing.Color.Black;
            this.btnQuitte.BorderRadius = 20;
            this.btnQuitte.BorderSize = 0;
            this.btnQuitte.FlatAppearance.BorderSize = 0;
            this.btnQuitte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitte.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitte.ForeColor = System.Drawing.Color.White;
            this.btnQuitte.Image = global::StockerWinforms.Properties.Resources.sign_out_24px;
            this.btnQuitte.Location = new System.Drawing.Point(6, 521);
            this.btnQuitte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQuitte.Name = "btnQuitte";
            this.btnQuitte.Size = new System.Drawing.Size(130, 45);
            this.btnQuitte.TabIndex = 8;
            this.btnQuitte.TextColor = System.Drawing.Color.White;
            this.btnQuitte.UseVisualStyleBackColor = false;
            this.btnQuitte.Click += new System.EventHandler(this.btnQuitte_Click_1);
            // 
            // btnFournisseur
            // 
            this.btnFournisseur.BackColor = System.Drawing.Color.White;
            this.btnFournisseur.BackgroundColor = System.Drawing.Color.White;
            this.btnFournisseur.BorderColor = System.Drawing.Color.Black;
            this.btnFournisseur.BorderRadius = 20;
            this.btnFournisseur.BorderSize = 0;
            this.btnFournisseur.FlatAppearance.BorderSize = 0;
            this.btnFournisseur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFournisseur.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFournisseur.ForeColor = System.Drawing.Color.Black;
            this.btnFournisseur.Image = global::StockerWinforms.Properties.Resources.management_30px1;
            this.btnFournisseur.Location = new System.Drawing.Point(6, 316);
            this.btnFournisseur.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFournisseur.Name = "btnFournisseur";
            this.btnFournisseur.Size = new System.Drawing.Size(130, 45);
            this.btnFournisseur.TabIndex = 7;
            this.btnFournisseur.Text = "    Fournisseur";
            this.btnFournisseur.TextColor = System.Drawing.Color.Black;
            this.btnFournisseur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFournisseur.UseVisualStyleBackColor = false;
            this.btnFournisseur.Click += new System.EventHandler(this.btnFournisseur_Click);
            this.btnFournisseur.MouseEnter += new System.EventHandler(this.btnFournisseur_MouseEnter_1);
            this.btnFournisseur.MouseLeave += new System.EventHandler(this.btnFournisseur_MouseLeave);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.BackgroundColor = System.Drawing.Color.White;
            this.btnThem.BorderColor = System.Drawing.Color.Black;
            this.btnThem.BorderRadius = 20;
            this.btnThem.BorderSize = 0;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Image = global::StockerWinforms.Properties.Resources.gears_48px;
            this.btnThem.Location = new System.Drawing.Point(6, 366);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(130, 45);
            this.btnThem.TabIndex = 6;
            this.btnThem.TextColor = System.Drawing.Color.Black;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            this.btnThem.MouseEnter += new System.EventHandler(this.btnThem_MouseEnter);
            this.btnThem.MouseLeave += new System.EventHandler(this.btnThem_MouseLeave);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(130, 63);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 2;
            this.pbLogo.TabStop = false;
            // 
            // btnClient
            // 
            this.btnClient.BackColor = System.Drawing.Color.White;
            this.btnClient.BackgroundColor = System.Drawing.Color.White;
            this.btnClient.BorderColor = System.Drawing.Color.Black;
            this.btnClient.BorderRadius = 20;
            this.btnClient.BorderSize = 0;
            this.btnClient.FlatAppearance.BorderSize = 0;
            this.btnClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClient.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient.ForeColor = System.Drawing.Color.Black;
            this.btnClient.Image = global::StockerWinforms.Properties.Resources.management_30px;
            this.btnClient.Location = new System.Drawing.Point(6, 167);
            this.btnClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(130, 45);
            this.btnClient.TabIndex = 5;
            this.btnClient.Text = "Client";
            this.btnClient.TextColor = System.Drawing.Color.Black;
            this.btnClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClient.UseVisualStyleBackColor = false;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            this.btnClient.MouseEnter += new System.EventHandler(this.btnClient_MouseEnter);
            this.btnClient.MouseLeave += new System.EventHandler(this.btnClient_MouseLeave);
            // 
            // btnCategorie
            // 
            this.btnCategorie.BackColor = System.Drawing.Color.White;
            this.btnCategorie.BackgroundColor = System.Drawing.Color.White;
            this.btnCategorie.BorderColor = System.Drawing.Color.Black;
            this.btnCategorie.BorderRadius = 20;
            this.btnCategorie.BorderSize = 0;
            this.btnCategorie.FlatAppearance.BorderSize = 0;
            this.btnCategorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorie.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorie.ForeColor = System.Drawing.Color.Black;
            this.btnCategorie.Image = global::StockerWinforms.Properties.Resources.categorize_26px;
            this.btnCategorie.Location = new System.Drawing.Point(6, 118);
            this.btnCategorie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCategorie.Name = "btnCategorie";
            this.btnCategorie.Size = new System.Drawing.Size(130, 45);
            this.btnCategorie.TabIndex = 4;
            this.btnCategorie.Text = "Categorie";
            this.btnCategorie.TextColor = System.Drawing.Color.Black;
            this.btnCategorie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCategorie.UseVisualStyleBackColor = false;
            this.btnCategorie.Click += new System.EventHandler(this.btnCategorie_Click);
            this.btnCategorie.MouseEnter += new System.EventHandler(this.btnCategorie_MouseEnter);
            this.btnCategorie.MouseLeave += new System.EventHandler(this.btnCategorie_MouseLeave);
            // 
            // POS
            // 
            this.POS.BackColor = System.Drawing.Color.White;
            this.POS.BackgroundColor = System.Drawing.Color.White;
            this.POS.BorderColor = System.Drawing.Color.Black;
            this.POS.BorderRadius = 20;
            this.POS.BorderSize = 0;
            this.POS.FlatAppearance.BorderSize = 0;
            this.POS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.POS.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.POS.ForeColor = System.Drawing.Color.Black;
            this.POS.Image = global::StockerWinforms.Properties.Resources.bill_30px;
            this.POS.Location = new System.Drawing.Point(6, 266);
            this.POS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.POS.Name = "POS";
            this.POS.Size = new System.Drawing.Size(130, 45);
            this.POS.TabIndex = 2;
            this.POS.Text = "POS";
            this.POS.TextColor = System.Drawing.Color.Black;
            this.POS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.POS.UseVisualStyleBackColor = false;
            this.POS.Click += new System.EventHandler(this.btnFacture_Click);
            this.POS.MouseEnter += new System.EventHandler(this.btnFacture_MouseEnter_1);
            this.POS.MouseLeave += new System.EventHandler(this.btnFacture_MouseLeave);
            // 
            // btnCommande
            // 
            this.btnCommande.BackColor = System.Drawing.Color.White;
            this.btnCommande.BackgroundColor = System.Drawing.Color.White;
            this.btnCommande.BorderColor = System.Drawing.Color.Black;
            this.btnCommande.BorderRadius = 20;
            this.btnCommande.BorderSize = 0;
            this.btnCommande.FlatAppearance.BorderSize = 0;
            this.btnCommande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommande.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommande.ForeColor = System.Drawing.Color.Black;
            this.btnCommande.Image = global::StockerWinforms.Properties.Resources.order_history_30px;
            this.btnCommande.Location = new System.Drawing.Point(6, 217);
            this.btnCommande.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCommande.Name = "btnCommande";
            this.btnCommande.Size = new System.Drawing.Size(130, 45);
            this.btnCommande.TabIndex = 1;
            this.btnCommande.Text = "Commande";
            this.btnCommande.TextColor = System.Drawing.Color.Black;
            this.btnCommande.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCommande.UseVisualStyleBackColor = false;
            this.btnCommande.Click += new System.EventHandler(this.btnCommande_Click);
            this.btnCommande.MouseEnter += new System.EventHandler(this.btnCommande_MouseEnter);
            this.btnCommande.MouseLeave += new System.EventHandler(this.btnCommande_MouseLeave);
            // 
            // btnStock
            // 
            this.btnStock.BackColor = System.Drawing.Color.White;
            this.btnStock.BackgroundColor = System.Drawing.Color.White;
            this.btnStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStock.BorderColor = System.Drawing.Color.Black;
            this.btnStock.BorderRadius = 20;
            this.btnStock.BorderSize = 0;
            this.btnStock.FlatAppearance.BorderSize = 0;
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.ForeColor = System.Drawing.Color.Black;
            this.btnStock.Image = global::StockerWinforms.Properties.Resources.gold_bars_32px;
            this.btnStock.Location = new System.Drawing.Point(6, 68);
            this.btnStock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(130, 45);
            this.btnStock.TabIndex = 0;
            this.btnStock.Text = "Stock";
            this.btnStock.TextColor = System.Drawing.Color.Black;
            this.btnStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            this.btnStock.MouseEnter += new System.EventHandler(this.btnStock_MouseEnter);
            this.btnStock.MouseLeave += new System.EventHandler(this.btnStock_MouseLeave);
            // 
            // pnlTitre
            // 
            this.pnlTitre.BackColor = System.Drawing.Color.DarkTurquoise;
            this.pnlTitre.Controls.Add(this.btnCloseChildForm);
            this.pnlTitre.Controls.Add(this.labelTitre);
            this.pnlTitre.Controls.Add(this.labelUserName);
            this.pnlTitre.Controls.Add(this.btnMaximise);
            this.pnlTitre.Controls.Add(this.btnMinimise);
            this.pnlTitre.Controls.Add(this.btnQuit);
            this.pnlTitre.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitre.Location = new System.Drawing.Point(141, 0);
            this.pnlTitre.Name = "pnlTitre";
            this.pnlTitre.Size = new System.Drawing.Size(913, 68);
            this.pnlTitre.TabIndex = 1;
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCloseChildForm.BackColor = System.Drawing.Color.White;
            this.btnCloseChildForm.BackgroundColor = System.Drawing.Color.White;
            this.btnCloseChildForm.BorderColor = System.Drawing.Color.Black;
            this.btnCloseChildForm.BorderRadius = 20;
            this.btnCloseChildForm.BorderSize = 0;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseChildForm.ForeColor = System.Drawing.Color.White;
            this.btnCloseChildForm.Image = global::StockerWinforms.Properties.Resources.external_24px;
            this.btnCloseChildForm.Location = new System.Drawing.Point(2, 14);
            this.btnCloseChildForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(26, 30);
            this.btnCloseChildForm.TabIndex = 9;
            this.btnCloseChildForm.TextColor = System.Drawing.Color.White;
            this.btnCloseChildForm.UseVisualStyleBackColor = false;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // labelTitre
            // 
            this.labelTitre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.ForeColor = System.Drawing.Color.DimGray;
            this.labelTitre.Location = new System.Drawing.Point(425, 24);
            this.labelTitre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(85, 18);
            this.labelTitre.TabIndex = 4;
            this.labelTitre.Text = "ACCUEIL";
            // 
            // labelUserName
            // 
            this.labelUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.ForeColor = System.Drawing.Color.DimGray;
            this.labelUserName.Location = new System.Drawing.Point(709, 14);
            this.labelUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(75, 17);
            this.labelUserName.TabIndex = 3;
            this.labelUserName.Text = "UserName";
            // 
            // btnMaximise
            // 
            this.btnMaximise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximise.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnMaximise.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.btnMaximise.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnMaximise.BorderRadius = 16;
            this.btnMaximise.BorderSize = 0;
            this.btnMaximise.FlatAppearance.BorderSize = 0;
            this.btnMaximise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximise.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximise.ForeColor = System.Drawing.Color.White;
            this.btnMaximise.Location = new System.Drawing.Point(837, 9);
            this.btnMaximise.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMaximise.Name = "btnMaximise";
            this.btnMaximise.Size = new System.Drawing.Size(32, 24);
            this.btnMaximise.TabIndex = 2;
            this.btnMaximise.Text = "O";
            this.btnMaximise.TextColor = System.Drawing.Color.White;
            this.btnMaximise.UseVisualStyleBackColor = false;
            this.btnMaximise.Click += new System.EventHandler(this.btnMaximise_Click);
            // 
            // btnMinimise
            // 
            this.btnMinimise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimise.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnMinimise.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.btnMinimise.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnMinimise.BorderRadius = 16;
            this.btnMinimise.BorderSize = 0;
            this.btnMinimise.FlatAppearance.BorderSize = 0;
            this.btnMinimise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimise.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimise.ForeColor = System.Drawing.Color.White;
            this.btnMinimise.Location = new System.Drawing.Point(801, 9);
            this.btnMinimise.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMinimise.Name = "btnMinimise";
            this.btnMinimise.Size = new System.Drawing.Size(32, 24);
            this.btnMinimise.TabIndex = 1;
            this.btnMinimise.Text = "--";
            this.btnMinimise.TextColor = System.Drawing.Color.White;
            this.btnMinimise.UseVisualStyleBackColor = false;
            this.btnMinimise.Click += new System.EventHandler(this.btnMinimise_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuit.BackColor = System.Drawing.Color.Red;
            this.btnQuit.BackgroundColor = System.Drawing.Color.Red;
            this.btnQuit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnQuit.BorderRadius = 16;
            this.btnQuit.BorderSize = 0;
            this.btnQuit.FlatAppearance.BorderSize = 0;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.White;
            this.btnQuit.Location = new System.Drawing.Point(873, 9);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(32, 24);
            this.btnQuit.TabIndex = 0;
            this.btnQuit.Text = "X";
            this.btnQuit.TextColor = System.Drawing.Color.White;
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(141, 565);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(913, 8);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1046, 68);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 497);
            this.panel2.TabIndex = 4;
            // 
            // pnlParent
            // 
            this.pnlParent.BackColor = System.Drawing.Color.White;
            this.pnlParent.BackgroundImage = global::StockerWinforms.Properties.Resources._19831_bubka_piechart;
            this.pnlParent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlParent.Location = new System.Drawing.Point(141, 68);
            this.pnlParent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlParent.Name = "pnlParent";
            this.pnlParent.Size = new System.Drawing.Size(913, 505);
            this.pnlParent.TabIndex = 2;
            // 
            // btnFacture
            // 
            this.btnFacture.BackColor = System.Drawing.Color.White;
            this.btnFacture.BackgroundColor = System.Drawing.Color.White;
            this.btnFacture.BorderColor = System.Drawing.Color.Black;
            this.btnFacture.BorderRadius = 20;
            this.btnFacture.BorderSize = 0;
            this.btnFacture.FlatAppearance.BorderSize = 0;
            this.btnFacture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacture.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacture.ForeColor = System.Drawing.Color.Black;
            this.btnFacture.Image = global::StockerWinforms.Properties.Resources.bill_30px;
            this.btnFacture.Location = new System.Drawing.Point(6, 415);
            this.btnFacture.Margin = new System.Windows.Forms.Padding(2);
            this.btnFacture.Name = "btnFacture";
            this.btnFacture.Size = new System.Drawing.Size(130, 45);
            this.btnFacture.TabIndex = 9;
            this.btnFacture.Text = "Facture";
            this.btnFacture.TextColor = System.Drawing.Color.Black;
            this.btnFacture.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFacture.UseVisualStyleBackColor = false;
            // 
            // FrmParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 573);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlParent);
            this.Controls.Add(this.pnlTitre);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmParent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormParent";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlTitre.ResumeLayout(false);
            this.pnlTitre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private STButton btnStock;
        private System.Windows.Forms.PictureBox pbLogo;
        private STButton btnClient;
        private STButton btnCategorie;
        private STButton POS;
        private STButton btnCommande;
        private System.Windows.Forms.Panel pnlTitre;
        private System.Windows.Forms.Panel pnlParent;
        private STButton btnFournisseur;
        private STButton btnThem;
        private STButton btnQuitte;
        private STButton btnMaximise;
        private STButton btnMinimise;
        private STButton btnQuit;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private STButton btnCloseChildForm;
        private STButton btnFacture;
    }
}