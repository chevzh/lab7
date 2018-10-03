using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    sealed class Bush : Bouqet
    {
        
        public Bush(IEnumerable<Flower> flowers):base(flowers)
        {
           
        }

        public Bush() : base()
        {

        }

        public override void Add(Flower flower)
        {
            if (_flowers.Any())
            {
                if (_flowers.Last().GetType() == flower.GetType())
                {
                    _flowers.Add(flower);
                }
            }
            else
            {
                _flowers.Add(flower);
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
