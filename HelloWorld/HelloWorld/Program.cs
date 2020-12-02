using System;

namespace HelloWorld
{
    //PascalCase -> stosowany do nazewnicta klas, nazw plików, nazw namespace oraz nazw metod/funkcji
    public class Program
    {
        public static void Main(string[] args)
        {
            //camelCase -> stosowany do nazewnictwa lokalnych oraz prywatnych zmiennych
            string myName = "Michał";

            //UPPER_CASE -> stosowany do nazewnictwa stałych

            const double PI_NUMBER = 3.14;

            Console.WriteLine("Hello World!");
            Console.WriteLine("Mam na imię" + myName);
        }
    }
}
