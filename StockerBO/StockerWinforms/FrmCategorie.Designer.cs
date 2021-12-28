namespace StockerWinforms
{
    partial class FrmCategorie
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
            this.btnDelete = new StockerWinforms.STButton();
            this.btnCancel = new StockerWinforms.STButton();
            this.btnAdd = new StockerWinforms.STButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtbName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtbId = new System.Windows.Forms.TextBox();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewcategorie = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbChercher = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.stButton1 = new StockerWinforms.STButton();
            this.Search = new StockerWinforms.STButton();
            this.Refresh = new StockerWinforms.STButton();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.BackgroundColor = System.Drawing.Color.Red;
            this.btnDelete.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDelete.BorderRadius = 20;
            this.btnDelete.BorderSize = 0;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(1087, 479);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 40);
            this.btnDelete.TabIndex = 61;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCancel.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.btnCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancel.BorderRadius = 20;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(929, 479);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 40);
            this.btnCancel.TabIndex = 60;
            this.btnCancel.Text = "Reset";
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnAdd.BackgroundColor = System.Drawing.Color.DarkTurquoise;
            this.btnAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAdd.BorderRadius = 20;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(873, 433);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 40);
            this.btnAdd.TabIndex = 59;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel7.Location = new System.Drawing.Point(872, 355);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(5, 30);
            this.panel7.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Menu;
            this.label4.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(885, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 14);
            this.label4.TabIndex = 57;
            this.label4.Text = "Nom";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel8.Location = new System.Drawing.Point(872, 391);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(382, 5);
            this.panel8.TabIndex = 56;
            // 
            // txtbName
            // 
            this.txtbName.BackColor = System.Drawing.SystemColors.Menu;
            this.txtbName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbName.Location = new System.Drawing.Point(883, 360);
            this.txtbName.Name = "txtbName";
            this.txtbName.Size = new System.Drawing.Size(371, 21);
            this.txtbName.TabIndex = 55;
            this.txtbName.TextChanged += new System.EventHandler(this.txtbName_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Location = new System.Drawing.Point(872, 266);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 30);
            this.panel1.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Menu;
            this.label3.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(885, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 14);
            this.label3.TabIndex = 53;
            this.label3.Text = "Identifiant";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel2.Location = new System.Drawing.Point(872, 302);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(382, 5);
            this.panel2.TabIndex = 52;
            // 
            // txtbId
            // 
            this.txtbId.BackColor = System.Drawing.SystemColors.Menu;
            this.txtbId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbId.Location = new System.Drawing.Point(883, 271);
            this.txtbId.Name = "txtbId";
            this.txtbId.Size = new System.Drawing.Size(371, 21);
            this.txtbId.TabIndex = 51;
            this.txtbId.TextChanged += new System.EventHandler(this.txtbId_TextChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nom de la categorie";
            this.columnHeader2.Width = 300;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Identifiant";
            this.columnHeader1.Width = 200;
            // 
            // listViewcategorie
            // 
            this.listViewcategorie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewcategorie.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewcategorie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listViewcategorie.GridLines = true;
            this.listViewcategorie.HideSelection = false;
            this.listViewcategorie.Location = new System.Drawing.Point(141, 87);
            this.listViewcategorie.Name = "listViewcategorie";
            this.listViewcategorie.Size = new System.Drawing.Size(636, 309);
            this.listViewcategorie.TabIndex = 42;
            this.listViewcategorie.UseCompatibleStateImageBehavior = false;
            this.listViewcategorie.View = System.Windows.Forms.View.Details;
            this.listViewcategorie.SelectedIndexChanged += new System.EventHandler(this.listViewcategorie_SelectedIndexChanged);
            // 
            // listView2
            // 
            this.listView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader3,
            this.columnHeader4});
            this.listView2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(141, 433);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(636, 309);
            this.listView2.TabIndex = 62;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Reference ";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Nom";
            this.columnHeader6.Width = 150;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Prix";
            this.columnHeader7.Width = 140;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Quantite";
            this.columnHeader8.Width = 110;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "FAB";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "EXP";
            this.columnHeader4.Width = 120;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Orange;
            this.panel5.Location = new System.Drawing.Point(131, 36);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 30);
            this.panel5.TabIndex = 75;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Orange;
            this.panel3.Location = new System.Drawing.Point(131, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(646, 5);
            this.panel3.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Menu;
            this.label1.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(141, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 14);
            this.label1.TabIndex = 73;
            this.label1.Text = "Chercher une categorie";
            // 
            // txtbChercher
            // 
            this.txtbChercher.BackColor = System.Drawing.SystemColors.Menu;
            this.txtbChercher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbChercher.Location = new System.Drawing.Point(141, 39);
            this.txtbChercher.Name = "txtbChercher";
            this.txtbChercher.Size = new System.Drawing.Size(636, 21);
            this.txtbChercher.TabIndex = 72;
            this.txtbChercher.TextChanged += new System.EventHandler(this.txtbChercher_TextChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Orange;
            this.panel4.Location = new System.Drawing.Point(130, 92);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 295);
            this.panel4.TabIndex = 77;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Orange;
            this.panel6.Location = new System.Drawing.Point(152, 401);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(615, 5);
            this.panel6.TabIndex = 76;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.LimeGreen;
            this.panel9.Location = new System.Drawing.Point(130, 454);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(5, 280);
            this.panel9.TabIndex = 79;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.LimeGreen;
            this.panel10.Location = new System.Drawing.Point(152, 748);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(615, 5);
            this.panel10.TabIndex = 78;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(968, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 23);
            this.label2.TabIndex = 80;
            this.label2.Text = "Ajouter une categorie";
            // 
            // stButton1
            // 
            this.stButton1.BackColor = System.Drawing.Color.SpringGreen;
            this.stButton1.BackgroundColor = System.Drawing.Color.SpringGreen;
            this.stButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.stButton1.BorderRadius = 20;
            this.stButton1.BorderSize = 0;
            this.stButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stButton1.FlatAppearance.BorderSize = 0;
            this.stButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stButton1.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stButton1.ForeColor = System.Drawing.Color.White;
            this.stButton1.Location = new System.Drawing.Point(1141, 433);
            this.stButton1.Name = "stButton1";
            this.stButton1.Size = new System.Drawing.Size(113, 40);
            this.stButton1.TabIndex = 81;
            this.stButton1.Text = "Modifier";
            this.stButton1.TextColor = System.Drawing.Color.White;
            this.stButton1.UseVisualStyleBackColor = false;
            this.stButton1.Click += new System.EventHandler(this.stButton1_Click);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Search.BackgroundColor = System.Drawing.Color.DarkTurquoise;
            this.Search.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Search.BorderRadius = 20;
            this.Search.BorderSize = 0;
            this.Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search.FlatAppearance.BorderSize = 0;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ForeColor = System.Drawing.Color.White;
            this.Search.Location = new System.Drawing.Point(824, 36);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(113, 40);
            this.Search.TabIndex = 82;
            this.Search.Text = "Search";
            this.Search.TextColor = System.Drawing.Color.White;
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Refresh
            // 
            this.Refresh.BackColor = System.Drawing.Color.SpringGreen;
            this.Refresh.BackgroundColor = System.Drawing.Color.SpringGreen;
            this.Refresh.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Refresh.BorderRadius = 20;
            this.Refresh.BorderSize = 0;
            this.Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Refresh.FlatAppearance.BorderSize = 0;
            this.Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Refresh.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh.ForeColor = System.Drawing.Color.White;
            this.Refresh.Location = new System.Drawing.Point(999, 124);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(113, 40);
            this.Refresh.TabIndex = 83;
            this.Refresh.Text = "Refresh";
            this.Refresh.TextColor = System.Drawing.Color.White;
            this.Refresh.UseVisualStyleBackColor = false;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // FrmCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.stButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbChercher);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.txtbName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtbId);
            this.Controls.Add(this.listViewcategorie);
            this.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmCategorie";
            this.Text = "Categorie";
            this.Load += new System.EventHandler(this.FrmCategorie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private STButton btnDelete;
        private STButton btnCancel;
        private STButton btnAdd;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtbName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtbId;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView listViewcategorie;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbChercher;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label2;
        private STButton stButton1;
        private STButton Search;
        private STButton Refresh;
    }
}