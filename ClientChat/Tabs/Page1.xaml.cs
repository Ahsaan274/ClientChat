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

        public void fillData()
        {
            List<Procedure1> proc = new List<Procedure1>();
            proc.Add(new Procedure1 { name = "retValue", type = "sys_refcursor", direction = "OUT", value = "", length = 0 });
            gridData.ItemsSource = Models.TCPCommunication.GetDataProc("userstable", proc);
        }
    }
}