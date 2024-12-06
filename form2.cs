using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_livros
{
    public partial class form2 : Form
    {
        frmCadastroDeLivros frmCadastroLivrosObj;
        public form2()
        {
            InitializeComponent();
        }

        private void livrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmCadastroLivrosObj == null || frmCadastroLivrosObj.IsDisposed)
            {
                frmCadastroLivrosObj = new frmCadastroDeLivros();
                frmCadastroLivrosObj.MdiParent = this;
                frmCadastroLivrosObj.Show();
            }
            else
            {
                frmCadastroLivrosObj.Activate();
            }
        }
    }
}
