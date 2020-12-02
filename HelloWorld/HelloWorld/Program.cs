using System;

namespace HelloWorld
{
    //PascalCase -> stosowany do nazewnicta klas, nazw plików, nazw namespace oraz nazw metod/funkcji / used to name classes, file names, namespaces, methods/functions
    public class Program
    {
        public static void Main(string[] args)
        {
            //camelCase -> stosowany do nazewnictwa lokalnych oraz prywatnych zmiennych / used to name locals and privates variables
            string myName = "Michał";

            //UPPER_CASE -> stosowany do nazewnictwa stałych / used to name constant variables
            const double PI_NUMBER = 3.14;

            Console.WriteLine("Hello World!");
            Console.WriteLine("Mam na imię " + myName);
        }
    }
}
