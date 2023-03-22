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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void ExportarDados(DataGridView dgv_Carros)
        {
            // Microsoft.Office.Interop.Excel.Application exportarexcel = new Microsoft.Office.Interop.Excel.Application();

            //exportarexcel.Application.Workbooks.Add(true);

            //int indicecolumn = 0;

            //foreach (DataGridViewColumn column in dgv_Carros.Columns)
            //{
            //    indicecolumn++;

            //    exportarexcel.Cells[1, indicecolumn] = column.Name;
            //}

            //int indicefila = 0;

            //foreach (DataGridViewRow fila in dgv_Carros.Rows)
            //{
            //    indicefila++;

            //    indicecolumn = 0;

            //    foreach (DataGridViewColumn column in dgv_Carros.Columns)
            //    {
            //        indicecolumn++;
            //        exportarexcel.Cells[indicefila + 1, indicecolumn] = fila.Cells[column.Name].Value;
            //    }
            //}

            //exportarexcel.Visible = true;
        }

       

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportarDados(dataGridView1);
        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(txtCodigo.Text,
            txtMarca.Text,
            txtModelo.Text,
            txtfabri.Text,
            txtTipo.Text,
            txtAno.Text,
            txtCombustivel.Text,
            txtCor.Text,
            txtNumero.Text,
            txtQuilometragem.Text,
            txt_Obs.Text,
            chk_Revisao.Checked,
            chk_Sinistro.Checked,
            chk_Roubo.Checked,
            chk_Aluguel.Checked,
            chk_Venda.Checked,
            chk_Particular.Checked);



            int codigo = int.Parse(txtCodigo.Text);
            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;
            string fabricante = txtfabri.Text;
            string tipo = txtTipo.Text;
            int ano = int.Parse(txtAno.Text);
            string combustivel = txtCombustivel.Text;
            string cor = txtCor.Text;
            string numero_chassi = txtNumero.Text;
            int kilometragem = int.Parse(txtQuilometragem.Text);
            string observacoes = txt_Obs.Text;

            txtAno.Clear();
            txtNumero.Clear();
            txtCodigo.Clear();
            txtCombustivel.Clear();
            txtCor.Clear();
            txtfabri.Clear();
            txtQuilometragem.Clear();
            txtModelo.Clear();
            txt_Obs.Clear();
            txtTipo.Clear();
            txtMarca.Clear();



            chk_Aluguel.Checked = true;
            chk_Particular.Checked = true;
            chk_Revisao.Checked = true;
            chk_Sinistro.Checked = true;
            chk_Venda.Checked = true;
            chk_Roubo.Checked = true;
        }
    }

}

