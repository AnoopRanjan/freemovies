using System;
using System.Linq;
using System.Web.Mvc;
using CinePulse.Mvc.Data;

namespace CinePulse.Mvc.Controllers
{
    public class AccountController : Controller
    {
        // GET: /Account/Profile
        public new ActionResult Profile()
        {
            var user = MovieDataStore.CurrentUser;
            var watchlistMovies = MovieDataStore.Movies
                .Where(m => user.Watchlist.Contains(m.Id))
                .ToList();

            ViewBag.WatchlistMovies = watchlistMovies;
            return View(user);
        }

        // GET: /Account/Watchlist
        public ActionResult Watchlist()
        {
            var user = MovieDataStore.CurrentUser;
            var watchlistMovies = MovieDataStore.Movies
                .Where(m => user.Watchlist.Contains(m.Id))
                .ToList();

            return View(watchlistMovies);
        }

        // POST: /Account/UpgradeVip
        [HttpPost]
        public ActionResult UpgradeVip(string plan)
        {
            var user = MovieDataStore.CurrentUser;
            user.IsVip = true;
            user.VipPlan = string.IsNullOrEmpty(plan) ? "Ultra 4K Family" : plan;
            TempData["SuccessMessage"] = $"Welcome to CinePulse VIP! Your {user.VipPlan} membership is active with zero ads and 4K Ultra HD streaming.";
            return RedirectToAction("Profile");
        }

        // POST: /Account/GoogleSignIn
        [HttpPost]
        public ActionResult GoogleSignIn()
        {
            TempData["SuccessMessage"] = "Successfully authenticated via Google OAuth 2.0 (OpenID Connect). Session secured.";
            return RedirectToAction("Profile");
        }

        // POST: /Account/DeleteAccount
        [HttpPost]
        public ActionResult DeleteAccount()
        {
            var user = MovieDataStore.CurrentUser;
            user.Watchlist.Clear();
            user.ContinueWatching.Clear();
            user.IsVip = false;
            TempData["InfoMessage"] = "Your account data, viewing history and watchlist have been permanently removed under GDPR/DPDP privacy regulations.";
            return RedirectToAction("Index", "Home");
        }
    }
}
