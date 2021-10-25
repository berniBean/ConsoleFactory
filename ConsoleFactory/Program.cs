using Civiles.ConcreteCreator;
using Civiles.Creator;
using Civiles.Product;
using Comportamientos;
using Factory.ConcreteCreator;
using Factory.Creator;
using Factory.Product;
using Patos;
using Singleton;
using System;

namespace ConsoleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ChocoPdfs item = new ChocoPdfs("Gato", "Feliz");
            

            ChocolateBoiler.getInstance().addPdf(item);

            foreach (var it in ChocolateBoiler.getInstance().readPdf())
            {
                Console.WriteLine(it._name);
            }




        }
    }
}
