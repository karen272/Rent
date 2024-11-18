using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alquileres.Models
{
    public class User
    {
        private int idUser;
        private string name;

        public List<Rent> Rents { get; set; } = new List<Rent>();
        public User() { }

        public User(int idUser, string name)
        {
            this.idUser = idUser;
            this.name = name;
        }

        public int IdUser
        {
            get { return idUser; }
            set { idUser = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public override string ToString()
        {
            return Name; 
        }

    }
}
