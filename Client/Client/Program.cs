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
            try
            {
                EndpointAddress address = new EndpointAddress(BaseAddress + "/BSHTTP");
                BasicHttpBinding binding = new BasicHttpBinding();
                MyService.BServiceClient Proxy = new MyService.BServiceClient(binding, address);
                Console.WriteLine("BASIC HTTP CONNECTION");
                Console.WriteLine(Proxy.LogIn());
            }
            catch { }
        }
        public static void TestWSHTTP(string BaseAddress)
        {
            try
            {
                EndpointAddress address = new EndpointAddress(BaseAddress + "/WSHTTP");
                WSHttpBinding binding = new WSHttpBinding();
                MyService.BServiceClient Proxy = new MyService.BServiceClient(binding, address);
                Console.WriteLine("WSHTTP CONNECTION");
                Console.WriteLine(Proxy.LogIn());
            }
            catch { }
        }
        public static void TestTCPNET()
        {
            try
            {
                EndpointAddress address = new EndpointAddress("net.tcp://localhost:9000/TCPNET");
                NetTcpBinding binding = new NetTcpBinding();
                MyService.BServiceClient Proxy = new MyService.BServiceClient(binding, address);

                Console.WriteLine("TCPNET CONNECTION");
                Console.WriteLine(Proxy.LogIn());
            }
            catch { }
        }
        public static void CallBackFunction(Object sender, MyService.LogInCompletedEventArgs e)
        {
            Console.WriteLine("SUCCESSFULL IN ASYNCHRONOUS TESTING");
        }
        public static void TestAsynchronous(string BaseAddress)
        {
            try
            {
                EndpointAddress address = new EndpointAddress(BaseAddress + "/WSHTTP");
                NetTcpBinding binding = new NetTcpBinding();
                MyService.BServiceClient Proxy = new MyService.BServiceClient(binding, address);
                Proxy.LogInCompleted += new EventHandler<MyService.LogInCompletedEventArgs>(CallBackFunction);
                Proxy.LogInAsync();
            }
            catch { }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                string BaseAddress = "";
                Console.WriteLine("Enter type address to test");
                BaseAddress = Console.ReadLine();
                Console.WriteLine("Base Address is   " + BaseAddress);
                TestHTTP(BaseAddress);
                TestWSHTTP(BaseAddress);
                TestTCPNET();
                TestAsynchronous(BaseAddress);
                Console.ReadLine();
            }
        }
    }
}
