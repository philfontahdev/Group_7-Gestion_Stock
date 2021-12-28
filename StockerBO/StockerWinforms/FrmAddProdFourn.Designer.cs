namespace StockerWinforms
{
    partial class FrmAddProdFourn
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
            this.label10 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.txtbQuantity = new System.Windows.Forms.TextBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.txtbPrice = new System.Windows.Forms.TextBox();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel18 = new System.Windows.Forms.Panel();
            this.txtbProd = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new StockerWinforms.STButton();
            this.btnAdd = new StockerWinforms.STButton();
            this.comboBoxCategorie = new System.Windows.Forms.ComboBox();
            this.textBref = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dateproduit = new System.Windows.Forms.DateTimePicker();
            this.dateperime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Window;
            this.label10.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(55, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(257, 18);
            this.label10.TabIndex = 181;
            this.label10.Text = "Ajouter un produit a un fournisseur";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel11.Location = new System.Drawing.Point(30, 246);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(5, 28);
            this.panel11.TabIndex = 176;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Menu;
            this.label6.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(38, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 14);
            this.label6.TabIndex = 175;
            this.label6.Text = "Quantite";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel12.Location = new System.Drawing.Point(30, 281);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(381, 4);
            this.panel12.TabIndex = 174;
            // 
            // txtbQuantity
            // 
            this.txtbQuantity.BackColor = System.Drawing.SystemColors.Menu;
            this.txtbQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbQuantity.Location = new System.Drawing.Point(41, 252);
            this.txtbQuantity.Name = "txtbQuantity";
            this.txtbQuantity.Size = new System.Drawing.Size(371, 21);
            this.txtbQuantity.TabIndex = 164;
            this.txtbQuantity.TextChanged += new System.EventHandler(this.txtbQuantity_TextChanged);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel13.Location = new System.Drawing.Point(30, 189);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(5, 28);
            this.panel13.TabIndex = 173;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Menu;
            this.label7.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(38, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 14);
            this.label7.TabIndex = 172;
            this.label7.Text = "Prix";
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel14.Location = new System.Drawing.Point(30, 224);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(381, 4);
            this.panel14.TabIndex = 171;
            // 
            // txtbPrice
            // 
            this.txtbPrice.BackColor = System.Drawing.SystemColors.Menu;
            this.txtbPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbPrice.Location = new System.Drawing.Point(41, 194);
            this.txtbPrice.Name = "txtbPrice";
            this.txtbPrice.Size = new System.Drawing.Size(371, 21);
            this.txtbPrice.TabIndex = 163;
            this.txtbPrice.TextChanged += new System.EventHandler(this.txtbPrice_TextChanged);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel15.Location = new System.Drawing.Point(30, 130);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(5, 28);
            this.panel15.TabIndex = 170;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel16.Location = new System.Drawing.Point(30, 74);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(5, 28);
            this.panel16.TabIndex = 169;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel17.Location = new System.Drawing.Point(30, 164);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(381, 4);
            this.panel17.TabIndex = 167;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Menu;
            this.label9.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(38, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 14);
            this.label9.TabIndex = 166;
            this.label9.Text = "Produit";
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel18.Location = new System.Drawing.Point(30, 108);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(381, 4);
            this.panel18.TabIndex = 165;
            // 
            // txtbProd
            // 
            this.txtbProd.BackColor = System.Drawing.SystemColors.Menu;
            this.txtbProd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbProd.Location = new System.Drawing.Point(41, 80);
            this.txtbProd.Name = "txtbProd";
            this.txtbProd.Size = new System.Drawing.Size(371, 21);
            this.txtbProd.TabIndex = 161;
            this.txtbProd.TextChanged += new System.EventHandler(this.txtbProd_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(30, 323);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(382, 23);
            this.dateTimePicker1.TabIndex = 160;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 299);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 159;
            this.label1.Text = "Livre le :";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCancel.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.btnCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancel.BorderRadius = 30;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(298, 480);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 38);
            this.btnCancel.TabIndex = 180;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnAdd.BackgroundColor = System.Drawing.Color.DarkTurquoise;
            this.btnAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAdd.BorderRadius = 30;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(29, 480);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 38);
            this.btnAdd.TabIndex = 178;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // comboBoxCategorie
            // 
            this.comboBoxCategorie.FormattingEnabled = true;
            this.comboBoxCategorie.Location = new System.Drawing.Point(34, 130);
            this.comboBoxCategorie.Name = "comboBoxCategorie";
            this.comboBoxCategorie.Size = new System.Drawing.Size(378, 29);
            this.comboBoxCategorie.TabIndex = 182;
            this.comboBoxCategorie.Text = "Categories";
            // 
            // textBref
            // 
            this.textBref.BackColor = System.Drawing.SystemColors.Menu;
            this.textBref.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBref.Location = new System.Drawing.Point(40, 41);
            this.textBref.Name = "textBref";
            this.textBref.Size = new System.Drawing.Size(371, 21);
            this.textBref.TabIndex = 183;
            this.textBref.TextChanged += new System.EventHandler(this.textBref_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Location = new System.Drawing.Point(30, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 4);
            this.panel1.TabIndex = 184;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel2.Location = new System.Drawing.Point(30, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 28);
            this.panel2.TabIndex = 185;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Menu;
            this.label2.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(41, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 186;
            this.label2.Text = "Reference";
            // 
            // dateproduit
            // 
            this.dateproduit.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateproduit.Location = new System.Drawing.Point(29, 376);
            this.dateproduit.Margin = new System.Windows.Forms.Padding(6);
            this.dateproduit.Name = "dateproduit";
            this.dateproduit.Size = new System.Drawing.Size(382, 23);
            this.dateproduit.TabIndex = 187;
            // 
            // dateperime
            // 
            this.dateperime.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateperime.Location = new System.Drawing.Point(29, 427);
            this.dateperime.Margin = new System.Windows.Forms.Padding(6);
            this.dateperime.Name = "dateperime";
            this.dateperime.Size = new System.Drawing.Size(382, 23);
            this.dateperime.TabIndex = 188;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 355);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 189;
            this.label3.Text = "Produit le :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 406);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 190;
            this.label4.Text = "Perime le :";
            // 
            // FrmAddProdFourn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(442, 530);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateperime);
            this.Controls.Add(this.dateproduit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBref);
            this.Controls.Add(this.comboBoxCategorie);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.txtbQuantity);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.txtbPrice);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.panel16);
            this.Controls.Add(this.panel17);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel18);
            this.Controls.Add(this.txtbProd);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddProdFourn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddProdFourn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private STButton btnCancel;
        private STButton btnAdd;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox txtbQuantity;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.TextBox txtbPrice;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.TextBox txtbProd;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCategorie;
        private System.Windows.Forms.TextBox textBref;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateproduit;
        private System.Windows.Forms.DateTimePicker dateperime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}