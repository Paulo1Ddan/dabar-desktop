using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cetdabar
{
    public partial class frmCursos : Form
    {
        public frmCursos()
        {
            InitializeComponent();
        }

        private void frmCursos_Load(object sender, EventArgs e)
        {
            pnlCursos.Location = new Point(this.Width / 2 - pnlCursos.Width / 2, this.Height / 2 - pnlCursos.Height / 2);
            ListAll();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            new frmMenu().Show();
            Close();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            Variables.function = "CADASTRAR";
            new frmRegCursos().Show();
            Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Variables.function = "EDITAR";
            new frmRegCursos().Show();
            Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja mesmo excluir esse registro?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes && Variables.selectedRow >= 0)
            {
                Delete();
            }
        }
        //DB Methods
        //LoadData
        private void ListAll()
        {
            try
            {
                Database.StartConn();
                string query = "SELECT * FROM cursocompleto";
                MySqlCommand cmd = new MySqlCommand(query, Database.conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvCursos.DataSource = dt;

                dgvCursos.ClearSelection();
                Database.CloseConn();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Delete()
        {
            try
            {
                Database.StartConn();
                string query = "UPDATE curso SET deletedCurso = 1 WHERE idCurso = @id";
                MySqlCommand cmd = new MySqlCommand(query, Database.conn);
                MessageBox.Show(Variables.idCurso.ToString());
                cmd.Parameters.AddWithValue("@id", Variables.idCurso);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                MessageBox.Show("Curso excluido com sucesso");

                dgvCursos.DataSource = dt;
                dgvCursos.ClearSelection();

                Database.CloseConn();
                ListAll();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar turma \n\n Descrição - " + ex.Message);
            }
        }

        private void dgvCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Variables.selectedRow = int.Parse(e.RowIndex.ToString());
            if (Variables.selectedRow >= 0)
            {
                Variables.idCurso = Convert.ToInt32(dgvCursos[0, Variables.selectedRow].Value);
            }
        }

        private void dgvCursos_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvCursos.Sort(dgvCursos.Columns[0], ListSortDirection.Ascending);
            dgvCursos.ClearSelection();
        }
    }
}
