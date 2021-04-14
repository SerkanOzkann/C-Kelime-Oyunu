namespace VocabularyGameForm
{
    partial class Girisform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Girisform));
            this.gb_giris = new System.Windows.Forms.GroupBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_SoruEkle = new System.Windows.Forms.Button();
            this.btn_giris = new System.Windows.Forms.Button();
            this.tb_kadi = new System.Windows.Forms.TextBox();
            this.lbl_kadi = new System.Windows.Forms.Label();
            this.pb_login = new System.Windows.Forms.PictureBox();
            this.link_github = new System.Windows.Forms.LinkLabel();
            this.pictureBox_ee = new System.Windows.Forms.PictureBox();
            this.pictureBox_m = new System.Windows.Forms.PictureBox();
            this.pictureBox_i = new System.Windows.Forms.PictureBox();
            this.pictureBox_l = new System.Windows.Forms.PictureBox();
            this.pictureBox_e = new System.Windows.Forms.PictureBox();
            this.pictureBox_k = new System.Windows.Forms.PictureBox();
            this.gb_giris.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_m)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_i)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_l)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_e)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_k)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_giris
            // 
            this.gb_giris.BackColor = System.Drawing.Color.White;
            this.gb_giris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gb_giris.BackgroundImage")));
            this.gb_giris.Controls.Add(this.link_github);
            this.gb_giris.Controls.Add(this.btn_exit);
            this.gb_giris.Controls.Add(this.btn_SoruEkle);
            this.gb_giris.Controls.Add(this.btn_giris);
            this.gb_giris.Controls.Add(this.tb_kadi);
            this.gb_giris.Controls.Add(this.lbl_kadi);
            this.gb_giris.Controls.Add(this.pb_login);
            this.gb_giris.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gb_giris.Location = new System.Drawing.Point(232, 87);
            this.gb_giris.Name = "gb_giris";
            this.gb_giris.Size = new System.Drawing.Size(438, 290);
            this.gb_giris.TabIndex = 15;
            this.gb_giris.TabStop = false;
            this.gb_giris.Text = "Giriş Yap";
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Red;
            this.btn_exit.BackgroundImage = global::VocabularyGameForm.Properties.Resources.exitbutton;
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exit.Location = new System.Drawing.Point(316, 126);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(60, 57);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_SoruEkle
            // 
            this.btn_SoruEkle.BackColor = System.Drawing.Color.Orange;
            this.btn_SoruEkle.BackgroundImage = global::VocabularyGameForm.Properties.Resources.question;
            this.btn_SoruEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_SoruEkle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_SoruEkle.Location = new System.Drawing.Point(269, 190);
            this.btn_SoruEkle.Name = "btn_SoruEkle";
            this.btn_SoruEkle.Size = new System.Drawing.Size(60, 57);
            this.btn_SoruEkle.TabIndex = 3;
            this.btn_SoruEkle.UseVisualStyleBackColor = false;
            this.btn_SoruEkle.Click += new System.EventHandler(this.btn_SoruEkle_Click);
            // 
            // btn_giris
            // 
            this.btn_giris.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_giris.BackgroundImage = global::VocabularyGameForm.Properties.Resources.startbutton;
            this.btn_giris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_giris.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_giris.Location = new System.Drawing.Point(222, 127);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(60, 57);
            this.btn_giris.TabIndex = 3;
            this.btn_giris.UseVisualStyleBackColor = false;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // tb_kadi
            // 
            this.tb_kadi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_kadi.Location = new System.Drawing.Point(222, 91);
            this.tb_kadi.Name = "tb_kadi";
            this.tb_kadi.Size = new System.Drawing.Size(154, 30);
            this.tb_kadi.TabIndex = 2;
            // 
            // lbl_kadi
            // 
            this.lbl_kadi.AutoSize = true;
            this.lbl_kadi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_kadi.Location = new System.Drawing.Point(217, 49);
            this.lbl_kadi.Name = "lbl_kadi";
            this.lbl_kadi.Size = new System.Drawing.Size(159, 26);
            this.lbl_kadi.TabIndex = 1;
            this.lbl_kadi.Text = "OYUNCUADI";
            // 
            // pb_login
            // 
            this.pb_login.BackColor = System.Drawing.Color.Transparent;
            this.pb_login.Image = global::VocabularyGameForm.Properties.Resources.login;
            this.pb_login.Location = new System.Drawing.Point(17, 49);
            this.pb_login.Name = "pb_login";
            this.pb_login.Size = new System.Drawing.Size(172, 198);
            this.pb_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_login.TabIndex = 0;
            this.pb_login.TabStop = false;
            // 
            // link_github
            // 
            this.link_github.AutoSize = true;
            this.link_github.BackColor = System.Drawing.Color.Transparent;
            this.link_github.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.link_github.LinkColor = System.Drawing.Color.Black;
            this.link_github.Location = new System.Drawing.Point(130, 265);
            this.link_github.Name = "link_github";
            this.link_github.Size = new System.Drawing.Size(199, 25);
            this.link_github.TabIndex = 16;
            this.link_github.TabStop = true;
            this.link_github.Text = "GitHub/SerkanOzkan";
            this.link_github.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_github_LinkClicked);
            // 
            // pictureBox_ee
            // 
            this.pictureBox_ee.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_ee.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_ee.Image")));
            this.pictureBox_ee.Location = new System.Drawing.Point(602, 12);
            this.pictureBox_ee.Name = "pictureBox_ee";
            this.pictureBox_ee.Size = new System.Drawing.Size(68, 59);
            this.pictureBox_ee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_ee.TabIndex = 14;
            this.pictureBox_ee.TabStop = false;
            // 
            // pictureBox_m
            // 
            this.pictureBox_m.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_m.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_m.Image")));
            this.pictureBox_m.Location = new System.Drawing.Point(528, 12);
            this.pictureBox_m.Name = "pictureBox_m";
            this.pictureBox_m.Size = new System.Drawing.Size(68, 59);
            this.pictureBox_m.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_m.TabIndex = 13;
            this.pictureBox_m.TabStop = false;
            // 
            // pictureBox_i
            // 
            this.pictureBox_i.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_i.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_i.Image")));
            this.pictureBox_i.Location = new System.Drawing.Point(454, 12);
            this.pictureBox_i.Name = "pictureBox_i";
            this.pictureBox_i.Size = new System.Drawing.Size(68, 59);
            this.pictureBox_i.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_i.TabIndex = 12;
            this.pictureBox_i.TabStop = false;
            // 
            // pictureBox_l
            // 
            this.pictureBox_l.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_l.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_l.Image")));
            this.pictureBox_l.Location = new System.Drawing.Point(380, 12);
            this.pictureBox_l.Name = "pictureBox_l";
            this.pictureBox_l.Size = new System.Drawing.Size(68, 59);
            this.pictureBox_l.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_l.TabIndex = 11;
            this.pictureBox_l.TabStop = false;
            // 
            // pictureBox_e
            // 
            this.pictureBox_e.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_e.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_e.Image")));
            this.pictureBox_e.Location = new System.Drawing.Point(306, 12);
            this.pictureBox_e.Name = "pictureBox_e";
            this.pictureBox_e.Size = new System.Drawing.Size(68, 59);
            this.pictureBox_e.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_e.TabIndex = 10;
            this.pictureBox_e.TabStop = false;
            // 
            // pictureBox_k
            // 
            this.pictureBox_k.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_k.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_k.Image")));
            this.pictureBox_k.Location = new System.Drawing.Point(232, 12);
            this.pictureBox_k.Name = "pictureBox_k";
            this.pictureBox_k.Size = new System.Drawing.Size(68, 59);
            this.pictureBox_k.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_k.TabIndex = 9;
            this.pictureBox_k.TabStop = false;
            // 
            // Girisform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(879, 491);
            this.Controls.Add(this.gb_giris);
            this.Controls.Add(this.pictureBox_ee);
            this.Controls.Add(this.pictureBox_m);
            this.Controls.Add(this.pictureBox_i);
            this.Controls.Add(this.pictureBox_l);
            this.Controls.Add(this.pictureBox_e);
            this.Controls.Add(this.pictureBox_k);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Girisform";
            this.Text = "Vocabulary Game";
            this.Load += new System.EventHandler(this.Girisform_Load);
            this.gb_giris.ResumeLayout(false);
            this.gb_giris.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_m)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_i)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_l)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_e)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_k)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_ee;
        private System.Windows.Forms.PictureBox pictureBox_m;
        private System.Windows.Forms.PictureBox pictureBox_i;
        private System.Windows.Forms.PictureBox pictureBox_l;
        private System.Windows.Forms.PictureBox pictureBox_e;
        private System.Windows.Forms.PictureBox pictureBox_k;
        private System.Windows.Forms.GroupBox gb_giris;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.TextBox tb_kadi;
        private System.Windows.Forms.Label lbl_kadi;
        private System.Windows.Forms.PictureBox pb_login;
        private System.Windows.Forms.LinkLabel link_github;
        private System.Windows.Forms.Button btn_SoruEkle;
        private System.Windows.Forms.Button btn_exit;
    }
}