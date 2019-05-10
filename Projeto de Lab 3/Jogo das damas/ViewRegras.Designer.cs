namespace Jogo_das_damas
{
    partial class ViewRegras
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
            this.lbl_tituloregras = new System.Windows.Forms.Label();
            this.tB_regras = new System.Windows.Forms.TextBox();
            this.b_voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_tituloregras
            // 
            this.lbl_tituloregras.AutoSize = true;
            this.lbl_tituloregras.Location = new System.Drawing.Point(61, 33);
            this.lbl_tituloregras.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tituloregras.Name = "lbl_tituloregras";
            this.lbl_tituloregras.Size = new System.Drawing.Size(200, 17);
            this.lbl_tituloregras.TabIndex = 0;
            this.lbl_tituloregras.Text = "Regras e Protocolos a cumprir";
            // 
            // tB_regras
            // 
            this.tB_regras.Location = new System.Drawing.Point(65, 53);
            this.tB_regras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tB_regras.Multiline = true;
            this.tB_regras.Name = "tB_regras";
            this.tB_regras.Size = new System.Drawing.Size(749, 297);
            this.tB_regras.TabIndex = 1;
            // 
            // b_voltar
            // 
            this.b_voltar.Location = new System.Drawing.Point(716, 375);
            this.b_voltar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b_voltar.Name = "b_voltar";
            this.b_voltar.Size = new System.Drawing.Size(100, 28);
            this.b_voltar.TabIndex = 2;
            this.b_voltar.Text = "voltar";
            this.b_voltar.UseVisualStyleBackColor = true;
            this.b_voltar.Click += new System.EventHandler(this.b_voltar_Click);
            // 
            // ViewRegras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 432);
            this.Controls.Add(this.b_voltar);
            this.Controls.Add(this.tB_regras);
            this.Controls.Add(this.lbl_tituloregras);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ViewRegras";
            this.Text = "Regras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_tituloregras;
        private System.Windows.Forms.TextBox tB_regras;
        private System.Windows.Forms.Button b_voltar;
    }
}