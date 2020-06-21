using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsPluralsightKurs
{
    class FirstCourse
    {
        /*string[] daysOfWeek =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday",
            };

            Console.WriteLine("Hvilken dag vil du vise?");
            Console.Write("Mandag = 1, osv. >> ");

            int iDay = int.Parse(Console.ReadLine());

            string valgtDag = daysOfWeek[iDay];
            Console.WriteLine($"Den dagen er {valgtDag}");*/
            static void filmer()
        {
            string[] filmer =
        {
                "Ringenes herre",
                "Hobbiten",
                "titanic",
                "sjette sansen",
                "askeladden"
            };

            Console.WriteLine("Hvilken film vil du se?");
            Console.Write("Trykk 1 for Ringenes herre osv. >> ");

            int iFilm = int.Parse(Console.ReadLine());

            string film = filmer[iFilm];
            Console.WriteLine($"Filmen du valgte å se var {film}");
        }
        
            
    }
}
