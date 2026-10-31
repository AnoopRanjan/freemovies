using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using CinePulse.Mvc.Data;
using CinePulse.Mvc.Models;

namespace CinePulse.Mvc.Controllers
{
    public class TrailersController : Controller
    {
        // GET: /trailers
        public ActionResult Index(string freshness, string genre, string industry, string q)
        {
            var trailers = MovieDataStore.GetTrailers().AsEnumerable();

            if (!string.IsNullOrWhiteSpace(freshness) && !freshness.Equals("All", StringComparison.OrdinalIgnoreCase))
            {
                trailers = trailers.Where(t => t.FreshnessCategory.Equals(freshness, StringComparison.OrdinalIgnoreCase));
            }

            if (!string.IsNullOrWhiteSpace(genre) && !genre.Equals("All", StringComparison.OrdinalIgnoreCase))
            {
                trailers = trailers.Where(t => t.Genre != null && t.Genre.IndexOf(genre, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            if (!string.IsNullOrWhiteSpace(industry) && !industry.Equals("All", StringComparison.OrdinalIgnoreCase))
            {
                trailers = trailers.Where(t => t.Industry != null && t.Industry.Equals(industry, StringComparison.OrdinalIgnoreCase));
            }

            if (!string.IsNullOrWhiteSpace(q))
            {
                trailers = trailers.Where(t =>
                    t.Title.IndexOf(q, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    t.MovieTitle.IndexOf(q, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    (t.CastNames != null && t.CastNames.IndexOf(q, StringComparison.OrdinalIgnoreCase) >= 0));
            }

            var vm = new TrailersViewModel
            {
                Trailers = trailers.OrderByDescending(t => t.PublishedAt).ToList(),
                SelectedFreshness = freshness ?? "All",
                SelectedGenre = genre ?? "All",
                SelectedIndustry = industry ?? "All",
                SearchQuery = q ?? ""
            };

            return View(vm);
        }
    }
}
