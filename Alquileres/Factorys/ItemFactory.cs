using Alquileres.Models;
using Alquileres.Models.Rentable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquileres.Factorys
{
    public class ItemFactory
    {
        public static Item CreateItem(string type, string name, string description, decimal basePrice)
        {
            switch (type)
            {
                case "Vehicle":
                    return new Vehicle { Name = name, Description = description, BasePrice = basePrice };
                case "Appliance":
                    return new Appliance { Name = name, Description = description, BasePrice = basePrice };
                case "Tool":
                    return new Tool { Name = name, Description = description, BasePrice = basePrice };
                case "Machinery":
                    return new Machinery { Name = name, Description = description, BasePrice = basePrice };
                case "Costume":
                    return new Costume { Name = name, Description = description, BasePrice = basePrice };
                default:
                    throw new ArgumentException("Unsupported type");
            }
        }
    }
}
