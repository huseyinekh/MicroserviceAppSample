using MoviesAPI.Model;

namespace MoviesAPI.Data
{
    public static class MovieContextSeed
    {
        public async static Task<IServiceCollection> SeedAsync(this IServiceCollection services, MoviesAPIContext context)
        {
            if (!context.Movie.Any())
            {
                var movies = new List<Movie> { new Movie { Title = "Love and Heart", Id = 1, Genre = "Action", Owner = "Huseyinekh", Rating = "5 start", ReleaseDate = DateTime.Now ,ImageUrl= "https://m.media-amazon.com/images/M/MV5BYTMyYzVjYmMtN2MwYi00MTA4LWJlNjAtYWY1NDllMjdiYTI2XkEyXkFqcGdeQXVyMjE4NzUxNDA@._V1_.jpg" },
                    new Movie { Title = "Love and Heart", Id = 2, Genre = "Action", Owner = "Huseyinekh", Rating = "5 start", ReleaseDate = DateTime.Now ,ImageUrl= "https://m.media-amazon.com/images/M/MV5BYTMyYzVjYmMtN2MwYi00MTA4LWJlNjAtYWY1NDllMjdiYTI2XkEyXkFqcGdeQXVyMjE4NzUxNDA@._V1_.jpg" },
                    new Movie { Title = "HeadShoot", Id = 3, Genre = "Action", Owner = "Huseyinekh", Rating = "5 start", ReleaseDate = DateTime.Now ,ImageUrl= "https://m.media-amazon.com/images/M/MV5BYTMyYzVjYmMtN2MwYi00MTA4LWJlNjAtYWY1NDllMjdiYTI2XkEyXkFqcGdeQXVyMjE4NzUxNDA@._V1_.jpg" },
                    new Movie { Title = "Purple heart", Id = 4, Genre = "Action", Owner = "Huseyinekh", Rating = "5 start", ReleaseDate = DateTime.Now ,ImageUrl= "https://m.media-amazon.com/images/M/MV5BYTMyYzVjYmMtN2MwYi00MTA4LWJlNjAtYWY1NDllMjdiYTI2XkEyXkFqcGdeQXVyMjE4NzUxNDA@._V1_.jpg" },
                    new Movie { Title = "Kick me", Id = 5, Genre = "Action", Owner = "Huseyinekh", Rating = "5 start", ReleaseDate = DateTime.Now ,ImageUrl= "https://m.media-amazon.com/images/M/MV5BYTMyYzVjYmMtN2MwYi00MTA4LWJlNjAtYWY1NDllMjdiYTI2XkEyXkFqcGdeQXVyMjE4NzUxNDA@._V1_.jpg" },
                    new Movie { Title = "The green mile ", Id = 6, Genre = "Action", Owner = "Huseyinekh", Rating = "5 start", ReleaseDate = DateTime.Now ,ImageUrl= "https://m.media-amazon.com/images/M/MV5BYTMyYzVjYmMtN2MwYi00MTA4LWJlNjAtYWY1NDllMjdiYTI2XkEyXkFqcGdeQXVyMjE4NzUxNDA@._V1_.jpg" },
                    new Movie { Title = "Mr Bean", Id = 7, Genre = "Action", Owner = "Huseyinekh", Rating = "5 start", ReleaseDate = DateTime.Now ,ImageUrl= "https://m.media-amazon.com/images/M/MV5BYTMyYzVjYmMtN2MwYi00MTA4LWJlNjAtYWY1NDllMjdiYTI2XkEyXkFqcGdeQXVyMjE4NzUxNDA@._V1_.jpg" }


                };
                await context.Movie.AddRangeAsync(movies);
                await context.SaveChangesAsync();


            }
            return services;
        }
    }
}
