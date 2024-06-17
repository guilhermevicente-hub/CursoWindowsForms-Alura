namespace CursoWindowsForms
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_ModificaLabel = new System.Windows.Forms.Button();
            this.txt_Conteudo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(30, 30);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(213, 19);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Visual Studio .NET Version";
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(473, 317);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(150, 23);
            this.btn_Sair.TabIndex = 1;
            this.btn_Sair.Text = "Fechar a aplicação";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // btn_ModificaLabel
            // 
            this.btn_ModificaLabel.Location = new System.Drawing.Point(34, 62);
            this.btn_ModificaLabel.Name = "btn_ModificaLabel";
            this.btn_ModificaLabel.Size = new System.Drawing.Size(209, 23);
            this.btn_ModificaLabel.TabIndex = 2;
            this.btn_ModificaLabel.Text = "Modifica Texto do Label";
            this.btn_ModificaLabel.UseVisualStyleBackColor = true;
            this.btn_ModificaLabel.Click += new System.EventHandler(this.btn_ModificaLabel_Click);
            // 
            // txt_Conteudo
            // 
            this.txt_Conteudo.Location = new System.Drawing.Point(34, 114);
            this.txt_Conteudo.Name = "txt_Conteudo";
            this.txt_Conteudo.Size = new System.Drawing.Size(340, 20);
            this.txt_Conteudo.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 352);
            this.Controls.Add(this.txt_Conteudo);
            this.Controls.Add(this.btn_ModificaLabel);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.lbl_titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_ModificaLabel;
        private System.Windows.Forms.TextBox txt_Conteudo;
    }
}

