using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CinemaDB1
{
    public class Esercizi
    {
        //Lettura film
        public static void GetMovies()
        {
            using( var cxt = new CinemaDBContext())
            {
                //var films =
                //    from m in cxt.Movies  //è esattamente la proprietà public virtual DbSet<Movie> Movies { get; set; }
                //    select m;

                //foreach (var item in films)
                //{
                //    Console.WriteLine("ID:{0}, Titolo:{1}", item.Id, item.Titolo);
                //}

                //equivale a fare:
                foreach (var item in cxt.Movies)
                {
                    Console.WriteLine("ID:{0}, Titolo:{1}", item.Id, item.Titolo);
                }
                
            }
        }

        //Aggiungere un film
        public static void InsertMovie(Movie m)
        {
            using (var cxt = new CinemaDBContext())
            {
                cxt.Movies.Add(m); //dobbiamo specificare dove aggiungere
                cxt.SaveChanges();
            }
        }

        //Eliminare un film-Modalità connessa

        public static void DeleteMovie()
        {
            using (var cxt = new CinemaDBContext())
            {
                var f = cxt.Movies.Find(13);
                Console.WriteLine("Sto eliminando il film: {0}", f.Titolo);
                cxt.Movies.Remove(f);
                cxt.SaveChanges();
            }
        }

        //Eliminare un film-Modalità disconnessa

        public static void DeleteMovieDisconnected(int movieID)
        {
            var f = new Movie();

            //inizializzo un contesto per trovare il film
            using (var cxt = new CinemaDBContext())
            {
                f = cxt.Movies.Find(movieID)
;           }

            //...
            //inizializzo un altro contesto per eliminarlo
            using (var cxt = new CinemaDBContext())
            {
                cxt.Entry<Movie>(f).State = EntityState.Deleted;
                cxt.SaveChanges();
            }

        }
    }
}
