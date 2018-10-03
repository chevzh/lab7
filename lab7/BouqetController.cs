using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    class BouqetController
    {
        Bouqet _bouqet;

        public BouqetController(Bouqet bouqet)
        {
            _bouqet = bouqet;
        }
                
        public enum Comand
        {
            FindByColor,
            SortByParam
        }

        public Bouqet ExecuteCommand(Comand command, string param)
        {
            Bouqet b = new Bouqet();

            switch (command)
            {
                case Comand.FindByColor:
                    b = FindByColor(param);
                    return b;

                case Comand.SortByParam:
                    SortByName();
                    break;
            }

            return b;
        }

        public Bouqet FindByColor(string color)
        {
            Bouqet b = new Bouqet();
            if (!_bouqet.Any())
            {
                throw new EmptyBouqetException("Букет пуст");
            }

            foreach (var flower in _bouqet)
            {
                if(flower.Color == color)
                {
                    b.Add(flower);
                }
            }
            return b;
        }

        public void SortByName()
        {
            _bouqet.Sort();
        }

        public int TotalPrice()
        {
            int price = new int();
            foreach(var flower in _bouqet)
            {
                price += flower.Price;                
            }

            return price;
        }

    }
}
