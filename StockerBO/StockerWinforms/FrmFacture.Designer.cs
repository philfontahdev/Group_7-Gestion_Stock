namespace StockerWinforms
{
    partial class FrmFacture
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateProductionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateExpirationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCategorieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBquantity = new System.Windows.Forms.TextBox();
            this.tBNamep = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.btprint = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tBTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxproductname = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dateProductionDataGridViewTextBoxColumn,
            this.dateExpirationDataGridViewTextBoxColumn,
            this.idCategorieDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView1.DataSource = this.stockBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(11, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(641, 246);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ReferenceP";
            this.dataGridViewTextBoxColumn1.HeaderText = "ReferenceP";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NameP";
            this.dataGridViewTextBoxColumn2.HeaderText = "NameP";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PriceP";
            this.dataGridViewTextBoxColumn3.HeaderText = "PriceP";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "QuantiteP";
            this.dataGridViewTextBoxColumn4.HeaderText = "QuantiteP";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dateProductionDataGridViewTextBoxColumn
            // 
            this.dateProductionDataGridViewTextBoxColumn.DataPropertyName = "DateProduction";
            this.dateProductionDataGridViewTextBoxColumn.HeaderText = "DateProduction";
            this.dateProductionDataGridViewTextBoxColumn.Name = "dateProductionDataGridViewTextBoxColumn";
            // 
            // dateExpirationDataGridViewTextBoxColumn
            // 
            this.dateExpirationDataGridViewTextBoxColumn.DataPropertyName = "DateExpiration";
            this.dateExpirationDataGridViewTextBoxColumn.HeaderText = "DateExpiration";
            this.dateExpirationDataGridViewTextBoxColumn.Name = "dateExpirationDataGridViewTextBoxColumn";
            // 
            // idCategorieDataGridViewTextBoxColumn
            // 
            this.idCategorieDataGridViewTextBoxColumn.DataPropertyName = "idCategorie";
            this.idCategorieDataGridViewTextBoxColumn.HeaderText = "idCategorie";
            this.idCategorieDataGridViewTextBoxColumn.Name = "idCategorieDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "nomCategorie";
            this.dataGridViewTextBoxColumn5.HeaderText = "nomCategorie";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataSource = typeof(StockerBO.Stock);
            // 
            // tBquantity
            // 
            this.tBquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBquantity.Location = new System.Drawing.Point(237, 349);
            this.tBquantity.Multiline = true;
            this.tBquantity.Name = "tBquantity";
            this.tBquantity.Size = new System.Drawing.Size(214, 29);
            this.tBquantity.TabIndex = 3;
            // 
            // tBNamep
            // 
            this.tBNamep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBNamep.Location = new System.Drawing.Point(17, 349);
            this.tBNamep.Multiline = true;
            this.tBNamep.Name = "tBNamep";
            this.tBNamep.Size = new System.Drawing.Size(214, 29);
            this.tBNamep.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(234, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quantity :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name :";
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btAdd.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btAdd.FlatAppearance.BorderSize = 0;
            this.btAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Location = new System.Drawing.Point(596, 421);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(206, 28);
            this.btAdd.TabIndex = 7;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btRemove
            // 
            this.btRemove.BackColor = System.Drawing.Color.DarkGray;
            this.btRemove.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btRemove.FlatAppearance.BorderSize = 0;
            this.btRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemove.Location = new System.Drawing.Point(58, 421);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(214, 28);
            this.btRemove.TabIndex = 9;
            this.btRemove.Text = "Remove";
            this.btRemove.UseVisualStyleBackColor = false;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // btprint
            // 
            this.btprint.BackColor = System.Drawing.Color.Gray;
            this.btprint.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btprint.FlatAppearance.BorderSize = 0;
            this.btprint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btprint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btprint.Location = new System.Drawing.Point(342, 421);
            this.btprint.Name = "btprint";
            this.btprint.Size = new System.Drawing.Size(214, 28);
            this.btprint.TabIndex = 10;
            this.btprint.Text = "Print";
            this.btprint.UseVisualStyleBackColor = false;
            this.btprint.Click += new System.EventHandler(this.btprint_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Total :";
            // 
            // tBTotal
            // 
            this.tBTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBTotal.Location = new System.Drawing.Point(77, 384);
            this.tBTotal.Multiline = true;
            this.tBTotal.Name = "tBTotal";
            this.tBTotal.ReadOnly = true;
            this.tBTotal.Size = new System.Drawing.Size(140, 28);
            this.tBTotal.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(196, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "$";
            // 
            // comboBoxproductname
            // 
            this.comboBoxproductname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxproductname.FormattingEnabled = true;
            this.comboBoxproductname.Location = new System.Drawing.Point(668, 357);
            this.comboBoxproductname.Name = "comboBoxproductname";
            this.comboBoxproductname.Size = new System.Drawing.Size(214, 21);
            this.comboBoxproductname.TabIndex = 14;
            this.comboBoxproductname.Text = "Products";
            // 
            // FrmFacture
            // 
            this.AcceptButton = this.btAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1165, 500);
            this.Controls.Add(this.comboBoxproductname);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btprint);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tBTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBNamep);
            this.Controls.Add(this.tBquantity);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmFacture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POS";
            this.Load += new System.EventHandler(this.POS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tBquantity;
        private System.Windows.Forms.TextBox tBNamep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Button btprint;
        private System.Windows.Forms.DataGridViewTextBoxColumn referencePDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namePDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricePDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantitePDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCategorieDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateProductionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateExpirationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategorieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private System.Windows.Forms.ComboBox comboBoxproductname;
    }
}