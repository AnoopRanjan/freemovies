using System;
using System.Web.Mvc;
using CinePulse.Mvc.Data;

namespace CinePulse.Mvc.Controllers
{
    public class ActorsController : Controller
    {
        // GET: /Actors
        public ActionResult Index()
        {
            var actors = MovieDataStore.GetActors();
            return View(actors);
        }

        // GET: /Actors/Details/shah-rukh-khan
        public ActionResult Details(string slug)
        {
            var actor = MovieDataStore.GetActorBySlug(slug);
            if (actor == null)
            {
                return HttpNotFound("Actor profile not found");
            }

            ViewBag.Movies = MovieDataStore.GetMoviesByActor(actor.Name);
            return View(actor);
        }
    }
}
