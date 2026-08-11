using ListaPOO.Data;
using ListaPOO.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ListaPOO
{
    public partial class FrmEditor : Form
    {
        Contexto db;
        Contato contato;
        string bN, bT, bE;
        public FrmEditor(Contexto db, Contato contato)
        {
            InitializeComponent();
            this.db = db;
            this.contato = contato;

            lblID.Text = $"ID: {contato.Id}";
            txtNome2.Text = contato.Nome;
            maskedtxtTel2.Text = contato.Telefone;
            txtEmail2.Text = contato.Email;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            contato.Nome = txtNome2.Text;
            contato.Telefone = maskedtxtTel2.Text;
            contato.Email = txtEmail2.Text;
            if(contato.Nome == null ||
                contato.Telefone == null ||
                contato.Email == null)
            {
                MessageBox.Show("Valores Inválidos!");
                return;
            }

            db.Contatos.Update(contato);
            int linha = db.SaveChanges();
            if(linha == 1)
            {
                MessageBox.Show("Alteração feita com sucesso");
                Close();
            }
            else
            {
                MessageBox.Show("Falha na alteração");
            }
        }
    }
}
