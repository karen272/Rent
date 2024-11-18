using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquileres.Models.Rentable
{
    internal class Appliance : Item
    {
        private int idAppliance;
        private string category;

        public Appliance() { }
        public Appliance(int idAppliance, string category)
        {
            this.idAppliance = idAppliance;
            this.category = category;
        }

        public int IdAppliance
        {
            get { return idAppliance; }
            set { idAppliance = value; }
        }

        public string Category
        {
            get { return category; }
            set { category = value; }
        }


        public override decimal CalculateRentalPrice(int days)
        {
            return BasePrice * days;
        }
    }
}
