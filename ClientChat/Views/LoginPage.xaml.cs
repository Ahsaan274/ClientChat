using ClientChat.Tabs;
using Newtonsoft.Json;
using Syncfusion.SfDataGrid.XForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ClientChat.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public DataTable dt;
        MainPage mp = new MainPage();
        public LoginPage()
        {
            InitializeComponent();

            Models.TCPCommunication.ConnectToServer(mp.macAddress());

            //myImage.Source = ImageSource.FromResource("ClientChat.Images.logo.jpg");

            string email = Email.Text;
            string password = Password.Text;

            SerializeClass serialData = new SerializeClass { Email = email, Password = password };
            string result = JsonConvert.SerializeObject(serialData);


        }

        public void LoginBtn(object sender, EventArgs e)
        {
            dt = Models.TCPCommunication.GetData("GET::select * from users where userid = '" + Email.Text + "'");
            
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["password"].ToString() == Password.Text)
                {
                    DisplayAlert("You are logged in!", "Welcome  " + Email.Text, "Ok");
                    Application.Current.MainPage = new NavigationPage(new TabbedPage1());
                }
                else
                    DisplayAlert("Error!", "Invalid Credentials", "Ok");
            }
            else
                DisplayAlert("Error!", "User does not exist", "Ok");
        }
    }
    class SerializeClass
    {
        public string Email { get; set; }
        public string Password { get; set; }

    }
}