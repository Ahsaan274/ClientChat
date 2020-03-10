using Syncfusion.SfDataGrid.XForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace ClientChat.Tabs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    /*public class SfImageView : Xamarin.Forms.Image, Xamarin.Forms.IAnimatable, Xamarin.Forms.IElementConfiguration<Image>, Xamarin.Forms.IElementController, Xamarin.Forms.IImageController, Xamarin.Forms.Internals.IGestureController, Xamarin.Forms.IViewController, Xamarin.Forms.IVisualElementController
    {

    }*/
    public partial class Page3 : ContentPage
    {
        [Obsolete]
        public Page3()
        {
            InitializeComponent();
            //fillData();
        }


        [Obsolete]
        public void fillData()
        {
          //  DataTable dt = Models.TCPCommunication.GetData("GET::select * from attendance");
           /* gridData.Columns.Add(new GridSwitchColumn()
            {
                MappingName = "User Image",
                DisplayBinding = { Binding DealerImage, Converter = { StaticResource imageConverter } },

            });*/
           /* gridData.Columns.Add(new GridTextColumn()
            {
                MappingName = "OrderID",
                HeaderCellTextSize = 14,
                FontAttribute = FontAttributes.Bold,
                CellTextSize = 16,

            });
            gridData.Columns.Add(new GridTextColumn()
            {
                MappingName = "CustomerID",
                HeaderCellTextSize = 14,
                FontAttribute = FontAttributes.Bold,
                CellTextSize = 18

            });
            gridData.Columns.Add(new GridTextColumn()
            {
                TextWrapping = LineBreakMode.WordWrap,
                MappingName = "CustomerName",
                HeaderCellTextSize = 14,
                FontAttribute = FontAttributes.Bold,
                CellTextSize = 20
            });*/
        }
    }
    public class ImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            if (value != null)
            {
                return ImageSource.FromResource("ClientChat.dna.png");
            }
            else
                return "";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}