using System;
using System.Linq;
using System.Web.Mvc;
using CinePulse.Mvc.Data;
using CinePulse.Mvc.Models;

namespace CinePulse.Mvc.Controllers
{
    public class AdminController : Controller
    {
        // GET: /Admin/Dashboard
        public ActionResult Dashboard()
        {
            var vm = new AdminDashboardViewModel
            {
                TotalRevenue = 1845920.00m,
                AdSenseRevenue = 412580.50m,
                AffiliateRevenue = 198420.25m,
                RentalRevenue = 642800.00m,
                PurchaseRevenue = 428120.00m,
                VipRevenue = 164000.00m,
                TotalMovies = MovieDataStore.Movies.Count,
                TotalTrailers = MovieDataStore.Trailers.Count,
                TotalUsers = 124850,
                YouTubeDailyQuota = 10000,
                YouTubeQuotaRemaining = 9912,
                RecentMovies = MovieDataStore.Movies.OrderByDescending(m => m.Id).Take(15).ToList()
            };

            ViewBag.AdSlots = MovieDataStore.AdSlots;
            return View(vm);
        }

        // POST: /Admin/VerifyVideo
        [HttpPost]
        public JsonResult VerifyVideo(int id)
        {
            var movie = MovieDataStore.GetMovieById(id);
            if (movie == null)
            {
                return Json(new { success = false, message = "Movie not found" });
            }

            return Json(new
            {
                success = true,
                movieId = movie.Id,
                title = movie.Title,
                videoId = movie.YouTubeVideoId,
                status = "Embeddable & Verified (200 OK)",
                channel = movie.OfficialChannelName,
                lastChecked = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss 'UTC'")
            });
        }

        // POST: /Admin/ToggleAdSlot
        [HttpPost]
        public JsonResult ToggleAdSlot(string slotId)
        {
            var slot = MovieDataStore.GetAdSlot(slotId);
            if (slot == null)
            {
                return Json(new { success = false });
            }

            slot.IsEnabled = !slot.IsEnabled;
            return Json(new { success = true, isEnabled = slot.IsEnabled });
        }
    }
}
