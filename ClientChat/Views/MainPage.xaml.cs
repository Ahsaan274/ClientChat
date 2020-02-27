using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ClientChat
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    partial class MainPage : ContentPage
    {
        System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();
        NetworkStream serverStream = default(NetworkStream);
        string readData = null;

        public MainPage()
        {
            InitializeComponent();
          //  ConnectToServer(macAddress());
           
        }

        private void sendData(string message)
        {
            byte[] outStream = System.Text.Encoding.ASCII.GetBytes(message + "$");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();


        }
        private void ConnectToServer(string clientName)
        {

            readData = "Conected to Chat Server ...";
            //msg();
            clientSocket.Connect("59.103.166.184", 5000);
            serverStream = clientSocket.GetStream();

            byte[] outStream = System.Text.Encoding.ASCII.GetBytes(clientName + "$");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();

            Thread ctThread = new Thread(getMessage);
            ctThread.Start();
        }
        private void getMessage()
        {
            while (true)
            {
                serverStream = clientSocket.GetStream();
                int buffSize = 0;
                byte[] inStream = new byte[1024];
                buffSize = clientSocket.ReceiveBufferSize;
                while ((buffSize = serverStream.Read(inStream, 0, inStream.Length)) > 0)
                {
                    Device.BeginInvokeOnMainThread(() =>
                    {
                        allData.Text += System.Text.Encoding.ASCII.GetString(inStream, 0, buffSize) + "\n";
                    });

                }
            }
        }
        private async void msg()
        {
            await Task.Run(() =>
            {


            });

        }

        private void btnServer_Clicked(object sender, EventArgs e)
        {
            ConnectToServer(macAddress());

        }
        public string macAddress()
        {
            var ni = NetworkInterface.GetAllNetworkInterfaces().OrderBy(intf => intf.NetworkInterfaceType)
              .FirstOrDefault(intf => intf.OperationalStatus == OperationalStatus.Up
             && (intf.NetworkInterfaceType == NetworkInterfaceType.Wireless80211
                 || intf.NetworkInterfaceType == NetworkInterfaceType.Ethernet));

            var hw = ni.GetPhysicalAddress();
            return string.Join(":", (from ma in hw.GetAddressBytes() select ma.ToString("X2")).ToArray());
        }

        private void btnSend_Clicked(object sender, EventArgs e)
        {
            object a = this.FindByName<Entry>("usernameEntry1");
            sendData("" + (a as Entry).Text);
            (a as Entry).Text = "";
        }
    }
}
