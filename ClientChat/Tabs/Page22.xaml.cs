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
    public partial class Page22 : ContentPage
    {
        public Page22()
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