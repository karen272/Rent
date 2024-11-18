using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquileres.Models.Rentable
{
    public class Tool : Item
    {
        private int idTool;
        private string type;

        public Tool() { }
        public Tool(int idTool, string type)
        {
            this.idTool = idTool;
            this.type = type;
        }

        public int IdTool
        {
            get { return idTool; }
            set { idTool = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }


        public override decimal CalculateRentalPrice(int days)
        {
            return BasePrice * days;
        }
    }
}
