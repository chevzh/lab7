using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    struct Paper : IPlant
    {
        public enum Quality
        {
            Best,
            Good,
            Bad,
            Worst
        }
        public string name;
        public string quality;

        public Paper(string n, Quality q)
        {
            name = n;
            quality = q.ToString();
        }

        public void Grow()
        {
            Console.WriteLine("I'm already dead");
        }
        
        public override string ToString()
        {
            return String.Format("I'm fucking dead! Get off!");
        }
    }
    
}
