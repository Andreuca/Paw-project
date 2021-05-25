using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supply_Business.models
{
    [Serializable]
    public class Supplier : ICloneable, IComparable<Supplier>
    {
        private string name;
        private string surname;
        
        private string email;
        private int phone;

        public Supplier(string name, string surname, string email, int phone)
        {
            this.Name = name;
            this.Surname = surname;
           
            this.Email = email;
            this.Phone = phone;
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
       
        public string Email { get => email; set => email = value; }
        public int Phone { get => phone; set => phone = value; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(Supplier supplier)
        {
            return this.name.CompareTo(supplier.name);
        }
    }
}
