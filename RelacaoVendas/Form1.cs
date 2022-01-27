using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RelacaoVendas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FornecedorController fornecedorController = new FornecedorController();
            var fornecedores = fornecedorController.SelecionarTodos();

            foreach(Fornecedor fornecedor in fornecedores)
            {
                listView1.Items.Add(fornecedor.Nome);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FornecedorController fornecedorController = new FornecedorController();
            string mensagem = fornecedorController.Salvar(new Fornecedor() { Ativo = true, Nome = "Luciana", Sigla = "L" });

            if (mensagem == "")
                MessageBox.Show("Inclusao feita com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
