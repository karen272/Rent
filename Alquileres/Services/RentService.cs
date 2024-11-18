using Alquileres.Models;
using Alquileres.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquileres.Services
{
    public class RentService
    {
        public decimal CalculateTotalRental(Item item, int days)
        {
            return item.CalculateRentalPrice(days);
        }
    }
}
