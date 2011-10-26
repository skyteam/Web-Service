using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace Client
{
    class Program
    {
        public static void TestHTTP(string BaseAddress)
        {
            EndpointAddress address = new EndpointAddress(BaseAddress + "/BSHTTP");
            BasicHttpBinding binding = new BasicHttpBinding();
            BookService.IService proxy = ChannelFactory<BookService.IService>.CreateChannel(binding, address);
            Console.WriteLine(proxy.LogIn() +" IN BSHTTP CONNECTION");
        }
        public static void TestWSHTTP(string BaseAddress)
        {
            EndpointAddress address = new EndpointAddress(BaseAddress + "/WSHTTP");
            WSHttpBinding binding = new WSHttpBinding();
            BookService.IService proxy = ChannelFactory<BookService.IService>.CreateChannel(binding, address);
            Console.WriteLine(proxy.LogIn() + " IN WSHTTP CONNECTION");
        }
        public static void TestTCPNET()
        {
            EndpointAddress address = new EndpointAddress("net.tcp://localhost:9000/TCPNET");
            NetTcpBinding binding = new NetTcpBinding();
            BookService.IService proxy = ChannelFactory<BookService.IService>.CreateChannel(binding, address);
            Console.WriteLine(proxy.LogIn() + " IN TCPNET CONNECTION");
        }
        static void Main(string[] args)
        {
            while (true)
            {
                string BaseAddress = "";
                Console.WriteLine("Enter type address to test");
                BaseAddress = Console.ReadLine();
                try
                {
                    TestHTTP(BaseAddress);
                }
                catch
                {
                    Console.WriteLine("ERROR IN HTTP CONNECTION!!!\n");
                }

                try
                {
                    TestWSHTTP(BaseAddress);
                }
                catch
                {
                    Console.WriteLine("ERROR IN WSHTTP CONNECTION!!!\n");
                }

                try
                {
                    TestTCPNET();
                }
                catch
                {
                    Console.WriteLine("ERROR IN TCPNET CONNECTION!!!\n");
                }

                Console.WriteLine("FINISHED!!!\n\n");
            }
        }
    }
}
