namespace Jogo_das_damas
{
    partial class ViewRegisto
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
            this.b_resgistar = new System.Windows.Forms.Button();
            this.b_cancelar = new System.Windows.Forms.Button();
            this.tB_username = new System.Windows.Forms.TextBox();
            this.tB_password = new System.Windows.Forms.TextBox();
            this.tB_cidade = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_cidade = new System.Windows.Forms.Label();
            this.tB_pais = new System.Windows.Forms.TextBox();
            this.lbl_pais = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b_resgistar
            // 
            this.b_resgistar.Location = new System.Drawing.Point(30, 224);
            this.b_resgistar.Name = "b_resgistar";
            this.b_resgistar.Size = new System.Drawing.Size(75, 23);
            this.b_resgistar.TabIndex = 0;
            this.b_resgistar.Text = "Registar";
            this.b_resgistar.UseVisualStyleBackColor = true;
            this.b_resgistar.Click += new System.EventHandler(this.b_resgistar_Click);
            // 
            // b_cancelar
            // 
            this.b_cancelar.Location = new System.Drawing.Point(172, 224);
            this.b_cancelar.Name = "b_cancelar";
            this.b_cancelar.Size = new System.Drawing.Size(75, 23);
            this.b_cancelar.TabIndex = 1;
            this.b_cancelar.Text = "Cancelar";
            this.b_cancelar.UseVisualStyleBackColor = true;
            this.b_cancelar.Click += new System.EventHandler(this.b_cancelar_Click);
            // 
            // tB_username
            // 
            this.tB_username.Location = new System.Drawing.Point(53, 32);
            this.tB_username.Name = "tB_username";
            this.tB_username.Size = new System.Drawing.Size(171, 20);
            this.tB_username.TabIndex = 2;
            // 
            // tB_password
            // 
            this.tB_password.Location = new System.Drawing.Point(53, 84);
            this.tB_password.Name = "tB_password";
            this.tB_password.Size = new System.Drawing.Size(171, 20);
            this.tB_password.TabIndex = 3;
            // 
            // tB_cidade
            // 
            this.tB_cidade.Location = new System.Drawing.Point(53, 132);
            this.tB_cidade.Name = "tB_cidade";
            this.tB_cidade.Size = new System.Drawing.Size(171, 20);
            this.tB_cidade.TabIndex = 4;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(50, 16);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(55, 13);
            this.lbl_username.TabIndex = 5;
            this.lbl_username.Text = "Username";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(50, 68);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(53, 13);
            this.lbl_password.TabIndex = 6;
            this.lbl_password.Text = "Password";
            // 
            // lbl_cidade
            // 
            this.lbl_cidade.AutoSize = true;
            this.lbl_cidade.Location = new System.Drawing.Point(50, 116);
            this.lbl_cidade.Name = "lbl_cidade";
            this.lbl_cidade.Size = new System.Drawing.Size(40, 13);
            this.lbl_cidade.TabIndex = 7;
            this.lbl_cidade.Text = "Cidade";
            // 
            // tB_pais
            // 
            this.tB_pais.Location = new System.Drawing.Point(53, 185);
            this.tB_pais.Name = "tB_pais";
            this.tB_pais.Size = new System.Drawing.Size(171, 20);
            this.tB_pais.TabIndex = 8;
            // 
            // lbl_pais
            // 
            this.lbl_pais.AutoSize = true;
            this.lbl_pais.Location = new System.Drawing.Point(50, 169);
            this.lbl_pais.Name = "lbl_pais";
            this.lbl_pais.Size = new System.Drawing.Size(27, 13);
            this.lbl_pais.TabIndex = 9;
            this.lbl_pais.Text = "Pais";
            // 
            // ViewRegisto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 275);
            this.Controls.Add(this.lbl_pais);
            this.Controls.Add(this.tB_pais);
            this.Controls.Add(this.lbl_cidade);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.tB_cidade);
            this.Controls.Add(this.tB_password);
            this.Controls.Add(this.tB_username);
            this.Controls.Add(this.b_cancelar);
            this.Controls.Add(this.b_resgistar);
            this.Name = "ViewRegisto";
            this.Text = "Resgisto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_resgistar;
        private System.Windows.Forms.Button b_cancelar;
        private System.Windows.Forms.TextBox tB_username;
        private System.Windows.Forms.TextBox tB_password;
        private System.Windows.Forms.TextBox tB_cidade;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_cidade;
        private System.Windows.Forms.TextBox tB_pais;
        private System.Windows.Forms.Label lbl_pais;
    }
}