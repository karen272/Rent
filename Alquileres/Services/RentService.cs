using Alquileres.Factorys;
using Alquileres.Models;
using Alquileres.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquileres.Services
{
    internal class RentService
    {
        private readonly List<Rent> _rents;
        public RentService()
        {
            _rents = new List<Rent>();
        }

        public void AddRent(User user, string itemType, string name, string description, decimal basePrice, int days, IPriceStrategy strategy)
        {
            var item = ItemFactory.CreateItem(itemType, name, description, basePrice);
            item.PriceStrategy = strategy;
            var priceTotal = strategy.CalculatePrice(basePrice, days);

            var rent = new Rent(item, days, priceTotal, user, itemType);
            _rents.Add(rent);
        }
        public void DeleteRent(Rent rent)
        {
            _rents.Remove(rent);
        }

        public List<Rent> GetAllRents()
        {
            return _rents;
        }

        internal void UpdateRent(Rent rent)
        {
            _rents.Remove(rent);
            _rents.Add(rent);
        }
    }
}
