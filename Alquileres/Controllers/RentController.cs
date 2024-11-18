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
        private readonly RentService _rentService;

        public RentController()
        {
            _rentService = new RentService();
        }

        public decimal RentItem(User user, string itemType, string name, string description, decimal basePrice, int days, IPriceStrategy strategy)
        {
            var item = ItemFactory.CreateItem(itemType, name, description, basePrice);
            item.PriceStrategy = strategy;

            decimal total = _rentService.CalculateTotalRental(item, days);
            var rental = new Rent(item, days, total);
            user.Rents.Add(rental);
            return total;
        }
    }
}
