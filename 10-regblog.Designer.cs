namespace cetdabar
{
    partial class frmRegblog
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
            this.lblClass = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.lblCod = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCapa = new System.Windows.Forms.Label();
            this.picCapa = new System.Windows.Forms.PictureBox();
            this.btnAddCapa = new System.Windows.Forms.Button();
            this.btnReg = new cetdabar.CustomButton();
            this.btnClear = new cetdabar.CustomButton();
            this.lblBanner = new System.Windows.Forms.Label();
            this.pivBanner = new System.Windows.Forms.PictureBox();
            this.btnAddBanner = new System.Windows.Forms.Button();
            this.txtArtigo = new System.Windows.Forms.TextBox();
            this.lblArtigo = new System.Windows.Forms.Label();
            this.pnlBlog = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picCapa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivBanner)).BeginInit();
            this.pnlBlog.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClass
            // 
            this.lblClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(20)))));
            this.lblClass.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.ForeColor = System.Drawing.Color.White;
            this.lblClass.Location = new System.Drawing.Point(0, 0);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(1100, 40);
            this.lblClass.TabIndex = 11;
            this.lblClass.Text = "Cadastrar Artigo";
            this.lblClass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(22, 137);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(1045, 26);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(25, 114);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 26;
            this.lblName.Text = "Nome";
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
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cmbStatus.Location = new System.Drawing.Point(818, 331);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(249, 28);
            this.cmbStatus.TabIndex = 5;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(821, 308);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(62, 20);
            this.lblStatus.TabIndex = 38;
            this.lblStatus.Text = "Status";
            // 
            // lblCapa
            // 
            this.lblCapa.AutoSize = true;
            this.lblCapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapa.Location = new System.Drawing.Point(25, 308);
            this.lblCapa.Name = "lblCapa";
            this.lblCapa.Size = new System.Drawing.Size(51, 20);
            this.lblCapa.TabIndex = 42;
            this.lblCapa.Text = "Capa";
            // 
            // picCapa
            // 
            this.picCapa.Image = global::cetdabar.Properties.Resources.no_image;
            this.picCapa.Location = new System.Drawing.Point(22, 331);
            this.picCapa.Name = "picCapa";
            this.picCapa.Size = new System.Drawing.Size(252, 190);
            this.picCapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCapa.TabIndex = 43;
            this.picCapa.TabStop = false;
            // 
            // btnAddCapa
            // 
            this.btnAddCapa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(20)))));
            this.btnAddCapa.FlatAppearance.BorderSize = 0;
            this.btnAddCapa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCapa.ForeColor = System.Drawing.Color.White;
            this.btnAddCapa.Location = new System.Drawing.Point(234, 481);
            this.btnAddCapa.Name = "btnAddCapa";
            this.btnAddCapa.Size = new System.Drawing.Size(40, 40);
            this.btnAddCapa.TabIndex = 3;
            this.btnAddCapa.Text = "+";
            this.btnAddCapa.UseVisualStyleBackColor = false;
            // 
            // btnReg
            // 
            this.btnReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(20)))));
            this.btnReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReg.FlatAppearance.BorderSize = 0;
            this.btnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReg.ForeColor = System.Drawing.Color.White;
            this.btnReg.Location = new System.Drawing.Point(361, 536);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(150, 40);
            this.btnReg.TabIndex = 9;
            this.btnReg.Text = "Cadastrar";
            this.btnReg.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(20)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(528, 536);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 40);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // lblBanner
            // 
            this.lblBanner.AutoSize = true;
            this.lblBanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanner.Location = new System.Drawing.Point(364, 308);
            this.lblBanner.Name = "lblBanner";
            this.lblBanner.Size = new System.Drawing.Size(67, 20);
            this.lblBanner.TabIndex = 45;
            this.lblBanner.Text = "Banner";
            // 
            // pivBanner
            // 
            this.pivBanner.Image = global::cetdabar.Properties.Resources.no_image;
            this.pivBanner.Location = new System.Drawing.Point(361, 331);
            this.pivBanner.Name = "pivBanner";
            this.pivBanner.Size = new System.Drawing.Size(362, 190);
            this.pivBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pivBanner.TabIndex = 46;
            this.pivBanner.TabStop = false;
            // 
            // btnAddBanner
            // 
            this.btnAddBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(20)))));
            this.btnAddBanner.FlatAppearance.BorderSize = 0;
            this.btnAddBanner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBanner.ForeColor = System.Drawing.Color.White;
            this.btnAddBanner.Location = new System.Drawing.Point(683, 481);
            this.btnAddBanner.Name = "btnAddBanner";
            this.btnAddBanner.Size = new System.Drawing.Size(40, 40);
            this.btnAddBanner.TabIndex = 4;
            this.btnAddBanner.Text = "+";
            this.btnAddBanner.UseVisualStyleBackColor = false;
            // 
            // txtArtigo
            // 
            this.txtArtigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArtigo.Location = new System.Drawing.Point(22, 195);
            this.txtArtigo.Multiline = true;
            this.txtArtigo.Name = "txtArtigo";
            this.txtArtigo.Size = new System.Drawing.Size(1045, 102);
            this.txtArtigo.TabIndex = 2;
            // 
            // lblArtigo
            // 
            this.lblArtigo.AutoSize = true;
            this.lblArtigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtigo.Location = new System.Drawing.Point(25, 172);
            this.lblArtigo.Name = "lblArtigo";
            this.lblArtigo.Size = new System.Drawing.Size(57, 20);
            this.lblArtigo.TabIndex = 49;
            this.lblArtigo.Text = "Artigo";
            // 
            // pnlBlog
            // 
            this.pnlBlog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(221)))));
            this.pnlBlog.Controls.Add(this.lblArtigo);
            this.pnlBlog.Controls.Add(this.txtArtigo);
            this.pnlBlog.Controls.Add(this.btnAddBanner);
            this.pnlBlog.Controls.Add(this.pivBanner);
            this.pnlBlog.Controls.Add(this.lblBanner);
            this.pnlBlog.Controls.Add(this.btnClear);
            this.pnlBlog.Controls.Add(this.btnReg);
            this.pnlBlog.Controls.Add(this.btnAddCapa);
            this.pnlBlog.Controls.Add(this.picCapa);
            this.pnlBlog.Controls.Add(this.lblCapa);
            this.pnlBlog.Controls.Add(this.lblStatus);
            this.pnlBlog.Controls.Add(this.cmbStatus);
            this.pnlBlog.Controls.Add(this.lblCod);
            this.pnlBlog.Controls.Add(this.txtCod);
            this.pnlBlog.Controls.Add(this.lblName);
            this.pnlBlog.Controls.Add(this.txtName);
            this.pnlBlog.Controls.Add(this.btnClose);
            this.pnlBlog.Controls.Add(this.lblClass);
            this.pnlBlog.Location = new System.Drawing.Point(100, 50);
            this.pnlBlog.Name = "pnlBlog";
            this.pnlBlog.Size = new System.Drawing.Size(1100, 600);
            this.pnlBlog.TabIndex = 4;
            // 
            // frmRegblog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cetdabar.Properties.Resources.backgroundproject;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.pnlBlog);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegblog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Artigo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRegblog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCapa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivBanner)).EndInit();
            this.pnlBlog.ResumeLayout(false);
            this.pnlBlog.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCapa;
        private System.Windows.Forms.PictureBox picCapa;
        private System.Windows.Forms.Button btnAddCapa;
        private CustomButton btnReg;
        private CustomButton btnClear;
        private System.Windows.Forms.Label lblBanner;
        private System.Windows.Forms.PictureBox pivBanner;
        private System.Windows.Forms.Button btnAddBanner;
        private System.Windows.Forms.TextBox txtArtigo;
        private System.Windows.Forms.Label lblArtigo;
        private System.Windows.Forms.Panel pnlBlog;
    }
}