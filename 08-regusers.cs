using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cetdabar
{
    public partial class frmRegUsers : Form
    {
        public frmRegUsers()
        {
            InitializeComponent();
        }

        private void frmRegUsers_Load(object sender, EventArgs e)
        {
            pnlUsers.Location = new Point(this.Width/2 - pnlUsers.Width/2, this.Height/2 - pnlUsers.Height/2);
            txtName.Focus();
            if(Variables.function != "EDITAR")
            {
                mskDataCad.Text = DateTime.Now.ToString("dd/MM/yyyy");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            new frmUsers().Show();
            Close();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            lblName.ForeColor = Color.Black;
            lblEmail.ForeColor = Color.Black;
            lblPass.ForeColor = Color.Black;
            lblTel.ForeColor = Color.Black;
            lblCat.ForeColor = Color.Black;
            lblDataBorn.ForeColor = Color.Black;
            lblStatus.ForeColor = Color.Black;

            if (txtName.Text.Length == 0)
            {
                lblName.ForeColor = Color.Red;
                MessageBox.Show("Preencha o campo Nome");
                txtName.Focus();
            } else if (txtEmail.Text.Length == 0)
            {
                lblEmail.ForeColor = Color.Red;
                MessageBox.Show("Preencha o campo Email");
                txtEmail.Focus();
            } else if (txtPass.Text.Length == 0)
            {
                lblPass.ForeColor= Color.Red;
                MessageBox.Show("Preencha o campo Senha");
                txtPass.Focus();
            } else if (!mskTel.MaskCompleted)
            {
                lblTel.ForeColor = Color.Red;
                MessageBox.Show("Campo Telefone incompleto");
                mskTel.Focus();
            } else if (cmbCat.SelectedIndex == -1)
            {
                lblCat.ForeColor = Color.Red;
                MessageBox.Show("Selecione uma categoria de usuário válido");
                cmbCat.Focus();
            } else if (cmbStatus.SelectedIndex == -1)
            {
                lblStatus.ForeColor = Color.Red;
                MessageBox.Show("Selecione um status válido");
                cmbStatus.Focus();
            } else if (!mskDateNasc.MaskCompleted)
            {
                lblDataBorn.ForeColor = Color.Red;
                MessageBox.Show("Campo Data de Nascimento incompleto");
                mskDateNasc.Focus();
            }
            else
            {
                Variables.nameUser = txtName.Text;
                Variables.emailUser = txtEmail.Text;
                Variables.passUser = txtPass.Text;
                Variables.telUser = mskTel.Text;
                Variables.dataNascUser = DateTime.Parse(mskDateNasc.Text);
                Variables.dataCadUser = DateTime.Parse(mskDataCad.Text);
                if(Variables.function != "Editar")
                {
                    Insert();
                }
                else
                {

                }
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if(lblName.ForeColor == Color.Red && txtName.Text.Length > 0)
            {
                lblName.ForeColor = Color.Black;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (lblEmail.ForeColor == Color.Red && txtEmail.Text.Length > 0)
            {
                lblEmail.ForeColor = Color.Black;
            }
        }

        private bool ValidateFTP()
        {
            if(string.IsNullOrEmpty(Variables.addrFTP) || string.IsNullOrEmpty(Variables.userFTP) || string.IsNullOrEmpty(Variables.passFTP))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblName.ForeColor = Color.Black;
            lblEmail.ForeColor = Color.Black;
            lblPass.ForeColor = Color.Black;
            lblTel.ForeColor = Color.Black;
            lblCat.ForeColor = Color.Black;
            lblStatus.ForeColor = Color.Black;
        }

        //Img
        public byte[] GetImgToByte(string filePathFTP)
        {
            WebClient ftpClient = new WebClient();
            ftpClient.Credentials = new NetworkCredential(Variables.userFTP, Variables.passFTP);
            byte[] imgToByte = ftpClient.DownloadData(filePathFTP);
            return imgToByte;
        }

        public static Bitmap BytesToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bmp = new Bitmap(mStream, false);
            return bmp;
        }

        private void btnAddImg_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofdImg = new OpenFileDialog();
                ofdImg.Multiselect = false;
                ofdImg.FileName = "";
                ofdImg.InitialDirectory = @"C:";
                ofdImg.Title = "Selecione um arquivo";
                ofdImg.Filter = "JPG ou PNG (*.png, *.jpg)|*.png;*.jpg";
                ofdImg.CheckFileExists = true;
                ofdImg.CheckPathExists = true;
                ofdImg.RestoreDirectory = false;

                DialogResult result = ofdImg.ShowDialog();
                picImg.Image = Image.FromFile(ofdImg.FileName);
                Variables.imgUser = DateTime.Now.ToString("yyyy-MM-dd-HH:mm:ss")+".jpg";

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        Variables.imgUpdateUser = "S";
                        Variables.pathImgUser = ofdImg.FileName;
                    }catch(SecurityException ex)
                    {
                        MessageBox.Show("Erro de segurança \n\n Descrição" + ex.Message);
                    }catch(Exception ex)
                    {
                        MessageBox.Show("Erro ao selecionar imagem \n\n Descrição" + ex.Message);
                    }
                }

            }catch(Exception ex)
            {
                MessageBox.Show("Erro ao carregar imagem \n\n Descrição - " + ex.Message);
                btnReg.Focus();
            }
        }

        private void picImg_Click(object sender, EventArgs e)
        {

        }

        private void cmbCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbCat.Text)
            {
                case "Aluno":
                    Variables.catUser = 0;
                    break;
                case "Professor":
                    Variables.catUser = 1;
                    break;
                case "Administrador":
                    Variables.catUser = 2;
                    break;
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbStatus.Text == "Ativo")
            {
                Variables.statusUser = 1;
            }
            else
            {
                Variables.statusUser = 0;
            }
        }




        //DB Methods
        private void Insert()
        {
            try
            {
                Database.StartConn();
                string query = "INSERT INTO usuario (nomeUsuario, emailUsuario, telUsuario, senhaUsuario, dataNasc, imgUsuario, dataCad, statusUsuario, catUsuario, deletedUser) VALUES(@name, @email, @tel, @pass, @datanasc, @img, @datacad, @status, @cat, @del)";
                MySqlCommand cmd = new MySqlCommand(query, Database.conn);
                cmd.Parameters.AddWithValue("@name", Variables.nameUser);
                cmd.Parameters.AddWithValue("@email", Variables.emailUser);
                cmd.Parameters.AddWithValue("@tel", Variables.telUser);
                cmd.Parameters.AddWithValue("@pass", Variables.passUser);
                cmd.Parameters.AddWithValue("@datanasc", Variables.dataNascUser.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@img", Variables.imgUser);
                cmd.Parameters.AddWithValue("@datacad", Variables.dataCadUser.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@status", Variables.statusUser);
                cmd.Parameters.AddWithValue("@cat", Variables.catUser);
                cmd.Parameters.AddWithValue("@del", 0);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Turma cadastrada com sucesso");

                if (ValidateFTP())
                {
                    if (!string.IsNullOrEmpty(Variables.imgUser))
                    {
                        string urlEnviarArquivo = Variables.addrFTP + "assets/usuario/" + Path.GetFileName(Variables.imgUser);
                        MessageBox.Show(Variables.pathImgUser);
                        MessageBox.Show(urlEnviarArquivo);
                        
                        try
                        {
                            
                            FTP.SendFile(Variables.pathImgUser, urlEnviarArquivo, Variables.userFTP, Variables.passFTP);

                        }catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                Database.CloseConn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir dados! \n\n Descrição: " + ex.Message);
            }


        }
    }
}
