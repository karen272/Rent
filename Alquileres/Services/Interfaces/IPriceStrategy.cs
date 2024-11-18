using Alquileres.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquileres.Services.Interfaces
{
    public interface IPriceStrategy
    {
        decimal CalculatePrice(Item item, int days);
    }
}
