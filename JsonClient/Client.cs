using ModelLib;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace JsonClient
{
    class Client
    {
        public Client()
        {

        }

        public void Start()
        {
            Car c = new Car("Tesla", "Green", "JsonCar4");

            using (TcpClient socket = new TcpClient("localhost", 10002))

            using (NetworkStream ns = socket.GetStream())

            using (StreamReader sr = new StreamReader(ns))
            using (StreamWriter sw = new StreamWriter(ns))

            {
                String jsonString = JsonConvert.SerializeObject(c);

                sw.WriteLine(jsonString);
                sw.Flush();
            }
        }
    }
}
