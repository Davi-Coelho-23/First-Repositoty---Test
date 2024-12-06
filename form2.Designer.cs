namespace Sistema_de_livros
{
    partial class form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empréstimoDeLivrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.associadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livrosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.empréstimoDeLivrosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.associadosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.exibirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.livrosToolStripMenuItem,
            this.empréstimoDeLivrosToolStripMenuItem,
            this.associadosToolStripMenuItem});
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.novoToolStripMenuItem.Text = "Novo";
            // 
            // livrosToolStripMenuItem
            // 
            this.livrosToolStripMenuItem.Name = "livrosToolStripMenuItem";
            this.livrosToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.livrosToolStripMenuItem.Text = "Livro";
            this.livrosToolStripMenuItem.Click += new System.EventHandler(this.livrosToolStripMenuItem_Click);
            // 
            // empréstimoDeLivrosToolStripMenuItem
            // 
            this.empréstimoDeLivrosToolStripMenuItem.Name = "empréstimoDeLivrosToolStripMenuItem";
            this.empréstimoDeLivrosToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.empréstimoDeLivrosToolStripMenuItem.Text = "Empréstimo de Livros";
            // 
            // associadosToolStripMenuItem
            // 
            this.associadosToolStripMenuItem.Name = "associadosToolStripMenuItem";
            this.associadosToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.associadosToolStripMenuItem.Text = "Associado";
            // 
            // exibirToolStripMenuItem
            // 
            this.exibirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.livrosToolStripMenuItem1,
            this.empréstimoDeLivrosToolStripMenuItem1,
            this.associadosToolStripMenuItem1});
            this.exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            this.exibirToolStripMenuItem.Size = new System.Drawing.Size(60, 26);
            this.exibirToolStripMenuItem.Text = "Exibir";
            // 
            // livrosToolStripMenuItem1
            // 
            this.livrosToolStripMenuItem1.Name = "livrosToolStripMenuItem1";
            this.livrosToolStripMenuItem1.Size = new System.Drawing.Size(235, 26);
            this.livrosToolStripMenuItem1.Text = "Livros";
            // 
            // empréstimoDeLivrosToolStripMenuItem1
            // 
            this.empréstimoDeLivrosToolStripMenuItem1.Name = "empréstimoDeLivrosToolStripMenuItem1";
            this.empréstimoDeLivrosToolStripMenuItem1.Size = new System.Drawing.Size(235, 26);
            this.empréstimoDeLivrosToolStripMenuItem1.Text = "Empréstimo de Livros";
            // 
            // associadosToolStripMenuItem1
            // 
            this.associadosToolStripMenuItem1.Name = "associadosToolStripMenuItem1";
            this.associadosToolStripMenuItem1.Size = new System.Drawing.Size(235, 26);
            this.associadosToolStripMenuItem1.Text = "Associados";
            // 
            // form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "form2";
            this.Text = "form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem livrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empréstimoDeLivrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem associadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem livrosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem empréstimoDeLivrosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem associadosToolStripMenuItem1;
    }
}