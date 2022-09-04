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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            pnlLogin.Location = new Point(this.Width /2 - pnlLogin.Width /2, this.Height /2 - pnlLogin.Height /2);
            txtLogin.Text = "paulodaniel1360@gmail.com";
            txtPassword.Text = "Paulo1Ddan";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Deseja mesmo sair da aplicação?", "SAIR?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.ForeColor = Color.White;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.ForeColor = Color.Black;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                Database.StartConn();
                string query = "SELECT nomeUsuario FROM usuario WHERE emailUsuario = @email AND senhaUsuario = sha1(@senha) AND catUsuario = @cat AND statusUsuario = @status";
                MySqlCommand cmd = new MySqlCommand(query, Database.conn);
                cmd.Parameters.AddWithValue("@email", txtLogin.Text);
                cmd.Parameters.AddWithValue("@senha", txtPassword.Text);
                cmd.Parameters.AddWithValue("@cat", 1);
                cmd.Parameters.AddWithValue("@status", 1);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    User.username = reader.GetString(0);
                    new frmMenu().Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Acesso Negado!!");

                }
            }catch(Exception ex){
                MessageBox.Show("Não foi possível conectar-se ao servidor \n\n Descrição - " + ex.Message); 
            }
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
