using System;
using System.Linq;
using System.Web.Mvc;
using CinePulse.Mvc.Data;
using CinePulse.Mvc.Models;

namespace CinePulse.Mvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var featured = MovieDataStore.GetFeatured();
            var mustWatch = MovieDataStore.GetMustWatch();
            var free = MovieDataStore.GetFreeMovies();
            var premium = MovieDataStore.GetPremiumMovies();
            var trending = MovieDataStore.GetTrending();
            var topRated = MovieDataStore.GetTopRated();
            var popular = MovieDataStore.GetPopular();
            var recent = MovieDataStore.GetRecentlyAdded();
            var recommended = MovieDataStore.GetRecommended();
            var bollywood = MovieDataStore.GetByIndustry("Bollywood");
            var hollywood = MovieDataStore.GetByIndustry("Hollywood");
            var south = MovieDataStore.GetByIndustry("Regional");
            var action = MovieDataStore.GetByGenre("Action");
            var comedy = MovieDataStore.GetByGenre("Comedy");
            var romance = MovieDataStore.GetByGenre("Romance");
            var continueWatching = MovieDataStore.GetContinueWatching();

            var vm = new HomeViewModel
            {
                FeaturedMovie = featured,
                MustWatchMovies = mustWatch,
                FreeMovies = free,
                PremiumMovies = premium,
                Trending = trending,
                TopRated = topRated,
                Popular = popular,
                RecentlyAdded = recent,
                Recommended = recommended,
                Bollywood = bollywood,
                Hollywood = hollywood,
                SouthIndian = south,
                ActionMovies = action,
                ComedyMovies = comedy,
                RomanceMovies = romance,
                ContinueWatching = continueWatching
            };

            return View(vm);
        }

        public ActionResult Search(string q)
        {
            ViewBag.Query = q ?? "";
            var results = MovieDataStore.SearchMovies(q);
            return View(results);
        }

        public ActionResult Privacy()
        {
            return View();
        }

        public ActionResult Terms()
        {
            return View();
        }
    }
}
