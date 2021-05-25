using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supply_Business.models
{
    [Serializable]public class Contract : ICloneable, IComparable<Contract>
    {
         private string name;
        private string good;
        private int payment;

        public Contract(string name, string good, int payment)
        {
            this.Name = name;
            this.Good = good;
            this.Payment = payment;
        }

        public string Name { get => name; set => name = value; }
        public string Good { get => good; set => good = value; }
        public int Payment { get => payment; set => payment = value; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(Contract contract)
        {
            return this.name.CompareTo(contract.name);
        }
    }

}

