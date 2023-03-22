using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_cadastro_veiculo
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            Banco.CriarBanco();
        }

        private void veiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void informaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastro form = new FrmCadastro();
            form.Show();
        }
    }
}
