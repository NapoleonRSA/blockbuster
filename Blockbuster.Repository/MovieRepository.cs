using Blockbuster.Data;
using Blockbuster.Domain;
using Dapper;
namespace Blockbuster.Repository
{
    public class MovieRepository : RepositoryBase
    {

        public void Create(Movie movie)
        {
            var sql = @"INSERT INTO movies 
                         (title , genre)
                       VALUES 
                        (@title , @genre)";
            var movieData = movie_data.FromDomain(movie);
            _db.Execute(sql, movieData);
        }
    }
}