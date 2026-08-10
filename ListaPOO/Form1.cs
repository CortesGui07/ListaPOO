using ListaPOO.Models;

namespace ListaPOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void btEditar_Click(object sender, EventArgs e)
        {
            FrmEditor frm = new FrmEditor();
            frm.ShowDialog();

            int id = GetId();
            Contato? cont = SelecionarContato(id);
            if (cont == null) 
            {
                MessageBox.Show("Contato não encontrado!");
                return;
            }
        }

        private void dgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btEditar.Enabled = btRemover.Enabled = true;
        }
    }
}
