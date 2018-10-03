using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    class Gladiolus : Flower
    {     
        
        public Gladiolus(string name = "Gladiolus", string color = "Yellow") : base(name, color)
        {
            
        }
        
        public override void Grow()
        {
            Console.WriteLine("Расту как цветок так скозатб");
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override void Bloom()
        {
            Console.WriteLine("Gladiolus is blooming");
        }
    }
}
