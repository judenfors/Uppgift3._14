using System;

namespace Uppgift3._14
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Har du gått ut gymnasiet? Svara j för ja och n för nej");
            string rättsvar =Console.ReadLine();

            Console.WriteLine("Hur gammal är du?");
            int ålder = int.Parse(Console.ReadLine());


            
            if(ålder <= 22 & rättsvar=="j")
            {
                Console.WriteLine("Vi vill anställa dig");

            }
            else{
                Console.WriteLine("Vi vill inte anställa dig");
            }
        }
    }
}

