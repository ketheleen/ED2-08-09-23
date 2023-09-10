using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ED2_08_09_23
{
    public partial class Form1 : Form
    {
        Contatos controller = new Contatos();
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String email = emailTextfield.Text;
         
            Contato contato = controller.pesquisar(email);
            contatosGridView.Rows.Clear();
            contatosGridView.Rows.Add(
            contato.Email,
            contato.Nome,
            contato.DtNasc.ToString(),
            contato.getIdate(),
            contato.getTelefonePrincipal());
            telefoneGrid.Rows.Clear();
            foreach (Telefone telefone in contato.Telefones) {
                telefoneGrid.Rows.Add(telefone.Tipo,
                telefone.numero,
                telefone.principal);
                    };
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            contatosGridView.Rows.Clear();
            foreach (Contato contato in controller.Agenda)
            {
                contatosGridView.Rows.Add(
                    contato.Email,
                    contato.Nome,
                    contato.DtNasc.ToString(),
                    contato.getIdate(),
                    contato.getTelefonePrincipal());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nomeTextfield.Clear();
            emailTextfield.Clear();
            DiaTextfield.Clear();
            MesTextfield.Clear();
            anoTextfield.Clear();  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String nome=nomeTextfield.Text;
            String email=emailTextfield.Text;
            int dia = int.Parse(DiaTextfield.Text);
            int mes = int.Parse(MesTextfield.Text);
            int ano = int.Parse(anoTextfield.Text);

            Data data = new Data(dia, mes, ano);
            Contato contato = new Contato(email,nome,data);

            controller.adicionar(contato);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String email = emailTextfield.Text; 
            controller.remover(email);
            contatosGridView.Rows.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            String tipo = tipoTextfield.Text;
            String num = numTexfield.Text;
            bool isPrincipal = principalCheckbox.Checked;
            String email = emailTextfield.Text;
            Contato contato = controller.pesquisar(email);
            contato.adicionarTelefone(new Telefone(tipo,num,isPrincipal));
        }

        private void numTexfield_TextChanged(object sender, EventArgs e)
        {
            //int num = int.Parse(numTexfield.Text);
        }

        private void emailTextfield_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
