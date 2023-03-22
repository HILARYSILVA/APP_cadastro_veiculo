using APP_cadastro_veiculo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_cadastro_veiculo
{
    public partial class FrmCadastro : Form
    {
        Marca m;
        Fabricante f;
        Combustivel c;
        Tipo t;

        public FrmCadastro()
        {
            InitializeComponent();


        }

        private void FrmCadastro_Load(object sender, EventArgs e)
        {

        }

        void LimpaControles()
        {

            textBox1.Clear();

        }

        void carregarGrid(string v)
        {
        
        }

    
        

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == String.Empty) return;

            m = new Marca()
            {
                Nome = textBox1.Text,

            };

            m.Incluir();

            LimpaControles();
            carregarGrid("");


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            LimpaControles();
            carregarGrid("");
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string a;
            if (dataGridView1.SelectedRows.Count == 0) return;

            a = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            if (a == "") return;

            if (MessageBox.Show("Deseja alterar o cadastro?", "alterar", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                m = new Marca()
                {
                    Id = int.Parse(a),
                    Nome = textBox1.Text
                };

                m.Alterar();

                LimpaControles();
                carregarGrid("");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string a;
            if (dataGridView1.Rows.Count == 1) return;

            a = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            if (a == "") return;

            if (MessageBox.Show("Deseja excluir o cadastro?", "Exclusão", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                m = new Marca()
                {
                    Id = int.Parse(a)
                };

                m.Excluir();

                LimpaControles();
                carregarGrid("");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (textBox3.Text == String.Empty) return;

            f = new Fabricante()
            {
                Nome = textBox3.Text,

            };

            f.Incluir();

            LimpaControles();
            carregarGrid("");
        }

        private void button5_Click(object sender, EventArgs e)
        {

            LimpaControles();
            carregarGrid("");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string a;
            if (dataGridView3.SelectedRows.Count == 0) return;

            a = dataGridView3.CurrentRow.Cells[0].Value.ToString();

            if (a == "") return;

            if (MessageBox.Show("Deseja alterar o cadastro?", "alterar", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                f = new Fabricante()
                {
                    Id = int.Parse(a),
                    Nome = textBox3.Text
                };

                f.Alterar();

                LimpaControles();
                carregarGrid("");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a;
            if (dataGridView3.Rows.Count == 1) return;

            a = dataGridView3.CurrentRow.Cells[0].Value.ToString();

            if (a == "") return;

            if (MessageBox.Show("Deseja excluir o cadastro?", "Exclusão", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                f = new Fabricante()
                {
                    Id = int.Parse(a)
                };

                f.Excluir();

                LimpaControles();
                carregarGrid("");
            }
        }



        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == String.Empty) return;

            c = new Combustivel()
            {
                Nome = textBox2.Text,
            };

            c.Incluir();

            //LimpaControles();
            carregarGrid("");

        }

        private void button3_Click(object sender, EventArgs e)
        {

            LimpaControles();
            carregarGrid("");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string a;
            if (dataGridView2.SelectedRows.Count == 0) return;

            a = dataGridView2.CurrentRow.Cells[0].Value.ToString();

            if (a == "") return;

            if (MessageBox.Show("Deseja alterar o cadastro?", "alterar", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                c = new Combustivel()
                {
                    Id = int.Parse(a),
                    Nome = textBox2.Text
                };

                c.Alterar();

                LimpaControles();
                carregarGrid("");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a;
            if (dataGridView2.Rows.Count == 1) return;

            a = dataGridView2.CurrentRow.Cells[0].Value.ToString();

            if (a == "") return;

            if (MessageBox.Show("Deseja excluir o cadastro?", "Exclusão", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                c = new Combustivel()
                {
                    Id = int.Parse(a)
                };

                c.Excluir();

                LimpaControles();
                carregarGrid("");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == String.Empty) return;

            t = new Tipo()
            {
                Nome = textBox4.Text,

            };

            t.Incluir();

            LimpaControles();
            carregarGrid("");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            LimpaControles();
            carregarGrid("");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string a;
            if (dataGridView4.SelectedRows.Count == 0) return;

            a = dataGridView4.CurrentRow.Cells[0].Value.ToString();

            if (a == "") return;

            if (MessageBox.Show("Deseja alterar o cadastro?", "alterar", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                t = new Tipo()
                {
                    Id = int.Parse(a),
                    Nome = textBox4.Text
                };

                t.Alterar();

                LimpaControles();
                carregarGrid("");
            }
        }
    }
}
