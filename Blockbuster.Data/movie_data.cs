using Blockbuster.Domain;

namespace Blockbuster.Data
{
    public class movie_data
    {
        public string genre { get; set; }
        public string title { get; set; }
        public int id { get; set; }

        public static movie_data FromDomain(Movie movie)
        {
            return new movie_data
            {
                id = movie.Id,
                title = movie.Title,
                genre = movie.Genre
            };
        }

        public Movie ToDomain()
        {
            return new Movie
            {
                Id = id,
                Title = title,
                Genre = genre
            };
        }
    }
}