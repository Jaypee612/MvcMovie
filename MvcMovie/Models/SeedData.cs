using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "Amaran",
                    ReleaseDate = DateTime.Parse("2024-10-31"),
                    Genre = "Action",
                    Rating = "D",
                    Price = 11.99M
                },
                new Movie
                {
                    Title = "Lubber Pandhu",
                    ReleaseDate = DateTime.Parse("2024-09-20"),
                    Genre = "Sport",
                    Rating = "B",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Lucky Baskhar",
                    ReleaseDate = DateTime.Parse("2024-11-01"),
                    Genre = "Crime Drama",
                    Rating = "U",
                    Price = 10.99M
                },
                new Movie
                {
                    Title = "Pushpa 2",
                    ReleaseDate = DateTime.Parse("2024-12-05"),
                    Genre = "Thriller",
                    Rating = "U",
                    Price = 10.99M
                },
                new Movie
                {
                    Title = "Garudan",
                    ReleaseDate = DateTime.Parse("2024-05-31"),
                    Genre = "Action",
                    Rating = "A",
                    Price = 9.99M
                }
            );
            context.SaveChanges();
        }
    }
}