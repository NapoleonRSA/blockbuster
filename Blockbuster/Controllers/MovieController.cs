using System.Web.Mvc;
using Blockbuster.Models;
using Blockbuster.Repository;

namespace Blockbuster.Controllers
{
    public class MovieController : Controller
    {
        public ActionResult Add()
        {
            return View();
        }

        public JsonResult Create(CreateMovieModel model)
        {
            var movie = model.ToDomain();
            using (var movieRepo = new MovieRepository())
            {
                movieRepo.Create(movie);
            }

            return new JsonResult {Data = new {IsOk = true}};
        }
    }
}