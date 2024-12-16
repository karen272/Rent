using Alquileres.Services.Interfaces;
using Alquileres.Services.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquileres.Models
{
    public abstract class Item
    {
        private int idItem;
        private string name;
        private decimal basePrice;
        private string description;
        private IPriceStrategy priceStrategy;

        public Item() { }

        public Item(int idItem,string name, decimal basePrice,string description, IPriceStrategy priceStrategy)
        {
            this.idItem = idItem;
            this.name = name;
            this.basePrice = basePrice;
            this.description = description;
            this.priceStrategy = priceStrategy;
        }

        public int IdItem
        {
            get { return idItem; }
            set { idItem = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public decimal BasePrice
        {
            get { return basePrice; }
            set { basePrice = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public IPriceStrategy PriceStrategy
        {
            get { return priceStrategy; }
            set { priceStrategy = value; }
        }



    }
}
