using System;
using System.IO;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter file = new StreamWriter("Reg1.txt", true);

            string nm = "", fn = "";
            int ag = 0, cd = 0;

            Console.WriteLine("------Ingrese la cedula");
            ag = int.Parse(Console.ReadLine());
            Console.WriteLine("------Ingrese la nombre");
            nm = Console.ReadLine();
            Console.WriteLine("------Ingrese la apellido");
            fn = Console.ReadLine();
            Console.WriteLine("------Ingrese la edad");
            cd = int.Parse(Console.ReadLine());
            file.Write(ag);
            file.Write(nm);
            file.Write(fn);
            file.Write(cd);
            file.Close();


        }
    }
}
