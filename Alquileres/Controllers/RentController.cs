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

        public void RentItem(User user, string itemType, string name, string description, decimal basePrice, int days, IPriceStrategy strategy)
        {
            _rentService.AddRent(user, itemType, name, description, basePrice, days, strategy);
        }

        public void DeleteRentItem(Rent rent)
        {
            _rentService.DeleteRent(rent);
        }
        public List<Rent> GetAllRents()
        {
            return _rentService.GetAllRents();
        }

        internal void UpdateRent(User user, string itemType, string name, string description, decimal basePrice, int days, IPriceStrategy strategy)
        {
            _rentService.AddRent(user, itemType, name, description, basePrice, days, strategy);
        }
    }
}
