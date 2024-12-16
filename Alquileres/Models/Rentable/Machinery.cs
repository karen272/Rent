using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquileres.Models.Rentable
{
    public class Machinery : Item
    {
        private int idMachinery;
        private string type;

        public Machinery() { }
        public Machinery(int idMachinery, string type)
        {
            this.idMachinery = idMachinery;
            this.type = type;
        }

        public int IdMachinery
        {
            get { return idMachinery; }
            set { idMachinery = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }


    }
}
