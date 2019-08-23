using System;
using MyClient.ServiceReferenceHTTP;

namespace MyClient
{
    class Program
    {
        static void Main(string[] args)
        {            
            string greeting = Console.ReadLine();
            ContractClient contract = new ContractClient();
            Console.WriteLine(contract.GetMessage(greeting));
        }
    }
}
