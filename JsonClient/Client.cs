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

            Car c1 = new Car("Ford", "Blue", "AutoSaleCar1");
            Car c2 = new Car("Saab", "Black", "AutoSaleCar2");

            List<Car> cList = new List<Car> { c1, c2 };

            AutoSale sale = new AutoSale("Dave", "Street Cheat 777", cList);

            using (TcpClient socket = new TcpClient("localhost", 10002))

            using (NetworkStream ns = socket.GetStream())

            using (StreamReader sr = new StreamReader(ns))
            using (StreamWriter sw = new StreamWriter(ns))

            {
                String jsonString = JsonConvert.SerializeObject(sale);

                sw.WriteLine(jsonString);
                sw.Flush();
            }
        }
    }
}
