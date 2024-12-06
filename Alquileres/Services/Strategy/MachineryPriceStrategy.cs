using Alquileres.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquileres.Services.Strategy
{
    internal class MachineryPriceStrategy : IPriceStrategy
    {
        public decimal CalculatePrice(decimal basePrice, int days)
        {
            return basePrice * days;
        }
    }
}
