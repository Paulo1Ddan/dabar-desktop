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
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            pnlUsers.Location = new Point(this.Width/2 - pnlUsers.Width/2, this.Height/2 - pnlUsers.Height/2);
            ListAll();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            new frmMenu().Show();
            Close();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            new frmRegUsers().Show();
            Hide();
        }

        //DB Methods
        //ListAll
        private void ListAll()
        {
            try
            {
                Database.StartConn();
                string query = "SELECT * FROM usuariocompleto";
                MySqlCommand cmd = new MySqlCommand(query, Database.conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvUsers.DataSource = dt;

                string valueCat;
                string valueStatus;
                for(int i = 0; i < dgvUsers.Rows.Count; i++)
                {
                    valueStatus = dgvUsers.Rows[i].Cells[7].Value.ToString();
                    if(valueStatus == "1")
                    {
                        dgvUsers.Rows[i].Cells[7].Value = "Ativo";
                    }
                    else
                    {
                        dgvUsers.Rows[i].Cells[7].Value = "Inativo";
                    }

                    valueCat = dgvUsers.Rows[i].Cells[8].Value.ToString();
                    switch (valueCat)
                    {
                        case "0":
                            dgvUsers.Rows[i].Cells[8].Value = "ADM";
                            break;
                        case "1":
                            dgvUsers.Rows[i].Cells[8].Value = "Aluno";
                            break;
                        case "2":
                            dgvUsers.Rows[i].Cells[8].Value = "Professor";
                            break;
                    }
                }
                dgvUsers.ClearSelection();
                Database.CloseConn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
