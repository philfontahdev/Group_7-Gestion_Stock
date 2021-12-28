
namespace StockerWinforms
{
    partial class FrmLogin
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtbEmail = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtbMDP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.stButton1 = new StockerWinforms.STButton();
            this.stButton8 = new StockerWinforms.STButton();
            this.stButton5 = new StockerWinforms.STButton();
            this.btnOk = new StockerWinforms.STButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 87);
            this.panel1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(125, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Connexion ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel2.Controls.Add(this.stButton1);
            this.panel2.Controls.Add(this.stButton8);
            this.panel2.Controls.Add(this.stButton5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 442);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(376, 100);
            this.panel2.TabIndex = 10;
            // 
            // txtbEmail
            // 
            this.txtbEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbEmail.Location = new System.Drawing.Point(23, 213);
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.Size = new System.Drawing.Size(342, 27);
            this.txtbEmail.TabIndex = 0;
            this.txtbEmail.TextChanged += new System.EventHandler(this.txtbEmail_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel3.Location = new System.Drawing.Point(12, 241);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(353, 5);
            this.panel3.TabIndex = 14;
            // 
            // txtbMDP
            // 
            this.txtbMDP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbMDP.Location = new System.Drawing.Point(23, 296);
            this.txtbMDP.Name = "txtbMDP";
            this.txtbMDP.Size = new System.Drawing.Size(332, 27);
            this.txtbMDP.TabIndex = 1;
            this.txtbMDP.UseSystemPasswordChar = true;
            this.txtbMDP.TextChanged += new System.EventHandler(this.txtbMDP_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(20, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Email";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel4.Location = new System.Drawing.Point(12, 325);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(353, 5);
            this.panel4.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(20, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Mot de passe";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(345, 306);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel5.Location = new System.Drawing.Point(12, 209);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 28);
            this.panel5.TabIndex = 21;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel6.Location = new System.Drawing.Point(12, 291);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 28);
            this.panel6.TabIndex = 22;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::StockerWinforms.Properties.Resources.closed_eye_24px;
            this.pictureBox2.Location = new System.Drawing.Point(339, 276);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StockerWinforms.Properties.Resources.eye_26px;
            this.pictureBox1.Location = new System.Drawing.Point(339, 274);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // stButton1
            // 
            this.stButton1.BackColor = System.Drawing.Color.White;
            this.stButton1.BackgroundColor = System.Drawing.Color.White;
            this.stButton1.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.stButton1.BorderRadius = 10;
            this.stButton1.BorderSize = 0;
            this.stButton1.FlatAppearance.BorderSize = 0;
            this.stButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stButton1.ForeColor = System.Drawing.Color.White;
            this.stButton1.Location = new System.Drawing.Point(182, 21);
            this.stButton1.Name = "stButton1";
            this.stButton1.Size = new System.Drawing.Size(13, 10);
            this.stButton1.TabIndex = 30;
            this.stButton1.TextColor = System.Drawing.Color.White;
            this.stButton1.UseVisualStyleBackColor = false;
            // 
            // stButton8
            // 
            this.stButton8.BackColor = System.Drawing.Color.White;
            this.stButton8.BackgroundColor = System.Drawing.Color.White;
            this.stButton8.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.stButton8.BorderRadius = 21;
            this.stButton8.BorderSize = 0;
            this.stButton8.FlatAppearance.BorderSize = 0;
            this.stButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stButton8.ForeColor = System.Drawing.Color.White;
            this.stButton8.Location = new System.Drawing.Point(176, 29);
            this.stButton8.Name = "stButton8";
            this.stButton8.Size = new System.Drawing.Size(25, 23);
            this.stButton8.TabIndex = 29;
            this.stButton8.TextColor = System.Drawing.Color.White;
            this.stButton8.UseVisualStyleBackColor = false;
            // 
            // stButton5
            // 
            this.stButton5.BackColor = System.Drawing.Color.White;
            this.stButton5.BackgroundColor = System.Drawing.Color.White;
            this.stButton5.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.stButton5.BorderRadius = 40;
            this.stButton5.BorderSize = 0;
            this.stButton5.FlatAppearance.BorderSize = 0;
            this.stButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stButton5.ForeColor = System.Drawing.Color.White;
            this.stButton5.Location = new System.Drawing.Point(165, 48);
            this.stButton5.Name = "stButton5";
            this.stButton5.Size = new System.Drawing.Size(46, 40);
            this.stButton5.TabIndex = 26;
            this.stButton5.TextColor = System.Drawing.Color.White;
            this.stButton5.UseVisualStyleBackColor = false;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnOk.BackgroundColor = System.Drawing.Color.DarkTurquoise;
            this.btnOk.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnOk.BorderRadius = 20;
            this.btnOk.BorderSize = 0;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(152, 369);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(73, 37);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.TextColor = System.Drawing.Color.White;
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(376, 542);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbMDP);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtbEmail);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOk);
            this.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private STButton btnOk;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtbEmail;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtbMDP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private STButton stButton5;
        private STButton stButton8;
        private STButton stButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

