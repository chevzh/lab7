using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    abstract class Flower : IPlant, IComparable<Flower>
    {

        public virtual void Grow()
        {
            Console.WriteLine("Fotosinteziruyu tak skozat'");
        }
        
        public string Color { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }


        public Flower(string name = "", string color = "", int price = 0)
        {
            Name = name;
            Color = color;
            Price = price;
            if (price < 0) throw new NegativePriceException("Цена не может быть отрицательной");
        }

        public override string ToString()
        {
            return String.Format("Тип объекта: {0}\nИмя: {1}\nЦвет: {2}\nЦена: {3}", base.ToString(), Name, Color,Price);
        }

        public virtual void Bloom()
        {
            Console.WriteLine("Bloom");
        }

        public int CompareTo(Flower other)
        {
            Flower f = other as Flower;
            if (f != null)
                return this.Name.CompareTo(f.Name);
            else
                throw new Exception("Невозможно сравнить два объекта");
        }
    }
}
