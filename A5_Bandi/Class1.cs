using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace A5_Bandi
{
    internal class EventPlanner
    {
        private string item;
        private double price;
        private int quantity;
        
        public EventPlanner(string item, double price, int quantity)
        {
            this.item = item;
            this.price = price;
            this.quantity = quantity;
        }
        public String Item
        {
            get
            {
                return item;
            }

            set
            {
                if (value != "")
                {
                    item = value;
                }
            }
        }

        public double Price
        {
            get
            {
                return price;
            }

            set
            {
                if (value > 0)
                {
                    price = value;
                }
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                if (value > 0)
                {
                    quantity = value;
                }
            }
        }
        public String DisplayString
        {
            get
            {
                return item;
            }
        }
    }
}
