using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Alquileres.Models
{
    public class Rent
    {
        private Item item;
        private int days;
        private decimal totalCost;
        public Rent() { }
        public Rent(Item item, int days, decimal totalCost)
        {
            this.item = item;
            this.days = days;
            this.totalCost = totalCost;
        }
        public Item Item
        {
            get { return item; }
            set { item = value; }
        }
        public int Days
        {
            get { return days; }
            set { days = value; }
        }
        public decimal TotalCost
        {
            get { return totalCost; }
            set { totalCost = value; }
        }
    }
}
