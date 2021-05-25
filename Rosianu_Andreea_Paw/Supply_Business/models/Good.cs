using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supply_Business.models
{

    [Serializable]public class Good:ICloneable, IComparable<Good>
    {
        private string name;
        private int id;
        private int subtotal;
        private int quan;
        private int goodQuantity;
        private int v;

        public Good(int goodQuantity, int v)
        {
            this.goodQuantity = goodQuantity;
            this.v = v;
        }

        public Good(string name, int id, int subtotal, int quan)
        {
            this.Name = name;
            this.Id = id;
            this.Subtotal = subtotal;
            this.Quan = quan;
        }

        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }
        public int Subtotal { get => subtotal; set => subtotal = value; }
        public int Quan { get => quan; set => quan = value; }

        public override string ToString()
        {
            return "Name " +Name+ " ID " +Id+ " Subtotal "+subtotal+ " Quantity " +quan;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public int CompareTo(Good good)
        {
            return this.id.CompareTo(good.id);
        }

    }
}
