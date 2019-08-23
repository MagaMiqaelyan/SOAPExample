using System;
using System.ServiceModel;
using Services;


namespace WebService
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(MyService));
            host.AddServiceEndpoint(typeof(IContract), new BasicHttpBinding(), "Soap");
            host.Open();
            Console.WriteLine("Service started");
            Console.ReadKey();
            host.Close();
        }
    }
}
