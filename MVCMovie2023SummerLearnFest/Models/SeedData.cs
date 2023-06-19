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
                        Price = 5.99M
                    },
                    new Movie
                    {
                        Title = "The Matrix",
                        ReleaseDate = DateTime.Parse("3/31/1999"),
                        Genre = "Action",
                        Price = 5.99M
                    },
                    new Movie
                    {
                        Title = "John Wick: Chapter 4",
                        ReleaseDate = DateTime.Parse("3/13/2023"),
                        Genre = "Action",
                        Price = 12.99M
                    },
                    new Movie
                    {
                        Title = "Toy Story",
                        ReleaseDate = DateTime.Parse("11/19/1995"),
                        Genre = "Animation",
                        Price = 7.99M
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
