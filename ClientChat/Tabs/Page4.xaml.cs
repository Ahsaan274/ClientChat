﻿using Syncfusion.SfDataGrid.XForms;
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
    public partial class Page4 : ContentPage
    {
        public Page4()
        {
            InitializeComponent();
            fillData();

        }
        protected override void OnAppearing()
        {
           /* base.OnAppearing();
            gridData.Columns.Add(new GridTextColumn()
            {
                MappingName = "USERID",
                HeaderCellTextSize = 14,
                FontAttribute = FontAttributes.Bold,
                CellTextSize = 16,
            });

            gridData.Columns.Add(new GridTextColumn()
            {
                MappingName = "USERNAME",
                HeaderCellTextSize = 14,
                FontAttribute = FontAttributes.Bold,
                CellTextSize = 16,


            });*/
        }
        public void fillData()
        {
        }
    }
}
