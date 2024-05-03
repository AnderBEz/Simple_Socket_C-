using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Client
{
    class Client
    {
        IPHostEntry host;
        IPAddress ipAddr;
        IPEndPoint endPoint;

        Socket s_Client;

        public Client(string ip, int port)
        {
            host = Dns.GetHostByName(ip);
            ipAddr = host.AddressList[0];
            endPoint = new IPEndPoint(ipAddr, port);

            s_Client = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            

        }

        public void Start()
        {
            s_Client.Connect(endPoint);
           
        }

        public void Send(string msg)
        {
            byte[] byteMsg = Encoding.ASCII.GetBytes(msg);
            s_Client.Send(byteMsg);
            Console.WriteLine("Mensaje Enviado ");
        }



        public string byte2string(byte[] buffer)
        {
            string message;
            int endIndex;

            message = Encoding.ASCII.GetString(buffer);
            endIndex = message.IndexOf('\0');
            if (endIndex > 0)
                message = message.Substring(0, endIndex);

            return message;
        }

        public string Receive()
        {
            byte[] buffer = new byte[1024];
            s_Client.Receive(buffer);
            return byte2string(buffer);

        }

    }
}
