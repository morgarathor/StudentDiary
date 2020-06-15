//na samej górze masz biblioteki z jakich korzystasz, chodzi w nich o to że jak masz np Console.WriteLine("tu jakiś tekst"); to bez użycia biblioteki w której się to znajduje
//musiałbyś napisać ją przed użyciem tej funkcji czyli System.Console.Writeline("tu jakis tekst"); i tak za każdym razem.

using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentDairy
{
    class Diary //stworzona tutaj jest klasa Diary która zawiera różne metody 
    {
        List<float> ratings = new List<float>(); // ratings to lista ocen

        public void AddRating(float rating) //pierwsza metoda to dodawanie ocen do listy 
        {
            ratings.Add(rating);
        }

        public float CalculateAverage() //druga metoda to wyliczanie średniej
        {
            float sum = 0, avg = 0; 
            foreach(var rating in ratings) //foreach to pętla. Tyle ile bedzie ocen na liście tyle razy petla się wykona
            {
                sum += rating; //zliczanie sumy ocen 
            }
            avg = sum / ratings.Count(); // ratings.count to liczba ocen, a cała ta linijka to liczenie śreniej

            return avg;
        }

        public float MaxRating() //ta metoda zwraca najwyższą ocenę
        {
            return ratings.Max();
        }
        public float MinRating() //a ta metoda najniższą ocenę
        {
            return ratings.Min();
        }
    }
}
