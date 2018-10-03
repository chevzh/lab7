using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    class Cactus: Flower
    {
        public bool CanEat { get; set; }

        public Cactus(string name = "Cactus", string color = "Green", int price = 0, bool canEat= false):base(name,color,price)
        {
            CanEat = CanEat;
        }


        public override string ToString()
        {
            return String.Format("{0}\nСъедобен: {1}", base.ToString(), CanEat);
        }


    }
    
}
