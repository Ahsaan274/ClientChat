using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ClientChat
{
    class OrderInfo : INotifyPropertyChanged
    {
        private int orderID;
        private string customerID;
        private string customerName;
        private string shipCity;
        private string shipCountry;

        public OrderInfo(int orderID, string customerID, string customerName, string shipCity, string shipCountry)
        {
            this.orderID = orderID;
            this.customerID = customerID;
            this.customerName = customerName;
            this.shipCity = shipCity;
            this.shipCountry = shipCountry;
        }
        public int OrderID
        {
            get { return orderID; }
            set
            {
                this.orderID = value;
                RaisePropertyChnaged("orderID");
            }
        }
        public string CustomerID
        {

            get { return customerID; }
            set
            {
                this.customerID = value;
                RaisePropertyChnaged("customerID");
            }
        }
        public string CustomerName
        {

            get { return customerName; }
            set
            {
                this.customerName = value;
                RaisePropertyChnaged("customerName");
            }
        }
        public string ShipCity
        {

            get { return shipCity; }
            set
            {
                this.shipCity = value;
                RaisePropertyChnaged("shipCity");
            }
        }
        public string ShipCountry
        {

            get { return shipCountry; }
            set
            {
                this.shipCountry = value;
                RaisePropertyChnaged("shipCountry");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChnaged(string name)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}
