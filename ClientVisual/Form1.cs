using System;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.ComponentModel.Design;
using SuperSimpleTcp;
using System.Windows.Forms;

namespace ClientVisual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SimpleTcpClient client;
        string ip;

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtMsg.Text.Trim() != "")
            {
                client.Send(txtMsg.Text);
                txtChat.Text += $"{Environment.NewLine} User: {txtMsg.Text}";
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            ip = txtIP.Text;
            client = new SimpleTcpClient(ip, 4404); // Utiliza la variable de clase
            client.Events.Connected += Events_Connected;
            client.Events.Disconnected += Events_Disconnected;
            client.Events.DataReceived += Events_DataReceived;
            client.Connect();
        }

        private void Events_DataReceived(object? sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtChat.Text += $"{Environment.NewLine} {e.IpPort}: {Encoding.UTF8.GetString(e.Data)}";
            });
        }

        private void Events_Disconnected(object? sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtChat.Text += $"{Environment.NewLine} Disconnected";
            });
        }

        private void Events_Connected(object? sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtChat.Text += $"{Environment.NewLine} Connected";
            });
        }

    }
}
