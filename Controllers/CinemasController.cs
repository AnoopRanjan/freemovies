using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using CinePulse.Mvc.Data;
using CinePulse.Mvc.Models;

namespace CinePulse.Mvc.Controllers
{
    public class CinemasController : Controller
    {
        // GET: /cinemas
        public ActionResult Index(string city, double? lat, double? lng)
        {
            var selectedCity = string.IsNullOrWhiteSpace(city) ? "Mumbai" : city;
            var cinemas = MovieDataStore.GetCinemas(selectedCity);

            if (lat.HasValue && lng.HasValue)
            {
                foreach (var c in cinemas)
                {
                    c.DistanceKm = CalculateDistance(lat.Value, lng.Value, c.Latitude, c.Longitude);
                }
                cinemas = cinemas.OrderBy(c => c.DistanceKm).ToList();
            }

            var vm = new CinemasViewModel
            {
                Cinemas = cinemas,
                SelectedCity = selectedCity,
                UserLatitude = lat,
                UserLongitude = lng
            };

            return View(vm);
        }

        // Haversine formula for distance calculation in kilometers
        private double CalculateDistance(double lat1, double lon1, double lat2, double lon2)
        {
            const double R = 6371; // Earth radius in km
            var dLat = ToRadians(lat2 - lat1);
            var dLon = ToRadians(lon2 - lon1);

            var a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                    Math.Cos(ToRadians(lat1)) * Math.Cos(ToRadians(lat2)) *
                    Math.Sin(dLon / 2) * Math.Sin(dLon / 2);

            var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            return Math.Round(R * c, 1);
        }

        private double ToRadians(double degrees)
        {
            return degrees * (Math.PI / 180.0);
        }
    }
}
