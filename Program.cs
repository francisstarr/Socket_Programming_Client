using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LahoreSocketAsync;
namespace UdemyAsyncSocketClient
{
    class Program
    {
        static void Main(string[] args)
        {
            LahoreSocketClient client = new LahoreSocketClient();
            string strIPAddress =MyServer.ipAddr;
            string strPortInput = MyServer.mPort.ToString();
            if (!client.SetServerIPAddress(strIPAddress))
            {
                Console.WriteLine(strIPAddress, "is the wrong IP Address");
            }
            else if (!client.SetPortNumber(strPortInput))
            {
                Console.WriteLine(strPortInput, "is the wrong port number");
                
            }
            else {
                client.ConnectToServer();
                string strInputUser = null;
                do
                {
                    strInputUser = Console.ReadLine();
                    if (!(strInputUser.Trim().Equals("<EXIT>")))
                    {
                        client.SendToServer(strInputUser);
                    }
                    else {
                        client.CloseAndDisconnect();
                    }
                } 
                while (!(strInputUser.Trim().Equals("<EXIT>")));

            }
            






        }
    }
}
