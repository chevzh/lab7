using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace lab7
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Bouqet bouqet = new Bouqet();
            BouqetController bc = new BouqetController(bouqet);
            Printer printer = new Printer();
            Cactus cact = null;

            Printer.IsObjectOfClass(cact, typeof(Rose));

            try
            {
                Rose rose = new Rose("", "", -1000);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                bc.FindByColor("Red");
            }

            catch (EmptyBouqetException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Printer.Print(printer);
            }

            catch
            {
                Console.WriteLine("Что-то пошло не так");
            }

            finally
            {
                Console.WriteLine("finally : Выполняюсь так скозать");
            }
        }
    }
}
