using Syncfusion.SfDataGrid.XForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Internals;
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

        [Obsolete]
        public void fillData()
        {
            DataTable dt = Models.TCPCommunication.GetData("GET::select * from attendance");
            gridData.Columns.Add(new GridTextColumn()
            {
                MappingName = "OrderID",
                HeaderCellTextSize = 14,
                FontAttribute = FontAttributes.Bold,
                CellTextSize = 16,
                
            }) ;
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
            });
            
        }

        private void gridData_GridDoubleTapped(object sender, Syncfusion.SfDataGrid.XForms.GridDoubleTappedEventArgs e)
        {
            
            
        }

        private void gridData_GridDoubleTapped_1(object sender, Syncfusion.SfDataGrid.XForms.GridDoubleTappedEventArgs e)
        {
            if (gridData.ScaleX == 2 || gridData.ScaleY == 2)
            {
                gridData.ScaleX = 1;
                gridData.ScaleY = 1;
            }
            else
            {
                gridData.ScaleX = 2;
                gridData.ScaleY = 2;
            }
        }
    }
    public class PinchToZoomContainer : ContentView
    {
        double startScale = 0;
        double currentScale = 0;
        double xOffset = 0;
        double yOffset = 0;

        public PinchToZoomContainer()
        {
            var pinchGesture = new PinchGestureRecognizer();
            pinchGesture.PinchUpdated += OnPinchUpdated;
            GestureRecognizers.Add(pinchGesture);
        }

        void OnPinchUpdated(object sender, PinchGestureUpdatedEventArgs e)
        {
            if (e.Status == GestureStatus.Started)
            {
                // Store the current scale factor applied to the wrapped user interface element,
                // and zero the components for the center point of the translate transform.
                startScale = Content.Scale;
                Content.AnchorX = 0;
                Content.AnchorY = 0;
            }
            if (e.Status == GestureStatus.Running)
            {
                // Calculate the scale factor to be applied.
                currentScale += (e.Scale - 1) * startScale;
                currentScale = Math.Max(1, currentScale);

                // The ScaleOrigin is in relative coordinates to the wrapped user interface element,
                // so get the X pixel coordinate.
                double renderedX = Content.X + xOffset;
                double deltaX = renderedX / Width;
                double deltaWidth = Width / (Content.Width * startScale);
                double originX = (e.ScaleOrigin.X - deltaX) * deltaWidth;

                // The ScaleOrigin is in relative coordinates to the wrapped user interface element,
                // so get the Y pixel coordinate.
                double renderedY = Content.Y + yOffset;
                double deltaY = renderedY / Height;
                double deltaHeight = Height / (Content.Height * startScale);
                double originY = (e.ScaleOrigin.Y - deltaY) * deltaHeight;

                // Calculate the transformed element pixel coordinates.
                double targetX = xOffset - (originX * Content.Width) * (currentScale - startScale);
                double targetY = yOffset - (originY * Content.Height) * (currentScale - startScale);

                // Apply translation based on the change in origin.
                Content.TranslationX = targetX.Clamp(-Content.Width * (currentScale - 1), 0);
                Content.TranslationY = targetY.Clamp(-Content.Height * (currentScale - 1), 0);

                // Apply scale factor.
                Content.Scale = currentScale;
            }
            if (e.Status == GestureStatus.Completed)
            {
                // Store the translation delta's of the wrapped user interface element.
                xOffset = Content.TranslationX;
                yOffset = Content.TranslationY;
            }
        }
    }
    /*public class HomePageCS : ContentPage
    {
        public HomePageCS()
        {
            Content = new Grid
            {
                Padding = new Thickness(20),
                Children =
                            {
                    new PinchToZoomContainer
          {
          Content = new Image
          {
              Source = ImageSource.FromFile("log.PNG")
          }
          }
                    }
            };
        }
    }*/
}