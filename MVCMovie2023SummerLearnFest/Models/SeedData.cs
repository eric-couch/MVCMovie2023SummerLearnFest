using Microsoft.EntityFrameworkCore;
using MVCMovie2023SummerLearnFest.Data;

namespace MVCMovie2023SummerLearnFest.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MVCMovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<MVCMovieContext>>()))
            {
                if (context.Movie.Any())
                {
                    return;
                }
                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Avatar",
                        ReleaseDate = DateTime.Parse("12/16/2009"),
                        Genre = "Action",
                        Price = 5.99M,
                        Rating = "PG-13"
                    },
                    new Movie
                    {
                        Title = "The Matrix",
                        ReleaseDate = DateTime.Parse("3/31/1999"),
                        Genre = "Action",
                        Price = 5.99M,
                        Rating = "R"
                    },
                    new Movie
                    {
                        Title = "John Wick: Chapter 4",
                        ReleaseDate = DateTime.Parse("3/13/2023"),
                        Genre = "Action",
                        Price = 12.99M,
                        Rating = "R"
                    },
                    new Movie
                    {
                        Title = "Toy Story",
                        ReleaseDate = DateTime.Parse("11/19/1995"),
                        Genre = "Animation",
                        Price = 7.99M,
                        Rating = "G"
                    },
                    new Movie
                    {
                        Title = "John Wick: Chapter 3 - Parabellum",
                        ReleaseDate = DateTime.Parse("5/17/2019"),
                        Genre = "Action",
                        Price = 9.99M,
                        Rating = "R"
                    },
                    new Movie
                    {
                        Title = "Spider-man: Into the Spider-verse",
                        ReleaseDate = DateTime.Parse("12/14/2018"),
                        Genre = "Animation",
                        Price = 9.99M,
                        Rating = "PG"
                    },
                    new Movie
                    {
                        Title = "Interstellar",
                        ReleaseDate = DateTime.Parse("11/7/2014"),
                        Genre = "Sci-Fi",
                        Price = 9.99M,
                        Rating = "PG-13"
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
