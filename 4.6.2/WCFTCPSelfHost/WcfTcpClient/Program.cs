using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WcfTcpClient.ServiceReference1;

namespace WcfTcpClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client wcfClient = new Service1Client();
            string retstr = wcfClient.GetData(456);
            Console.WriteLine("GetData returns: " + retstr);
            CompositeType obj = new CompositeType();
            obj.BoolValue = true;
            obj.StringValue = "Hello WCF TCP client!";
            CompositeType objret = wcfClient.GetDataUsingDataContract(obj);
            Console.WriteLine("GetDataUsingDataContract returns: " + objret.StringValue);
            Console.ReadLine();
            wcfClient.Close();
        }
    }
}