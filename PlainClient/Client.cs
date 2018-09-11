using ModelLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace PlainClient
{
    class Client
    {
        public Client()
        {

        }

        public void Start()
        {
            Car c = new Car("Tesla", "Red", "EL23400");

            using (TcpClient socket = new TcpClient("localhost", 10001))

            using (NetworkStream ns = socket.GetStream())

            using (StreamReader sr = new StreamReader(ns))
            using (StreamWriter sw = new StreamWriter(ns))

            {
                sw.WriteLine($"{c.ToString()}");
                sw.Flush();
            }
        }
    }
}
