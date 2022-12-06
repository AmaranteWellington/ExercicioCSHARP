using System;
using System.Collections.Generic;
using Course.Entities;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret = new Retangulo();
            

            Console.WriteLine("Entre com a Largura e a Altura do Retangulo: ");
            ret.Largura = double.Parse(Console.ReadLine());
            ret.Altura = double.Parse(Console.ReadLine());



            Console.WriteLine("AREA: " + ret.Area());
            Console.WriteLine("PERIMETRO: " + ret.Perimetro());
            Console.WriteLine("DIAGONAL: " + ret.Diagonal());












        }
    }
}
