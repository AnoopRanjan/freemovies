using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using CinePulse.Mvc.Data;
using CinePulse.Mvc.Models;

namespace CinePulse.Mvc.Controllers
{
    public class MoviesController : Controller
    {
        // GET: /must-watch
        public ActionResult MustWatch(string genre, string q)
        {
            var allMustWatch = MovieDataStore.GetMustWatch();

            var genreCounts = new Dictionary<string, int> { { "All", allMustWatch.Count } };
            foreach (var g in MovieDataStore.GetGenres())
            {
                var count = allMustWatch.Count(m => m.Genres.Contains(g.Name, StringComparer.OrdinalIgnoreCase));
                if (count > 0)
                {
                    genreCounts[g.Name] = count;
                }
            }

            var filtered = allMustWatch.AsEnumerable();

            if (!string.IsNullOrWhiteSpace(genre) && !genre.Equals("All", StringComparison.OrdinalIgnoreCase))
            {
                filtered = filtered.Where(m => m.Genres.Contains(genre, StringComparer.OrdinalIgnoreCase));
            }

            if (!string.IsNullOrWhiteSpace(q))
            {
                filtered = filtered.Where(m =>
                    m.Title.IndexOf(q, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    m.Description.IndexOf(q, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    m.Cast.Any(c => c.ActorName.IndexOf(q, StringComparison.OrdinalIgnoreCase) >= 0));
            }

            var vm = new MustWatchViewModel
            {
                Movies = filtered.ToList(),
                SelectedGenre = string.IsNullOrWhiteSpace(genre) ? "All" : genre,
                SearchQuery = q ?? "",
                GenreCounts = genreCounts
            };

            return View(vm);
        }

        // GET: /Movies/Free (Unified Free Streaming Catalogue with industry & language as query filters)
        public ActionResult Free(string genre, string language, string industry, string q)
        {
            var movies = MovieDataStore.GetFreeMovies().AsEnumerable();

            if (!string.IsNullOrWhiteSpace(genre) && !genre.Equals("All", StringComparison.OrdinalIgnoreCase))
            {
                movies = movies.Where(m => m.Genres.Contains(genre, StringComparer.OrdinalIgnoreCase));
            }

            if (!string.IsNullOrWhiteSpace(language) && !language.Equals("All", StringComparison.OrdinalIgnoreCase))
            {
                movies = movies.Where(m => m.Language.Equals(language, StringComparison.OrdinalIgnoreCase));
            }

            if (!string.IsNullOrWhiteSpace(industry) && !industry.Equals("All", StringComparison.OrdinalIgnoreCase))
            {
                movies = movies.Where(m => m.Industry.Equals(industry, StringComparison.OrdinalIgnoreCase));
            }

            if (!string.IsNullOrWhiteSpace(q))
            {
                movies = movies.Where(m =>
                    m.Title.IndexOf(q, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    m.Description.IndexOf(q, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            ViewBag.SelectedGenre = genre ?? "All";
            ViewBag.SelectedLanguage = language ?? "All";
            ViewBag.SelectedIndustry = industry ?? "All";
            ViewBag.SearchQuery = q ?? "";
            ViewBag.Genres = MovieDataStore.GetGenres();

            return View(movies.ToList());
        }

        // GET: /Movies/Premium (Rent & Buy)
        public ActionResult Premium()
        {
            var movies = MovieDataStore.GetPremiumMovies();
            return View(movies);
        }

        // GET: /watch/{id}
        public ActionResult Watch(int id)
        {
            var movie = MovieDataStore.GetMovieById(id);
            if (movie == null)
            {
                return HttpNotFound("Movie not found");
            }

            var similar = MovieDataStore.GetSimilarMovies(movie.Id, 8);
            var sponsored = MovieDataStore.GetPopular().Where(m => m.Id != movie.Id).Take(4).ToList();
            var products = MovieDataStore.GetAffiliateProducts();
            var belowAd = MovieDataStore.GetAdSlot("below-player");
            var sideAd = MovieDataStore.GetAdSlot("sidebar");
            var reviews = MovieDataStore.GetReviews(movie.Id);

            var vm = new WatchViewModel
            {
                Movie = movie,
                SimilarMovies = similar,
                SponsoredMovies = sponsored,
                AffiliateProducts = products,
                BelowPlayerAd = belowAd,
                SidebarAd = sideAd,
                Reviews = reviews,
                IsVip = MovieDataStore.CurrentUser.IsVip,
                ResumeSeconds = 120
            };

            return View(vm);
        }

        // POST: /Movies/Rate
        [HttpPost]
        public JsonResult Rate(int id, int rating)
        {
            var movie = MovieDataStore.GetMovieById(id);
            if (movie == null) return Json(new { success = false, message = "Movie not found" });

            return Json(new { success = true, newRating = movie.ImdbRating });
        }

        // POST: /Movies/Review
        [HttpPost]
        public ActionResult Review(int movieId, string comment, int rating)
        {
            var user = MovieDataStore.CurrentUser;
            var review = new Review
            {
                MovieId = movieId,
                UserName = user.DisplayName,
                Comment = comment,
                Rating = rating > 0 && rating <= 5 ? rating : 5,
                CreatedAt = DateTime.UtcNow
            };
            MovieDataStore.AddReview(review);

            return RedirectToAction("Watch", new { id = movieId });
        }

        // POST: /Movies/ToggleWatchlist
        [HttpPost]
        public JsonResult ToggleWatchlist(int id)
        {
            bool added = MovieDataStore.ToggleWatchlist(id);
            return Json(new { success = true, inWatchlist = added });
        }
    }
}
