using ClientChat.Procedures;
using ClientChat.Views;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using Xamarin.Forms;

namespace ClientChat.Models
{
    public static class TCPCommunication
    {
        public static List<string> listGetData = new List<string>();
        static string readData = null;
        static System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();
        static NetworkStream serverStream = default(NetworkStream);
        public static void ConnectToServer(string clientName)
        {

            readData = "Conected to Chat Server ...";
            //msg();
            clientSocket.Connect("192.168.10.7", 5000);
            serverStream = clientSocket.GetStream();

            byte[] outStream = System.Text.Encoding.ASCII.GetBytes(clientName + "$");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();
            buffSize = clientSocket.ReceiveBufferSize;
            serverStream.Read(inStream, 0, inStream.Length);

            string Val = System.Text.Encoding.ASCII.GetString(inStream, 0, buffSize);
        }

        static int buffSize = 0;
        static byte[] inStream = new byte[1048576000];


        public static DataTable GetData(string sql)
        {
            sendData(sql);
           serverStream.Read(inStream, 0, inStream.Length);

            string Val = System.Text.Encoding.ASCII.GetString(inStream, 0, buffSize);

            Val = Val.Substring(0, Val.IndexOf('&'));       
            DataTable dt = (DataTable)JsonConvert.DeserializeObject(Val, (typeof(DataTable)));

            return dt;
        }
        public static DataTable GetDataProc(string procedureName,List<Procedure1> lst)
        {
            string a = JsonConvert.SerializeObject(lst);
            String sql = "GETPROC::"+ procedureName+"|"+a;
            sendData(sql);
            serverStream.Read(inStream, 0, inStream.Length);

            string Val = System.Text.Encoding.ASCII.GetString(inStream, 0, buffSize);

            Val = Val.Substring(0, Val.IndexOf('&'));
            DataTable dt = (DataTable)JsonConvert.DeserializeObject(Val, (typeof(DataTable)));
            return dt;
        }
        public static void sendData(string message)
        {
            byte[] outStream = System.Text.Encoding.ASCII.GetBytes(message + "$");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();
        }
        
    }
    
    internal class Users
    {
        internal string USERID { get; set; }
        internal string PASSWORD { get; set; }
        internal string USERNAME { get; set; }
    }
}
