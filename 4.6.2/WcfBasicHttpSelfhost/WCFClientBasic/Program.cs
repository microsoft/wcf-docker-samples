using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WCFClientBasic.ServiceReference1;

namespace WCFClientTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client wcfClient = new Service1Client();
            string retstr = wcfClient.GetData(123);
            Console.WriteLine("GetData returns: " + retstr);
            CompositeType obj = new CompositeType();
            obj.BoolValue = true;
            obj.StringValue = "Hello WCF client";
            CompositeType objret = wcfClient.GetDataUsingDataContract(obj);
            Console.WriteLine("GetDataUsingDataContract returns: " + objret.StringValue);
            Console.ReadLine();
            wcfClient.Close();
        }
    }
}