using System;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.ComponentModel.Design;

namespace TCPServer
{
    public partial class Form1 : Form
    {
        private TCPServer server;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            TCPServer s = new TCPServer("localhost", 4000);
            s.Start();
            MessageBox.Show("Servidor iniciado correctamente.");
        }
    }
}
