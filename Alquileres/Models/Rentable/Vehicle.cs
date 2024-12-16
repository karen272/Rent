using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquileres.Models.Rentable
{
    public class Vehicle : Item
    {
        private int idVehicle;
        private string type;
        public Vehicle() { }
        public Vehicle(int idVehicle,string type) 
        {
            this.idVehicle = idVehicle;
            this.type = type;
        }

        public int IdVehicle
        {
            get { return idVehicle; }
            set { idVehicle = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }


    }
}
