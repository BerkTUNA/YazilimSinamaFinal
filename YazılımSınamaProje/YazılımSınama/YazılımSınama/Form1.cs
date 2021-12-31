using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SimpleTcp;


namespace YazılımSınama
{
    public partial class Alıcı : Form
    {

        SimpleTcpClient _client;
        string sifrelimetin;
        sifreleme sifrele = new sifreleme();
        public Alıcı()
        {
            InitializeComponent();
        }

        private void Alıcı_Load(object sender, EventArgs e)
        {
            _client = new SimpleTcpClient(ip_txt.Text);
            _client.Events.Connected += Events_Connected;
            _client.Events.Disconnected += Events_Disconnected;
            _client.Events.DataReceived += Events_DataReceived;



        }

        private void baglan_btn_Click(object sender, EventArgs e)
        {
            try
            {
                _client.Connect();
            }
            catch (Exception)
            {
                MessageBox.Show("Server Çalışmıyor!");
                throw;
            }
        }
        private void Events_DataReceived(object sender, DataReceivedEventArgs e) // serverdan veriyi aldığımzda
        {
            //karşı taraftan gelen mesaj şifreli çekilde yazdırılıyor
            this.Invoke((MethodInvoker)delegate {

                info_txt.Text += $"-{e.IpPort}:{Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";

            });

        }

        private void Events_Disconnected(object sender, ClientDisconnectedEventArgs e) // serverla bağlantı bittiğinde
        {
            this.Invoke((MethodInvoker)delegate
            {
                info_txt.Text += $"-{e.IpPort} bağlantı bitti {Environment.NewLine}";
                
            });

        }

        private void Events_Connected(object sender, ClientConnectedEventArgs e) // Server bağalntısı başlandığında
        {
            this.Invoke((MethodInvoker)delegate
            {
                info_txt.Text += $"-{e.IpPort} Server ekelndi{Environment.NewLine}";
                
            });

        }

        private void goder_btn_Click(object sender, EventArgs e)
        {
            if (sifrelimetin!=null)
            {
                gönder(sifrelimetin);
            }
            
        }
        public void gönder(string mesaj)
        {
            if (_client.IsConnected)
            {
                _client.Send(mesaj);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (msj_box.Text!="")
            {
                if (comboBox1.SelectedIndex==0)
                {
                   sifrelimetin =   sifrele.SHA_256_sifreleme(msj_box.Text);
                   sifreli_txt.Text = sifrelimetin;
                }
                else if (comboBox1.SelectedIndex==1)
                {
                    sifrelimetin = sifrele.BinaryToString(sifrele.SPN16(msj_box.Text));
                    sifreli_txt.Text = sifrelimetin;
                }
            }
        }

        private void cikisclient_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    
}
