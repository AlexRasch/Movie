using Microsoft.AspNetCore.Mvc;
using Movie.Models;

namespace Movie.Controllers
{
    public class MovieController : Controller
    {
        private MoviesService _moviesService;

        public MovieController(MoviesService moviesService)
        {
            _moviesService = moviesService;
        }

        [Route("")]
        public IActionResult Index()
        {
            return View();
        }


        [Route("htmlall")]
        public IActionResult htmlAll()
        {
            return PartialView("_MovieID", _moviesService.GetAll());
        }


        [Route("html")]
        public IActionResult html(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            return PartialView("_MovieID", _moviesService.movieDic[id]);
        }

        [Route("jsonall")]
        public IActionResult jsonall()
        {

            return Json(_moviesService.GetAll().Split('|'));
        }

        [Route("json")]
        public IActionResult json(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            return Json(_moviesService.movieDic[id]);
        }


    }
}
