namespace VocabularyGameForm
{
    partial class FormSoruEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSoruEkle));
            this.tbSoru = new System.Windows.Forms.TextBox();
            this.tbCevap = new System.Windows.Forms.TextBox();
            this.lbl_soru = new System.Windows.Forms.Label();
            this.lbl_cevap = new System.Windows.Forms.Label();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.lbl_rule = new System.Windows.Forms.Label();
            this.lbl_rule2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbSoru
            // 
            this.tbSoru.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbSoru.Location = new System.Drawing.Point(121, 15);
            this.tbSoru.Margin = new System.Windows.Forms.Padding(4);
            this.tbSoru.Name = "tbSoru";
            this.tbSoru.Size = new System.Drawing.Size(663, 25);
            this.tbSoru.TabIndex = 0;
            // 
            // tbCevap
            // 
            this.tbCevap.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbCevap.Location = new System.Drawing.Point(121, 47);
            this.tbCevap.Margin = new System.Windows.Forms.Padding(4);
            this.tbCevap.Name = "tbCevap";
            this.tbCevap.Size = new System.Drawing.Size(199, 25);
            this.tbCevap.TabIndex = 0;
            // 
            // lbl_soru
            // 
            this.lbl_soru.AutoSize = true;
            this.lbl_soru.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_soru.Location = new System.Drawing.Point(16, 18);
            this.lbl_soru.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_soru.Name = "lbl_soru";
            this.lbl_soru.Size = new System.Drawing.Size(54, 22);
            this.lbl_soru.TabIndex = 1;
            this.lbl_soru.Text = "Soru:";
            // 
            // lbl_cevap
            // 
            this.lbl_cevap.AutoSize = true;
            this.lbl_cevap.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_cevap.Location = new System.Drawing.Point(16, 50);
            this.lbl_cevap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cevap.Name = "lbl_cevap";
            this.lbl_cevap.Size = new System.Drawing.Size(67, 22);
            this.lbl_cevap.TabIndex = 1;
            this.lbl_cevap.Text = "Cevap:";
            // 
            // btn_ekle
            // 
            this.btn_ekle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekle.Location = new System.Drawing.Point(121, 79);
            this.btn_ekle.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(100, 28);
            this.btn_ekle.TabIndex = 2;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_rule
            // 
            this.lbl_rule.AutoSize = true;
            this.lbl_rule.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_rule.Location = new System.Drawing.Point(329, 50);
            this.lbl_rule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_rule.Name = "lbl_rule";
            this.lbl_rule.Size = new System.Drawing.Size(475, 19);
            this.lbl_rule.TabIndex = 1;
            this.lbl_rule.Text = "Cevap en az 4, en fazla 10 harfli olabilir. Soru en az 15 harfli olabilir.";
            // 
            // lbl_rule2
            // 
            this.lbl_rule2.AutoSize = true;
            this.lbl_rule2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_rule2.Location = new System.Drawing.Point(329, 79);
            this.lbl_rule2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_rule2.Name = "lbl_rule2";
            this.lbl_rule2.Size = new System.Drawing.Size(251, 19);
            this.lbl_rule2.TabIndex = 1;
            this.lbl_rule2.Text = "Cevap tek kelime olmak zorundadır.";
            // 
            // FormSoruEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 132);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.lbl_rule2);
            this.Controls.Add(this.lbl_rule);
            this.Controls.Add(this.lbl_cevap);
            this.Controls.Add(this.lbl_soru);
            this.Controls.Add(this.tbCevap);
            this.Controls.Add(this.tbSoru);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSoruEkle";
            this.Text = "Soru Ekle";
            this.Load += new System.EventHandler(this.FormSoruEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSoru;
        private System.Windows.Forms.TextBox tbCevap;
        private System.Windows.Forms.Label lbl_soru;
        private System.Windows.Forms.Label lbl_cevap;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Label lbl_rule;
        private System.Windows.Forms.Label lbl_rule2;
    }
}