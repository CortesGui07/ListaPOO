using ListaPOO.Data;
using ListaPOO.Models;

namespace ListaPOO
{
    public partial class Form1 : Form
    {
        Contexto db;
        public Form1()
        {
            InitializeComponent();
            db = new Contexto();
            Recarregar();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            FrmCadastrar frm = new FrmCadastrar();
            frm.ShowDialog();
        }

        int GetId()
        {
            int linha = dgvLista.SelectedCells[0].RowIndex;
            return Convert.ToInt32(
                dgvLista.Rows[linha].Cells[0].Value);
        }

        Contato? SelecionarContato(int id)
        {
            try
            {
                Contato ctt = db.Contatos
                .Where(c => c.Id == id)
                .First();
                return ctt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        void Recarregar()
        {
            string nome = txtBusca.Text.ToUpper();
            List<Contato> lista = db.Contatos
                .Where(c => (c.Nome ?? "").ToUpper().Contains(nome))
                .ToList();
            dgvLista.DataSource = lista;
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            int id = GetId();
            Contato? cont = SelecionarContato(id);
            if (cont == null)
            {
                MessageBox.Show("Contato não encontrado!");
                return;
            }

            FrmEditor frm = new FrmEditor(db, cont);
            frm.ShowDialog();
            Recarregar();
            btEditar.Enabled = btRemover.Enabled = false;
        }

        private void dgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btEditar.Enabled = btRemover.Enabled = true;
        }

        private void btRemover_Click(object sender, EventArgs e)
        {
            int id = GetId();
            Contato? contato = SelecionarContato(id);
            if (contato == null)
            {
                MessageBox.Show("Contato não encontrado!");
                return;
            }
            DialogResult r = MessageBox.Show($"Deseja remover o contato {contato.Nome}?",
                                                "", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                db.Contatos.Remove(contato);
                int linha = db.SaveChanges();
                if (linha == 1)
                {
                    MessageBox.Show("Apagado com sucesso!");
                    Recarregar();
                }
                else
                {
                    MessageBox.Show("Falha ao excluir");
                }

                btEditar.Enabled = btRemover.Enabled = false;
            }
        }

        private void btBusca_Click(object sender, EventArgs e)
        {
            Recarregar();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var celulasSelecionadas = new List<Point>();
            foreach (DataGridViewCell celula in dgvLista.SelectedCells)
            {
                celulasSelecionadas.Add(new Point(celula.ColumnIndex, celula.RowIndex));
            }
            int pos = dgvLista.FirstDisplayedScrollingRowIndex;
            Recarregar();
            dgvLista.FirstDisplayedScrollingRowIndex = pos;
            dgvLista.ClearSelection();
            foreach (Point p in celulasSelecionadas)
                if (p.Y < dgvLista.Rows.Count && p.X < dgvLista.Columns.Count)
                {
                    dgvLista.Rows[p.Y].Cells[p.X].Selected = true;
                }
        }
    }
}
