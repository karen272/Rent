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
        private User user;
        private string itemType;
        public Rent() { }
        public Rent(Item item, int days, decimal totalCost, User user, string itemType)
        {
            this.item = item;
            this.days = days;
            this.totalCost = totalCost;
            this.user = user;
            this.itemType = itemType;
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
        public User User
        {
            get { return user; }
            set { user = value; }
        }
        public string ItemType
        {
            get { return itemType; }
            set { itemType = value; }
        }
        public override string ToString()
        {
            return "Nombre:" + user.Name + "Precio:" + totalCost;
        }
    }
}
