using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayers
{
    class BillingSystem : Client
    {
        private double price;
        private double discount;

        public BillingSystem()
        {

        }

        public BillingSystem(double price, double discount)
        {
            this.Price = price;
            this.Discount = discount;
        }

        public double Price { get => price; set => price = value; }
        public double Discount { get => discount; set => discount = value; }

        List<BillingSystem> billingSystemslist = new List<BillingSystem>();

        public List<BillingSystem> CalPrice(int ProductID)
        {
            double price;
            double discount;
            if (ProductID==1)
            {
                price = 123.23;
                discount = 0.43;
            }
            else if (ProductID==2)
            {
                price = 413.34;
                discount = 0.60;
            }
            else
            {
                price = 743.50;
                discount = 0.70;
            }
            billingSystemslist.Add(new BillingSystem(price, discount));
            return billingSystemslist;
        }
    }
}
