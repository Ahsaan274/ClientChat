using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ClientChat.Tabs
{
    public partial class Page2 : ContentPage
    {
        public Page2()
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