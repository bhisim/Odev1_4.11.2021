using System;

//Bahar Merdamert Sayıların Pozitif,Negatif Ya da Sıfıra Eşit Olduğunu Gösteren Uygulama

namespace SayılarPozitifNegatif
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Bir sayi giriniz");
            int sayi = int.Parse(Console.ReadLine());
            

            if(sayi>0)
            { 
                Console.WriteLine("Pozitif bir sayi girdiniz"); 
            }
            else if(sayi<0)
            {
                Console.WriteLine("Negatif bir sayi girdiniz");
            }
            else
            {
                Console.WriteLine("Sıfır değerini girdiniz");
            }
            Console.ReadKey();
        }
    }
}
