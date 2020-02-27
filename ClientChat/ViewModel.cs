using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ClientChat
{
    class ViewModel
    {
        public ObservableCollection<OrderInfo> OrdersInfo { get; set; }

        public ViewModel()
        {
            this.OrdersInfo = new ObservableCollection<OrderInfo>();
            GenerateOrders();
        }
        private void GenerateOrders()
        {
            OrdersInfo.Add(new OrderInfo(1, "E1", "Ehsan", "Sukkur", "Pakistan"));
            OrdersInfo.Add(new OrderInfo(2, "E2", "khurram", "Karachi", "Thiland"));
            OrdersInfo.Add(new OrderInfo(3, "E8", "Mutahhar", "Karachi", "Turkey"));
            OrdersInfo.Add(new OrderInfo(4, "E4", "Abdul Basit", "karachi", "Pakistan"));
            OrdersInfo.Add(new OrderInfo(5, "E5", "Shabbir", "Hyderabad", "Pakistan"));
            OrdersInfo.Add(new OrderInfo(6, "E6", "Ehsan", "Sukkur", "Pakistan"));
            OrdersInfo.Add(new OrderInfo(7, "E2", "khurram", "Karachi", "Thiland"));
            OrdersInfo.Add(new OrderInfo(8, "E8", "Mutahhar", "Karachi", "Turkey"));
            OrdersInfo.Add(new OrderInfo(9, "E9", "Abdul Basit", "karachi", "Pakistan"));
            OrdersInfo.Add(new OrderInfo(10, "E10", "Shabbir", "Hyderabad", "Pakistan"));
        }
    }
}
