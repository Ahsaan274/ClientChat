using ClientChat.Procedures;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ClientChat.Tabs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            fillData();
        }

        public void getProcData()
        {
            List<Procedure1> proc = new List<Procedure1>();
            proc.Add(new Procedure1 { name = "", type = "", direction = "", value = "", length = 1 }) ;
        }
        public void fillData()
        {
            // Open the connection
           /* OracleConnection connection = new OracleConnection("Server=@192.168.10.100; User Id=tapp; Password = 101171;");
            connection.Open();

            // Create a command
            OracleCommand command = new OracleCommand();
            command.Connection = connection;

            // Set the CommandType property to execute 
            // stored procedures or functions by this command
            command.CommandType = System.Data.CommandType.StoredProcedure;

            // Set the name of procedure or function to be executed
            command.CommandText = "userstable";*/

        }

    }
}