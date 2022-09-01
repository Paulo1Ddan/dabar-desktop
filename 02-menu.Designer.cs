namespace cetdabar
{
    partial class frmMenu
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.dgvReg = new System.Windows.Forms.DataGridView();
            this.picClass = new System.Windows.Forms.PictureBox();
            this.picBlog = new System.Windows.Forms.PictureBox();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.picEmail = new System.Windows.Forms.PictureBox();
            this.picCursos = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRegLog = new cetdabar.CustomButton();
            this.btnRegNeg = new cetdabar.CustomButton();
            this.btnRegWait = new cetdabar.CustomButton();
            this.btnRegApr = new cetdabar.CustomButton();
            this.btnRegDel = new cetdabar.CustomButton();
            this.btnRegUpd = new cetdabar.CustomButton();
            this.btnRegCad = new cetdabar.CustomButton();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCursos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(221)))));
            this.pnlMenu.Controls.Add(this.btnRegLog);
            this.pnlMenu.Controls.Add(this.lblTime);
            this.pnlMenu.Controls.Add(this.lblDate);
            this.pnlMenu.Controls.Add(this.lblUser);
            this.pnlMenu.Controls.Add(this.dgvReg);
            this.pnlMenu.Controls.Add(this.btnRegNeg);
            this.pnlMenu.Controls.Add(this.btnRegWait);
            this.pnlMenu.Controls.Add(this.btnRegApr);
            this.pnlMenu.Controls.Add(this.btnRegDel);
            this.pnlMenu.Controls.Add(this.btnRegUpd);
            this.pnlMenu.Controls.Add(this.btnRegCad);
            this.pnlMenu.Controls.Add(this.picClass);
            this.pnlMenu.Controls.Add(this.picBlog);
            this.pnlMenu.Controls.Add(this.picUser);
            this.pnlMenu.Controls.Add(this.picEmail);
            this.pnlMenu.Controls.Add(this.picCursos);
            this.pnlMenu.Controls.Add(this.pictureBox1);
            this.pnlMenu.Controls.Add(this.btnClose);
            this.pnlMenu.Location = new System.Drawing.Point(112, 45);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1100, 600);
            this.pnlMenu.TabIndex = 1;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(937, 12);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(85, 20);
            this.lblTime.TabIndex = 32;
            this.lblTime.Text = "hh:mm:ss";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(811, 12);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(107, 20);
            this.lblDate.TabIndex = 31;
            this.lblDate.Text = "dd/mm/aaaa";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(12, 12);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(110, 20);
            this.lblUser.TabIndex = 30;
            this.lblUser.Text = "Paulo Daniel";
            // 
            // dgvReg
            // 
            this.dgvReg.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(20)))));
            this.dgvReg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReg.Location = new System.Drawing.Point(419, 48);
            this.dgvReg.Name = "dgvReg";
            this.dgvReg.Size = new System.Drawing.Size(516, 303);
            this.dgvReg.TabIndex = 29;
            // 
            // picClass
            // 
            this.picClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClass.Image = global::cetdabar.Properties.Resources.img_class;
            this.picClass.Location = new System.Drawing.Point(213, 48);
            this.picClass.Name = "picClass";
            this.picClass.Size = new System.Drawing.Size(200, 200);
            this.picClass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClass.TabIndex = 21;
            this.picClass.TabStop = false;
            this.picClass.Click += new System.EventHandler(this.picClass_Click);
            // 
            // picBlog
            // 
            this.picBlog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBlog.Image = global::cetdabar.Properties.Resources.img_blog;
            this.picBlog.Location = new System.Drawing.Point(871, 357);
            this.picBlog.Name = "picBlog";
            this.picBlog.Size = new System.Drawing.Size(220, 220);
            this.picBlog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBlog.TabIndex = 20;
            this.picBlog.TabStop = false;
            this.picBlog.Click += new System.EventHandler(this.picBlog_Click);
            // 
            // picUser
            // 
            this.picUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picUser.Image = global::cetdabar.Properties.Resources.img_users;
            this.picUser.Location = new System.Drawing.Point(645, 357);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(220, 220);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUser.TabIndex = 19;
            this.picUser.TabStop = false;
            this.picUser.Click += new System.EventHandler(this.picUser_Click);
            // 
            // picEmail
            // 
            this.picEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picEmail.Image = global::cetdabar.Properties.Resources.img_email;
            this.picEmail.Location = new System.Drawing.Point(419, 357);
            this.picEmail.Name = "picEmail";
            this.picEmail.Size = new System.Drawing.Size(220, 220);
            this.picEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEmail.TabIndex = 18;
            this.picEmail.TabStop = false;
            // 
            // picCursos
            // 
            this.picCursos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCursos.Image = global::cetdabar.Properties.Resources.img_cursos;
            this.picCursos.Location = new System.Drawing.Point(7, 48);
            this.picCursos.Name = "picCursos";
            this.picCursos.Size = new System.Drawing.Size(200, 200);
            this.picCursos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCursos.TabIndex = 15;
            this.picCursos.TabStop = false;
            this.picCursos.Click += new System.EventHandler(this.picCursos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::cetdabar.Properties.Resources.img_company;
            this.pictureBox1.Location = new System.Drawing.Point(7, 254);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(406, 323);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(23)))), ((int)(((byte)(68)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1060, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRegLog
            // 
            this.btnRegLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(20)))));
            this.btnRegLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegLog.FlatAppearance.BorderSize = 0;
            this.btnRegLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegLog.ForeColor = System.Drawing.Color.White;
            this.btnRegLog.Location = new System.Drawing.Point(941, 310);
            this.btnRegLog.Name = "btnRegLog";
            this.btnRegLog.Size = new System.Drawing.Size(150, 40);
            this.btnRegLog.TabIndex = 33;
            this.btnRegLog.Text = "Relatório";
            this.btnRegLog.UseVisualStyleBackColor = false;
            // 
            // btnRegNeg
            // 
            this.btnRegNeg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(20)))));
            this.btnRegNeg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegNeg.FlatAppearance.BorderSize = 0;
            this.btnRegNeg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegNeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegNeg.ForeColor = System.Drawing.Color.White;
            this.btnRegNeg.Location = new System.Drawing.Point(941, 266);
            this.btnRegNeg.Name = "btnRegNeg";
            this.btnRegNeg.Size = new System.Drawing.Size(150, 40);
            this.btnRegNeg.TabIndex = 28;
            this.btnRegNeg.Text = "Negadas";
            this.btnRegNeg.UseVisualStyleBackColor = false;
            // 
            // btnRegWait
            // 
            this.btnRegWait.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(20)))));
            this.btnRegWait.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegWait.FlatAppearance.BorderSize = 0;
            this.btnRegWait.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegWait.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegWait.ForeColor = System.Drawing.Color.White;
            this.btnRegWait.Location = new System.Drawing.Point(941, 222);
            this.btnRegWait.Name = "btnRegWait";
            this.btnRegWait.Size = new System.Drawing.Size(150, 40);
            this.btnRegWait.TabIndex = 27;
            this.btnRegWait.Text = "Pendentes";
            this.btnRegWait.UseVisualStyleBackColor = false;
            // 
            // btnRegApr
            // 
            this.btnRegApr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(20)))));
            this.btnRegApr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegApr.FlatAppearance.BorderSize = 0;
            this.btnRegApr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegApr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegApr.ForeColor = System.Drawing.Color.White;
            this.btnRegApr.Location = new System.Drawing.Point(941, 178);
            this.btnRegApr.Name = "btnRegApr";
            this.btnRegApr.Size = new System.Drawing.Size(150, 40);
            this.btnRegApr.TabIndex = 26;
            this.btnRegApr.Text = "Aprovadas";
            this.btnRegApr.UseVisualStyleBackColor = false;
            // 
            // btnRegDel
            // 
            this.btnRegDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(20)))));
            this.btnRegDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegDel.FlatAppearance.BorderSize = 0;
            this.btnRegDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegDel.ForeColor = System.Drawing.Color.White;
            this.btnRegDel.Location = new System.Drawing.Point(941, 134);
            this.btnRegDel.Name = "btnRegDel";
            this.btnRegDel.Size = new System.Drawing.Size(150, 40);
            this.btnRegDel.TabIndex = 25;
            this.btnRegDel.Text = "Excluir";
            this.btnRegDel.UseVisualStyleBackColor = false;
            // 
            // btnRegUpd
            // 
            this.btnRegUpd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(20)))));
            this.btnRegUpd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegUpd.FlatAppearance.BorderSize = 0;
            this.btnRegUpd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegUpd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegUpd.ForeColor = System.Drawing.Color.White;
            this.btnRegUpd.Location = new System.Drawing.Point(941, 90);
            this.btnRegUpd.Name = "btnRegUpd";
            this.btnRegUpd.Size = new System.Drawing.Size(150, 40);
            this.btnRegUpd.TabIndex = 24;
            this.btnRegUpd.Text = "Alterar";
            this.btnRegUpd.UseVisualStyleBackColor = false;
            // 
            // btnRegCad
            // 
            this.btnRegCad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(20)))));
            this.btnRegCad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegCad.FlatAppearance.BorderSize = 0;
            this.btnRegCad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegCad.ForeColor = System.Drawing.Color.White;
            this.btnRegCad.Location = new System.Drawing.Point(941, 46);
            this.btnRegCad.Name = "btnRegCad";
            this.btnRegCad.Size = new System.Drawing.Size(150, 40);
            this.btnRegCad.TabIndex = 23;
            this.btnRegCad.Text = "Cadastrar";
            this.btnRegCad.UseVisualStyleBackColor = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cetdabar.Properties.Resources.backgroundproject;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.pnlMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCursos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox picClass;
        private System.Windows.Forms.PictureBox picBlog;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.PictureBox picEmail;
        private System.Windows.Forms.PictureBox picCursos;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.DataGridView dgvReg;
        private CustomButton btnRegNeg;
        private CustomButton btnRegWait;
        private CustomButton btnRegApr;
        private CustomButton btnRegDel;
        private CustomButton btnRegUpd;
        private CustomButton btnRegCad;
        private CustomButton btnRegLog;
    }
}