using Alquileres.Models;
using Alquileres.Services.Interfaces;
using Alquileres.Services.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquileres.Factorys
{
    public class PriceStrategyFactory
    {
        public static IPriceStrategy GetStrategy(string itemType)
        {
            switch (itemType)
            {
                case "Vehicle":
                    return new VehiclePriceStrategy();
                case "Appliance":
                    return new AppliancePriceStrategy();
                case "Tool":
                    return new ToolPriceStrategy();
                case "Machinery":
                    return new MachineryPriceStrategy();
                case "Costume":
                    return new CostumePriceStrategy();
                default:
                    throw new ArgumentException("Unsupported type");
            }
        }
        
    }
}
