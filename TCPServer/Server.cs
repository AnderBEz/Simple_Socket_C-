using System;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.ComponentModel.Design;//podemos utilizar hilos

namespace TCPServer
{
    internal class TCPServer
    {

        IPHostEntry host;
        IPAddress ipAddr;
        IPEndPoint endPoint;

        Socket s_Server;
        Socket s_Client;

        public TCPServer(string ip, int port) 
        {
            host = Dns.GetHostEntry(ip);
            ipAddr = host.AddressList[0];
            endPoint = new IPEndPoint(ipAddr, port);

            s_Server = new Socket(ipAddr.AddressFamily,SocketType.Stream, ProtocolType.Tcp);
            s_Server.Bind(endPoint);
            s_Server.Listen(10);

        }

        public void Start()
        {
 
            Thread t;

            while (true)
            {
                Console.WriteLine("Esperando conexiones...\n");
                s_Client = s_Server.Accept();
                t = new Thread(clientConnection);
                t.Start(s_Client);
                Console.WriteLine("Se ha conectado un cliente.\n");
            }



        }

        public void clientConnection(object s)
        {
            Socket s_Client = (Socket)s;
            byte[] buffer = new byte[1024];
            string user;
            string password;

            //es posible que el flujo de salida no se vea al instante


            try
            {
                while (true)
                {
                    //recibimos un buffer
                    buffer = new byte[1024];
                    s_Client.Receive(buffer);
                    user = byte2string(buffer);


                    buffer = new byte[1024];
                    s_Client.Receive(buffer);
                    password = byte2string(buffer);

                    if (user == "admin" && password == "admin")
                    {
                        byte[] response = Encoding.ASCII.GetBytes("success");
                        s_Client.Send(response);
                    }
                    else
                    {
                        byte[] response = Encoding.ASCII.GetBytes("failed");
                        s_Client.Send(response);
                    }
                }
            }
            catch (SocketException se)
            {
                Console.WriteLine("Se ha desconectado un cliente: {0}", se.Message);
            }

 
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

    }
}
