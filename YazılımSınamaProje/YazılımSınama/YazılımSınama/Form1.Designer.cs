
namespace YazılımSınama
{
    partial class Alıcı
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.baglan_btn = new System.Windows.Forms.Button();
            this.ip_txt = new System.Windows.Forms.TextBox();
            this.info_txt = new System.Windows.Forms.TextBox();
            this.msj_box = new System.Windows.Forms.TextBox();
            this.goder_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sifreli_txt = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cikisclient_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server:";
            // 
            // baglan_btn
            // 
            this.baglan_btn.Location = new System.Drawing.Point(348, 375);
            this.baglan_btn.Name = "baglan_btn";
            this.baglan_btn.Size = new System.Drawing.Size(75, 23);
            this.baglan_btn.TabIndex = 1;
            this.baglan_btn.Text = "Bağlan";
            this.baglan_btn.UseVisualStyleBackColor = true;
            this.baglan_btn.Click += new System.EventHandler(this.baglan_btn_Click);
            // 
            // ip_txt
            // 
            this.ip_txt.Location = new System.Drawing.Point(94, 35);
            this.ip_txt.Name = "ip_txt";
            this.ip_txt.Size = new System.Drawing.Size(329, 20);
            this.ip_txt.TabIndex = 2;
            this.ip_txt.Text = "127.0.0.1:9000";
            // 
            // info_txt
            // 
            this.info_txt.ForeColor = System.Drawing.Color.SlateGray;
            this.info_txt.Location = new System.Drawing.Point(94, 61);
            this.info_txt.Multiline = true;
            this.info_txt.Name = "info_txt";
            this.info_txt.ReadOnly = true;
            this.info_txt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.info_txt.Size = new System.Drawing.Size(329, 261);
            this.info_txt.TabIndex = 3;
            // 
            // msj_box
            // 
            this.msj_box.Location = new System.Drawing.Point(94, 340);
            this.msj_box.Name = "msj_box";
            this.msj_box.Size = new System.Drawing.Size(329, 20);
            this.msj_box.TabIndex = 4;
            // 
            // goder_btn
            // 
            this.goder_btn.Location = new System.Drawing.Point(267, 375);
            this.goder_btn.Name = "goder_btn";
            this.goder_btn.Size = new System.Drawing.Size(75, 23);
            this.goder_btn.TabIndex = 5;
            this.goder_btn.Text = "Gönder";
            this.goder_btn.UseVisualStyleBackColor = true;
            this.goder_btn.Click += new System.EventHandler(this.goder_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mesaj:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 444);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Şifreli Mesaj";
            // 
            // sifreli_txt
            // 
            this.sifreli_txt.AutoSize = true;
            this.sifreli_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreli_txt.Location = new System.Drawing.Point(136, 444);
            this.sifreli_txt.Name = "sifreli_txt";
            this.sifreli_txt.Size = new System.Drawing.Size(18, 25);
            this.sifreli_txt.TabIndex = 8;
            this.sifreli_txt.Text = ":";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "SHA256",
            "SPN-16"});
            this.comboBox1.Location = new System.Drawing.Point(447, 339);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cikisclient_btn
            // 
            this.cikisclient_btn.BackColor = System.Drawing.Color.Transparent;
            this.cikisclient_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cikisclient_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cikisclient_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.cikisclient_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(0)))), ((int)(((byte)(28)))));
            this.cikisclient_btn.Location = new System.Drawing.Point(542, 12);
            this.cikisclient_btn.Name = "cikisclient_btn";
            this.cikisclient_btn.Size = new System.Drawing.Size(38, 38);
            this.cikisclient_btn.TabIndex = 22;
            this.cikisclient_btn.Text = "X";
            this.cikisclient_btn.UseVisualStyleBackColor = false;
            this.cikisclient_btn.Click += new System.EventHandler(this.cikisclient_btn_Click);
            // 
            // Alıcı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(592, 514);
            this.ControlBox = false;
            this.Controls.Add(this.cikisclient_btn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.sifreli_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.goder_btn);
            this.Controls.Add(this.msj_box);
            this.Controls.Add(this.info_txt);
            this.Controls.Add(this.ip_txt);
            this.Controls.Add(this.baglan_btn);
            this.Controls.Add(this.label1);
            this.Name = "Alıcı";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Alıcı_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button baglan_btn;
        private System.Windows.Forms.TextBox ip_txt;
        private System.Windows.Forms.TextBox info_txt;
        private System.Windows.Forms.TextBox msj_box;
        private System.Windows.Forms.Button goder_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label sifreli_txt;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button cikisclient_btn;
    }
}

