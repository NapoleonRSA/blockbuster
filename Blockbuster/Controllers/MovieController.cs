using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
            var movies = model.ToDomain();
            using (var movieRepo = new MovieRepository())
            {
                movieRepo.Create(movies);
            }

            return new JsonResult { Data = new { IsOk = true } };
        }
    }
}