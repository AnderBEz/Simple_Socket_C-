using System;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.ComponentModel.Design;
using SuperSimpleTcp;
using System.Windows.Forms;

namespace TCPServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string ip;
        SimpleTcpServer server;

        private void btnStart_Click(object sender, EventArgs e)
        {

            try
            {
                string ip = txtIP.Text;
                server = new SimpleTcpServer(ip, 4404); // Utiliza la variable de clase
                server.Events.ClientConnected += Events_ClientConnected;
                server.Events.DataReceived += Events_DataReceived;
                server.Events.ClientDisconnected += Events_ClientDisconnected;
                txtChat.Text += $"{Environment.NewLine} Started...";
                server.Start();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            /*
            TCPServer s = new TCPServer("localhost", 4404);
            s.Start();
            */
        }

        private void Events_DataReceived(object? sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtChat.Text += $"{Environment.NewLine} {e.IpPort}: {Encoding.UTF8.GetString(e.Data)}";
                listUsers.Items.Remove(e.IpPort);
            });
        }

        private void Events_ClientConnected(object? sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtChat.Text += $"{Environment.NewLine} {e.IpPort} Client connected";
                listUsers.Items.Add(e.IpPort);
            });
        }

        private void Events_ClientDisconnected(object? sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtChat.Text += $"{Environment.NewLine} {e.IpPort} Disconnected...{e.Reason}";
            });

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (server.IsListening && listUsers.SelectedItem != null)
            {
                string message = txtMsg.Text;
                server.Send(listUsers.SelectedItem.ToString(), message);
                txtChat.Text += $"Server: {Environment.NewLine} {message}";
            }
            else
            {
                MessageBox.Show("Please select a user to send the message to.", "Error");
            }

        }
    }
}
