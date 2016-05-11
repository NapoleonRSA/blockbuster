using Blockbuster.Domain;

namespace Blockbuster.Models
{
    public class CreateMovieModel
    {
        public string Genre { get; set; }
        public string Title { get; set; }

        public Movie ToDomain()
        {
            return new Movie
            {
                Title = Title,
                Genre = Genre 
            } ;
        }
    }
}