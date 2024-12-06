using Alquileres.Factorys;
using Alquileres.Models;
using Alquileres.Services;
using Alquileres.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquileres.Controllers
{
    public class RentController
    {

        public RentController()
        {

        }

        public decimal RentItem(User user, string itemType, string name, string description, decimal basePrice, int days, IPriceStrategy strategy)
        {
            var item = ItemFactory.CreateItem(itemType, name, description, basePrice);
            item.PriceStrategy = strategy;
            var priceTotal = strategy.CalculatePrice(basePrice, days);

            var rental = new Rent(item, days, priceTotal);
            user.Rents.Add(rental);
            return priceTotal;
        }
    }
}
