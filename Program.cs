using StudentDairy;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StudentDiary
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();
            Console.WriteLine("Aby zakończyć wpisywanie ocen wprowadź zank 0 lub literkę");
            for (; ; ) // pusta pętla for może działać nieskończenie dpoóki nie przerwiesz jej działania
            {
                Console.WriteLine("Podaj Ocenę w zakresie od 1 do 6:");
                float rating;
                bool result= float.TryParse(Console.ReadLine(), out rating );//TryParse jest dodany ponieważ domyślnie ReadLine czyta stringi, TryParse zamieni wszystko co może w typ float czyli wszystkie liczby całkowite oraz z niewielką ilościa znaków po przecinku. natomiast w przypadku wsztstkich innych znaków niż liczby dla wartosci result zostanie przypisana wartość false,a do rating zostanie zwrócona wartość zero  
                if (rating == 0) // według tego warunku jeżeli wartość rating jest równa zero działanie pętli zostanie zakończone. Dotyczy to też przypadku wpisania jakiegoś znaku ponieważ przez TryParse w poprzedniej linijsce zostanie zwrócone zero do rating  
                {
                    break;
                }
                if(result && rating >= 1 && rating <= 6) // oceny zostaną dodane do listy ocen tylko jesli spełnione zostaną wszystkie 3 warunki czyli ocena bedzie w zakresie 1-6, a ten warunek stworzony jest po to żeby błedne dane nie wpływały na średnią i inne wartości 
                {
                    diary.AddRating(rating);
                }
                else
                {
                    Console.WriteLine("Nieprawidłowa ocena! Spróbuj ponownie");
                }
            }
            Console.WriteLine("Średnia tych ocen to:" + diary.CalculateAverage());// wypisanie średniej a nizej to wiadomo
            Console.WriteLine("Najwieksza ocena to:" + diary.MaxRating());
            Console.WriteLine("Najnizsza ocena to:"+ diary.MinRating());
             

        }
    }
}
