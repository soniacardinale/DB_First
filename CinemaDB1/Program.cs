using System;

namespace CinemaDB1
{
    class Program
    {
        static void Main(string[] args)
        {
            Esercizi.GetMovies();

            //var movie = new Movie { Titolo = "Il Re Leone", Durata = 90, Genere = "Fantasy" };
            //Esercizi.InsertMovie(movie);

            //Esercizi.DeleteMovie();
            //Esercizi.DeleteMovieDisconnected(15);
            Console.ReadKey();
        }
    }
}
