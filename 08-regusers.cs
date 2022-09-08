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
            } else
            {

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
                Variables.imgUser = Path.GetFileName(ofdImg.FileName);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        Variables.imgUpdateUser = "S";
                        Variables.pathImgUser = "assets/usuario/"+ofdImg.FileName;
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
    }
}
