using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleTcp;

namespace TCPServer
{
    public partial class Server : Form
    {
        SimpleTcpServer _server;
        string sifreli_metin;
        sifreleme sifrele = new sifreleme();
        
        public Server()
        {
            InitializeComponent();
        }

        private void baglan_btn_Click(object sender, EventArgs e)
        {
            _server.Start();
            info_txt.Text += $"Client Aranıyor...{Environment.NewLine}";

        }

        private void Server_Load(object sender, EventArgs e)
        {
            //serveri oluşturup bağlanti ve veri kontorlü yapıyoruz
            _server = new SimpleTcpServer(serverip_txt.Text);
            _server.Events.ClientConnected += Events_Connected;
            _server.Events.ClientDisconnected += Events_Disconnected;
            _server.Events.DataReceived += Events_DataReceived;
            
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
                clientip.Items.Remove(e.IpPort);
            });
            
           
        }

        private void Events_Connected(object sender, ClientConnectedEventArgs e) // Server bağalntısı başlandığında
        {
            this.Invoke((MethodInvoker)delegate
            {
                info_txt.Text += $"-{e.IpPort} Server ekelndi{Environment.NewLine}";
                clientip.Items.Add(e.IpPort);
            });
            
            
            
        }
        public static string HashToByte(byte[] hash)
        {
            StringBuilder result = new StringBuilder();
            foreach (byte item in hash)
            {
                result.Append(item.ToString("x2"));

            }

            return result.ToString();
        }

        public void mesajıGönder(string mesaj)
        {
            if (_server.IsListening)
            {
                _server.Send(clientip.SelectedItem.ToString(), mesaj);
                
            }
        }

        private void goder_btn_Click(object sender, EventArgs e)
        {
            if (sifreli_metin!=null)
            {
                mesajıGönder(sifreli_metin);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (msj_box.Text != "")
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    sifreli_metin = sifrele.SHA_256_sifreleme(msj_box.Text);
                    sifreli_txt.Text = sifreli_metin;
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    sifreli_metin = sifrele.BinaryToString(sifrele.SPN16(msj_box.Text));
                    sifreli_txt.Text = sifreli_metin;
                }
            }
        }

        private void cikisserver_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
