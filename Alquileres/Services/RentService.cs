using Alquileres.Models;
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
        public void AddRent(Rent rent)
        {
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
