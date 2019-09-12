using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Done
{
    public partial class Form1 : Form
    {
        Contatos contatos = new Contatos();
        
        public Form1()
        {

            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            textEmail.Text = "";
            textNome.Text = "";
            textNum.Text = "";
            listView1.Items.Clear();
            textEmail.Focus();
            
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            string _nome, _email;
            _email = textEmail.Text;
            _nome = textNome.Text;

            if (contatos.alterar(new Contato(_email)) == true)
            {
                contatos.alterar(new Contato(_email, _nome));
                MessageBox.Show("contato alterado com sucesso");
            }
            else { 
            contatos.adicionar(new Contato(_email, _nome));
            Debug.WriteLine(contatos.pesquisar(new Contato(_email)).ToString());
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            string _email;
            _email = textEmail.Text;
            listView1.Items.Clear();
            Contato a = contatos.pesquisar(new Contato(_email));
            Debug.WriteLine(contatos.pesquisar(a).Fone.Count());

            Debug.WriteLine(contatos.pesquisar(a).ToString());
            textNome.Text =  contatos.pesquisar(a).Nome;

                for (int i = 0; i < contatos.pesquisar(a).Fone.Count(); i++)
                {

                listView1.Items.Add(a.Fone[i].telefone).SubItems.Add(a.Fone[i].tipo);
                Debug.WriteLine(contatos.pesquisar(a).Fone[i].telefone);


                }
            
            

            
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            string _email;
            bool sera;
            _email = textEmail.Text;
            sera = contatos.remover(contatos.pesquisar(new Contato(_email)));

            if (sera == true)
            {
                MessageBox.Show("contato removido com sucesso!");
                Debug.WriteLine("removido com sucesso!");
            }

            else
            {
                MessageBox.Show("contato nao encontrado!");
            }

        }

        private void ListFones_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*foreach (Contato c in contatos.MeusContatos)
            {
            }*/
            
            
        }

        

        private void ListView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string _telefone, _tipo, _email;
            _telefone = textNum.Text;
            _tipo = comboTipo.Text;
            _email = textEmail.Text;
            Contato a = contatos.pesquisar(new Contato(_email));
            listView1.Items.Clear();
            
            contatos.pesquisar(a).adicionarTel(new Fones(_telefone, _tipo));
           

            for (int i=0; i<contatos.pesquisar(a).Fone.Count();i++)
            {

                listView1.Items.Add(a.Fone[i].telefone).SubItems.Add(a.Fone[i].tipo);
               
                

            }

            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboTipo.SelectedIndex = 1;

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string _email = textEmail.Text; 
            Contato a = contatos.pesquisar(new Contato(_email));

            if (listView1.SelectedItems.Count <= 0)
            {

                MessageBox.Show("Nenhum numero selecionado");
            }
            else
            {
                int i = listView1.SelectedItems[0].Index;
                contatos.pesquisar(a).removerTel(a.Fone[i]);
                listView1.SelectedItems[0].Remove();
            }
            
            
            
        }

        private void comboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }
    }
}
