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
    public partial class frmClass : Form
    {
        public frmClass()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            new frmMenu().Show();
            Close();
        }

        private void frmClass_Load(object sender, EventArgs e)
        {
            pnlClass.Location = new Point(this.Width/2 - pnlClass.Width/2, this.Height/2 - pnlClass.Height/2);
            LoadData();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            new frmRegClass().Show();
            Hide();
        }

        private void dgvClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Variables.selectedRow = int.Parse(e.RowIndex.ToString());
            if(Variables.selectedRow >= 0)
            {
                Variables.idClass = Convert.ToInt32(dgvClass[0, Variables.selectedRow].Value);
            }
            MessageBox.Show(Variables.idClass.ToString());
        }

        private void dgvClass_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvClass.Sort(dgvClass.Columns[0], ListSortDirection.Ascending);
            dgvClass.ClearSelection();
        }

        //DB Methods
        private void LoadData()
        {
            try
            {
                Database.StartConn();
                string query = "SELECT * FROM turmascompleto";
                MySqlCommand cmd = new MySqlCommand(query, Database.conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvClass.DataSource = dt;
                dgvClass.Columns[0].Width = 205;
                dgvClass.Columns[1].Width = 205;
                dgvClass.Columns[2].Width = 206;
                dgvClass.Columns[3].Width = 206;

                string value;
                for(int i = 0; i < dgvClass.Rows.Count; i++)
                {
                    value = dgvClass.Rows[i].Cells[2].Value.ToString();
                    if (value == "1")
                    {
                        Convert.ToString(dgvClass.Rows[i].Cells[2].Value = "Ativa");
                    }
                    else
                    {
                        Convert.ToString(dgvClass.Rows[i].Cells[2].Value = "Inativa");
                    }
                }
                dgvClass.ClearSelection();
                Database.CloseConn();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
