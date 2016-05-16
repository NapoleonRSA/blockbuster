using System;
using System.Web.Mvc;
using System.Web.UI.DataVisualization.Charting;
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


        public ActionResult List()
        {
            using (var movieRepo = new MovieRepository())
            {
                var movie = movieRepo.GetMany();

                var model = MovieIndexModel.FromDomain(movie);

                return View(model);
            }
        }
    }
}