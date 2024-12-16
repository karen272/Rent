using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquileres.Models.Rentable
{
    public class Costume : Item
    {
        private int idCostume;
        private string type;

        public Costume() { }
        public Costume(int idCostume, string type)
        {
            this.idCostume = idCostume;
            this.type = type;
        }

        public int IdCostume
        {
            get { return idCostume; }
            set { idCostume = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }


    }
}
