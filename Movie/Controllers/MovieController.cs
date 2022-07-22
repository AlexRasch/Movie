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

        [Route("html")]
        public IActionResult html(int id)
        {
            if(id == null)
            {
                return NotFound();
            }

            return PartialView("_MovieID", _moviesService.movieDic[id]);

            //var viewModel = _moviesService.movieDic[id];


            //return Json(viewModel);
        }

        [Route("json")]
        public IActionResult json(int id)
        {

            return Json(_moviesService.movieDic[id]);
        }


    }
}
