
namespace TCPServer
{
    partial class Server
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
            this.sifreli_txt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.goder_btn = new System.Windows.Forms.Button();
            this.msj_box = new System.Windows.Forms.TextBox();
            this.info_txt = new System.Windows.Forms.TextBox();
            this.serverip_txt = new System.Windows.Forms.TextBox();
            this.baglan_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.clientip = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cikisserver_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sifreli_txt
            // 
            this.sifreli_txt.AutoSize = true;
            this.sifreli_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreli_txt.Location = new System.Drawing.Point(140, 423);
            this.sifreli_txt.Name = "sifreli_txt";
            this.sifreli_txt.Size = new System.Drawing.Size(18, 25);
            this.sifreli_txt.TabIndex = 17;
            this.sifreli_txt.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(16, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Şifreli Mesaj";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(16, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mesaj:";
            // 
            // goder_btn
            // 
            this.goder_btn.Location = new System.Drawing.Point(271, 354);
            this.goder_btn.Name = "goder_btn";
            this.goder_btn.Size = new System.Drawing.Size(75, 23);
            this.goder_btn.TabIndex = 14;
            this.goder_btn.Text = "Gönder";
            this.goder_btn.UseVisualStyleBackColor = true;
            this.goder_btn.Click += new System.EventHandler(this.goder_btn_Click);
            // 
            // msj_box
            // 
            this.msj_box.Location = new System.Drawing.Point(98, 319);
            this.msj_box.Name = "msj_box";
            this.msj_box.Size = new System.Drawing.Size(329, 20);
            this.msj_box.TabIndex = 13;
            // 
            // info_txt
            // 
            this.info_txt.ForeColor = System.Drawing.Color.SlateGray;
            this.info_txt.Location = new System.Drawing.Point(98, 40);
            this.info_txt.Multiline = true;
            this.info_txt.Name = "info_txt";
            this.info_txt.ReadOnly = true;
            this.info_txt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.info_txt.Size = new System.Drawing.Size(329, 261);
            this.info_txt.TabIndex = 12;
            // 
            // serverip_txt
            // 
            this.serverip_txt.Location = new System.Drawing.Point(98, 14);
            this.serverip_txt.Name = "serverip_txt";
            this.serverip_txt.Size = new System.Drawing.Size(329, 20);
            this.serverip_txt.TabIndex = 11;
            this.serverip_txt.Text = "127.0.0.1:9000";
            // 
            // baglan_btn
            // 
            this.baglan_btn.Location = new System.Drawing.Point(352, 354);
            this.baglan_btn.Name = "baglan_btn";
            this.baglan_btn.Size = new System.Drawing.Size(75, 23);
            this.baglan_btn.TabIndex = 10;
            this.baglan_btn.Text = "Bağlan";
            this.baglan_btn.UseVisualStyleBackColor = true;
            this.baglan_btn.Click += new System.EventHandler(this.baglan_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Server:";
            // 
            // clientip
            // 
            this.clientip.FormattingEnabled = true;
            this.clientip.Location = new System.Drawing.Point(451, 63);
            this.clientip.Name = "clientip";
            this.clientip.Size = new System.Drawing.Size(301, 238);
            this.clientip.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(446, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Client İp:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "SHA256",
            "SPN-16"});
            this.comboBox1.Location = new System.Drawing.Point(451, 319);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cikisserver_btn
            // 
            this.cikisserver_btn.BackColor = System.Drawing.Color.Transparent;
            this.cikisserver_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cikisserver_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cikisserver_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.cikisserver_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(0)))), ((int)(((byte)(28)))));
            this.cikisserver_btn.Location = new System.Drawing.Point(714, 12);
            this.cikisserver_btn.Name = "cikisserver_btn";
            this.cikisserver_btn.Size = new System.Drawing.Size(38, 38);
            this.cikisserver_btn.TabIndex = 23;
            this.cikisserver_btn.Text = "X";
            this.cikisserver_btn.UseVisualStyleBackColor = false;
            this.cikisserver_btn.Click += new System.EventHandler(this.cikisserver_btn_Click);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(764, 487);
            this.ControlBox = false;
            this.Controls.Add(this.cikisserver_btn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.clientip);
            this.Controls.Add(this.sifreli_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.goder_btn);
            this.Controls.Add(this.msj_box);
            this.Controls.Add(this.info_txt);
            this.Controls.Add(this.serverip_txt);
            this.Controls.Add(this.baglan_btn);
            this.Controls.Add(this.label1);
            this.Name = "Server";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Server_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sifreli_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button goder_btn;
        private System.Windows.Forms.TextBox msj_box;
        private System.Windows.Forms.TextBox info_txt;
        private System.Windows.Forms.TextBox serverip_txt;
        private System.Windows.Forms.Button baglan_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox clientip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button cikisserver_btn;
    }
}

