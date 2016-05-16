using System.Collections.Generic;
using System.Linq;
using Blockbuster.Data;
using Blockbuster.Domain;
using Dapper;

namespace Blockbuster.Repository
{
    public class MovieRepository : RepositoryBase
    {
        public void Create(Movie movie)
        {
            var  sql = @"INSERT INTO movies
                        (title, genre)
                         VALUES
                        ( @title , @genre )";
            var movieData = movie_data.FromDomain(movie);
            _db.Execute(sql, movieData);
        }

        public List<Movie>  GetMany()
        {
         var sql = @"SELECT * FROM movies";

         var movie_data = _db.Query<movie_data>(sql);

         return movie_data.Select(movie => movie.ToDomain()).ToList();

        }
    }
}