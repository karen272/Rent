using Alquileres.Models;
using Alquileres.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquileres.Services.Strategy
{
    public class PriceStrategy : IPriceStrategy
    {
        public decimal CalculatePrice(Item item, int days)
        {
            return item.BasePrice * days;
        }
    }
}
