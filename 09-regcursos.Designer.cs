namespace cetdabar
{
    partial class frmRegCursos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlCursos = new System.Windows.Forms.Panel();
            this.picImg = new System.Windows.Forms.PictureBox();
            this.lblImg = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblInstrutor = new System.Windows.Forms.Label();
            this.txtInstrutor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDuracao = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnClear = new cetdabar.CustomButton();
            this.btnReg = new cetdabar.CustomButton();
            this.lblCod = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCurso = new System.Windows.Forms.Label();
            this.btnAddImg = new System.Windows.Forms.Button();
            this.pnlCursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCursos
            // 
            this.pnlCursos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(221)))));
            this.pnlCursos.Controls.Add(this.btnAddImg);
            this.pnlCursos.Controls.Add(this.picImg);
            this.pnlCursos.Controls.Add(this.lblImg);
            this.pnlCursos.Controls.Add(this.lblDesc);
            this.pnlCursos.Controls.Add(this.txtDesc);
            this.pnlCursos.Controls.Add(this.lblMsg);
            this.pnlCursos.Controls.Add(this.txtMsg);
            this.pnlCursos.Controls.Add(this.lblStatus);
            this.pnlCursos.Controls.Add(this.cmbStatus);
            this.pnlCursos.Controls.Add(this.lblInstrutor);
            this.pnlCursos.Controls.Add(this.txtInstrutor);
            this.pnlCursos.Controls.Add(this.label1);
            this.pnlCursos.Controls.Add(this.txtDuracao);
            this.pnlCursos.Controls.Add(this.lblName);
            this.pnlCursos.Controls.Add(this.txtName);
            this.pnlCursos.Controls.Add(this.btnClear);
            this.pnlCursos.Controls.Add(this.btnReg);
            this.pnlCursos.Controls.Add(this.lblCod);
            this.pnlCursos.Controls.Add(this.txtCod);
            this.pnlCursos.Controls.Add(this.btnClose);
            this.pnlCursos.Controls.Add(this.lblCurso);
            this.pnlCursos.Location = new System.Drawing.Point(100, 22);
            this.pnlCursos.Name = "pnlCursos";
            this.pnlCursos.Size = new System.Drawing.Size(1100, 650);
            this.pnlCursos.TabIndex = 4;
            // 
            // picImg
            // 
            this.picImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picImg.Image = global::cetdabar.Properties.Resources.no_image;
            this.picImg.Location = new System.Drawing.Point(389, 416);
            this.picImg.Name = "picImg";
            this.picImg.Size = new System.Drawing.Size(257, 162);
            this.picImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImg.TabIndex = 44;
            this.picImg.TabStop = false;
            // 
            // lblImg
            // 
            this.lblImg.AutoSize = true;
            this.lblImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImg.Location = new System.Drawing.Point(435, 393);
            this.lblImg.Name = "lblImg";
            this.lblImg.Size = new System.Drawing.Size(150, 20);
            this.lblImg.TabIndex = 43;
            this.lblImg.Text = "Imagem do Curso";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(25, 264);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(166, 20);
            this.lblDesc.TabIndex = 0;
            this.lblDesc.Text = "Descrição do Curso";
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(22, 287);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(1044, 103);
            this.txtDesc.TabIndex = 6;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.Location = new System.Drawing.Point(25, 212);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(194, 20);
            this.lblMsg.TabIndex = 42;
            this.lblMsg.Text = "Mensagem (Whatsapp)";
            // 
            // txtMsg
            // 
            this.txtMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMsg.Location = new System.Drawing.Point(22, 235);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(1044, 26);
            this.txtMsg.TabIndex = 5;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(820, 158);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(62, 20);
            this.lblStatus.TabIndex = 40;
            this.lblStatus.Text = "Status";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cmbStatus.Location = new System.Drawing.Point(817, 181);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(249, 28);
            this.cmbStatus.TabIndex = 4;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // lblInstrutor
            // 
            this.lblInstrutor.AutoSize = true;
            this.lblInstrutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstrutor.Location = new System.Drawing.Point(284, 160);
            this.lblInstrutor.Name = "lblInstrutor";
            this.lblInstrutor.Size = new System.Drawing.Size(78, 20);
            this.lblInstrutor.TabIndex = 32;
            this.lblInstrutor.Text = "Instrutor";
            // 
            // txtInstrutor
            // 
            this.txtInstrutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstrutor.Location = new System.Drawing.Point(281, 183);
            this.txtInstrutor.Name = "txtInstrutor";
            this.txtInstrutor.Size = new System.Drawing.Size(510, 26);
            this.txtInstrutor.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Duração do Curso";
            // 
            // txtDuracao
            // 
            this.txtDuracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuracao.Location = new System.Drawing.Point(22, 183);
            this.txtDuracao.Name = "txtDuracao";
            this.txtDuracao.Size = new System.Drawing.Size(233, 26);
            this.txtDuracao.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(25, 106);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(132, 20);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Nome do Curso";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(22, 129);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(1044, 26);
            this.txtName.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(20)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(526, 592);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 40);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnReg
            // 
            this.btnReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(20)))));
            this.btnReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReg.FlatAppearance.BorderSize = 0;
            this.btnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReg.ForeColor = System.Drawing.Color.White;
            this.btnReg.Location = new System.Drawing.Point(359, 592);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(150, 40);
            this.btnReg.TabIndex = 9;
            this.btnReg.Text = "Salvar";
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod.Location = new System.Drawing.Point(25, 54);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(65, 20);
            this.lblCod.TabIndex = 28;
            this.lblCod.Text = "Código";
            // 
            // txtCod
            // 
            this.txtCod.Enabled = false;
            this.txtCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.Location = new System.Drawing.Point(22, 77);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(186, 26);
            this.txtCod.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(20)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(23)))), ((int)(((byte)(68)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1060, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblCurso
            // 
            this.lblCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(20)))));
            this.lblCurso.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.ForeColor = System.Drawing.Color.White;
            this.lblCurso.Location = new System.Drawing.Point(0, 0);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(1100, 40);
            this.lblCurso.TabIndex = 11;
            this.lblCurso.Text = "Cadastrar Curso";
            this.lblCurso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddImg
            // 
            this.btnAddImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(20)))));
            this.btnAddImg.FlatAppearance.BorderSize = 0;
            this.btnAddImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddImg.ForeColor = System.Drawing.Color.White;
            this.btnAddImg.Location = new System.Drawing.Point(606, 538);
            this.btnAddImg.Name = "btnAddImg";
            this.btnAddImg.Size = new System.Drawing.Size(40, 40);
            this.btnAddImg.TabIndex = 45;
            this.btnAddImg.Text = "+";
            this.btnAddImg.UseVisualStyleBackColor = false;
            this.btnAddImg.Click += new System.EventHandler(this.btnAddImg_Click);
            // 
            // frmRegCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cetdabar.Properties.Resources.backgroundproject;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.pnlCursos);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegCursos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Curso";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRegCursos_Load);
            this.pnlCursos.ResumeLayout(false);
            this.pnlCursos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCursos;
        private System.Windows.Forms.Label lblInstrutor;
        private System.Windows.Forms.TextBox txtInstrutor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDuracao;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private CustomButton btnClear;
        private CustomButton btnReg;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.PictureBox picImg;
        private System.Windows.Forms.Label lblImg;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnAddImg;
    }
}