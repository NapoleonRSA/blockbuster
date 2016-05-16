using System.Collections.Generic;
using Blockbuster.Domain;

namespace Blockbuster.Models
{
    public class MovieIndexModel
    {
        public List<MovieModel> Movies { get; set; }

        public static MovieIndexModel FromDomain(List<Movie> movies)
        {
            var moviesModel = new List<MovieModel>();
            foreach (var movie in movies)
            {
                moviesModel.Add(new MovieModel
                {
                    Id = movie.Id,
                    Title = movie.Title,
                    Genre = movie.Genre
                });  
            }            
            return new MovieIndexModel {Movies = moviesModel};
        }
    }
}