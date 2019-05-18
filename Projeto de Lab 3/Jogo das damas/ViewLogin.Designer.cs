namespace Jogo_das_damas
{
    partial class ViewLogin
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
            this.tB_Username = new System.Windows.Forms.TextBox();
            this.tB_pass = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.b_login = new System.Windows.Forms.Button();
            this.b_registo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tB_Username
            // 
            this.tB_Username.Location = new System.Drawing.Point(40, 36);
            this.tB_Username.Name = "tB_Username";
            this.tB_Username.Size = new System.Drawing.Size(197, 22);
            this.tB_Username.TabIndex = 0;
            // 
            // tB_pass
            // 
            this.tB_pass.Location = new System.Drawing.Point(40, 75);
            this.tB_pass.Name = "tB_pass";
            this.tB_pass.Size = new System.Drawing.Size(197, 22);
            this.tB_pass.TabIndex = 1;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(56, 20);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(73, 17);
            this.lbl_username.TabIndex = 2;
            this.lbl_username.Text = "Username";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Location = new System.Drawing.Point(58, 59);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(69, 17);
            this.lbl_pass.TabIndex = 3;
            this.lbl_pass.Text = "Password";
            // 
            // b_login
            // 
            this.b_login.Location = new System.Drawing.Point(40, 115);
            this.b_login.Name = "b_login";
            this.b_login.Size = new System.Drawing.Size(75, 23);
            this.b_login.TabIndex = 4;
            this.b_login.Text = "Login";
            this.b_login.UseVisualStyleBackColor = true;
            this.b_login.Click += new System.EventHandler(this.b_login_Click);
            // 
            // b_registo
            // 
            this.b_registo.Location = new System.Drawing.Point(162, 115);
            this.b_registo.Name = "b_registo";
            this.b_registo.Size = new System.Drawing.Size(75, 23);
            this.b_registo.TabIndex = 6;
            this.b_registo.Text = "Registar";
            this.b_registo.UseVisualStyleBackColor = true;
            this.b_registo.Click += new System.EventHandler(this.b_registo_Click);
            // 
            // ViewLogin
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(284, 163);
            this.Controls.Add(this.b_registo);
            this.Controls.Add(this.b_login);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.tB_pass);
            this.Controls.Add(this.tB_Username);
            this.Name = "ViewLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tB_Username;
        private System.Windows.Forms.TextBox tB_pass;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Button b_login;
        private System.Windows.Forms.Button b_registo;
    }
}