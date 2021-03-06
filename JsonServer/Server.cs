﻿using ModelLib;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace JsonServer
{
    class Server
    {
        private readonly int pORT = 10002;

        public Server()
        {

        }

        public void Start()
        {
            TcpListener serverListener = new TcpListener(IPAddress.Loopback, pORT);
            serverListener.Start();

            while (true)
            {
                TcpClient socket = serverListener.AcceptTcpClient();
                Task.Run(() => { TcpClient tempSocket = socket; DoClient(tempSocket); });
                //DoClient(/*TcpClient socket =*/ serverListener.AcceptTcpClient());
            }
        }

        public void DoClient(TcpClient socket /*= serverListener.AcceptTcpClient*/)
        {
            //using (TcpClient socket = serverListener.AcceptTcpClient())
            //Unødvendig da denne nu ligger i metodens parameter

            using (StreamReader sr = new StreamReader(socket.GetStream()))
            using (StreamWriter sw = new StreamWriter(socket.GetStream()))

            {
                String incomingString = sr.ReadLine();

                AutoSale sale = JsonConvert.DeserializeObject<AutoSale>(incomingString);

                Console.WriteLine($"String in:\n{sale}");
            }
        }
    }
}
