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
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();
            fillData();
        }
        public void fillData()
        {
            DataTable dt = Models.TCPCommunication.GetData("GET::select * from attendance");
            gridData.ItemsSource = dt;
        }
    }
}