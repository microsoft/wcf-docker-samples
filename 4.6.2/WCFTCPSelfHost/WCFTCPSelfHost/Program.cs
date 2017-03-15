using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Description;
using WcfServiceLibrary1;
using System.Threading;

namespace WCFSelfHostTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the ServiceHost.
            using (ServiceHost host = new ServiceHost(typeof(Service1)))
            {

                // Open the ServiceHost to start listening for messages. Since
                // no endpoints are explicitly configured, the runtime will create
                // one endpoint per base address for each service contract implemented
                // by the service.
                host.Open();

                Console.WriteLine("The service is ready at {0}", host.BaseAddresses[0]);

                Console.WriteLine("Press <Enter> to stop the service.");
                Console.ReadLine();

                // Close the ServiceHost.
                host.Close();
            }
        }
    }
}
