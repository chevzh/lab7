using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace lab7
{
    class Printer
    {
        
        public static void IsObjectOfClass(object obj, Type type)
        {
            Debug.Assert(obj != null, "Объект возвращает null");
            try
            {
                if (obj.GetType() == type)
                {
                    Console.WriteLine("Тип объекта совпадает с указанным");
                }
                else
                {
                    Console.WriteLine("Тип объекта не совпадает с указанным. Тип объекта:" + obj.GetType());
                }
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

       

        public static void Print(object obj)
        {

            IPlant plant = obj as IPlant;
            if(plant as IPlant != null)
            {
                Console.WriteLine("---------------");
                Console.WriteLine(plant.ToString());
            }
            else
            {
                throw new InvalidPlantException("Невозможно привести объект " + obj.ToString() + " к типу Iplant");
                //Console.WriteLine("---------------Print for " + obj.GetType() + "---------------");
                //Console.WriteLine(obj.ToString());
            }
            
        }

    }
}
