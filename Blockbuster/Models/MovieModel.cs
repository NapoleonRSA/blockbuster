using Blockbuster.Domain;

namespace Blockbuster.Models
{
    public class MovieModel
    {
        public string Genre { get; set; }
        public string Title { get; set; }
        public int Id { get; set; }

        public static MovieModel FromDomain(Movie movie)
        {
            return new MovieModel
            {
                Id = movie.Id,
                Title = movie.Title,
                Genre = movie.Genre
            };
        }
    }
}