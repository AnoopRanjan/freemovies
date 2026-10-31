using System;
using System.Collections.Generic;

namespace CinePulse.Mvc.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Tagline { get; set; }
        public string Description { get; set; }

        // Original movie artwork & authentic pictures
        public string PosterUrl { get; set; }
        public string BackdropUrl { get; set; }
        public string OfficialThumbnailUrl { get; set; }

        public string YouTubeVideoId { get; set; }
        public string DirectYouTubeWatchUrl => !string.IsNullOrEmpty(YouTubeVideoId)
            ? $"https://www.youtube.com/watch?v={YouTubeVideoId}"
            : "#";

        public string OfficialChannelName { get; set; }
        public int ReleaseYear { get; set; }
        public int DurationMinutes { get; set; }
        public string AgeRating { get; set; }
        public string Language { get; set; }
        public string RegionCategory { get; set; } // Bollywood, Hollywood, Regional Cinema
        public string Industry => RegionCategory == "Bollywood" ? "Bollywood" : (RegionCategory == "Hollywood" ? "Hollywood" : "Regional");
        public string Country { get; set; }
        public double ImdbRating { get; set; }
        public long ViewCount { get; set; }
        public string QualityBadge { get; set; } = "1080p FHD";

        public bool IsFeatured { get; set; }
        public bool IsTrending { get; set; }
        public bool IsPopular { get; set; }
        public bool IsRecentlyAdded { get; set; }
        public bool IsTopRated { get; set; }
        public bool IsFree { get; set; } = true;
        public bool IsPremium { get; set; } = false;
        public bool IsMustWatch { get; set; } = false;

        public decimal RentalPriceInr { get; set; } = 0;
        public decimal PurchasePriceInr { get; set; } = 0;

        public List<string> Genres { get; set; } = new List<string>();
        public List<MovieCastItem> Cast { get; set; } = new List<MovieCastItem>();
        public string Director { get; set; }

        public string AuthorizedStreamUrl { get; set; } = "https://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4";
    }

    public class MovieCastItem
    {
        public string ActorName { get; set; }
        public string CharacterName { get; set; }
        public string PhotoUrl { get; set; }
    }

    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
    }

    public class Actor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string PhotoUrl { get; set; }
        public string Biography { get; set; }
        public string BirthPlace { get; set; }
        public int BirthYear { get; set; }
        public string Nationality { get; set; }
        public string KnownFor { get; set; }
        public string Awards { get; set; }
        public long FollowersCount { get; set; }
        public string WikimediaAttribution { get; set; }
        public List<string> UpcomingProjects { get; set; } = new List<string>();
    }

    public class MovieTrailer
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string MovieTitle { get; set; }
        public string YouTubeVideoId { get; set; }
        public string OfficialChannelName { get; set; }
        public string OfficialThumbnailUrl => $"https://img.youtube.com/vi/{YouTubeVideoId}/maxresdefault.jpg";
        public DateTime PublishedAt { get; set; }
        public DateTime? UpcomingCinemaReleaseDate { get; set; }
        public string Language { get; set; }
        public string Genre { get; set; }
        public string CastNames { get; set; }
        public string Director { get; set; }
        public int DurationSeconds { get; set; }
        public string Industry { get; set; } // Bollywood, Hollywood, South Indian
        public string FreshnessCategory { get; set; } // Latest, Last7Days, Last30Days, Upcoming
        public long ViewCount { get; set; }
        public bool IsFeatured { get; set; }
    }

    public class Cinema
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Chain { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int TotalScreens { get; set; }
        public List<string> Amenities { get; set; } = new List<string>();
        public string PartnerWebsiteUrl { get; set; }
        public List<Showtime> Showtimes { get; set; } = new List<Showtime>();
        public double DistanceKm { get; set; }
    }

    public class Showtime
    {
        public int Id { get; set; }
        public int CinemaId { get; set; }
        public string MovieTitle { get; set; }
        public string Format { get; set; } // IMAX 3D, 4DX, Dolby Atmos 2D
        public string Time { get; set; }
        public decimal PriceInr { get; set; }
        public string AvailabilityStatus { get; set; } // Available, Filling Fast, Almost Full
    }

    public class Review
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public string UserName { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class UserProfile
    {
        public string Id { get; set; } = "demo-user-1";
        public string Email { get; set; } = "priya.sharma@gmail.com";
        public string DisplayName { get; set; } = "Priya Sharma";
        public string AvatarUrl { get; set; } = "https://images.unsplash.com/photo-1494790108377-be9c29b29330?w=200&auto=format&fit=crop&q=80";
        public List<string> FavoriteGenres { get; set; } = new List<string> { "Romance", "Comedy", "Action", "Thriller" };
        public List<string> FavoriteActors { get; set; } = new List<string> { "Shah Rukh Khan", "Deepika Padukone", "Akshay Kumar" };
        public List<int> Watchlist { get; set; } = new List<int> { 19, 21, 24, 28, 29, 8, 11 };
        public List<WatchProgress> ContinueWatching { get; set; } = new List<WatchProgress>();
        public bool IsVip { get; set; } = false;
        public string VipPlan { get; set; } = "None";
    }

    public class WatchProgress
    {
        public int MovieId { get; set; }
        public string MovieTitle { get; set; }
        public string MoviePoster { get; set; }
        public int ProgressSeconds { get; set; }
        public int DurationSeconds { get; set; }
        public double ProgressPercentage => DurationSeconds > 0 ? (ProgressSeconds * 100.0 / DurationSeconds) : 0;
        public DateTime LastWatchedAt { get; set; }
    }

    public class AffiliateProduct
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public decimal PriceInr { get; set; }
        public string ImageUrl { get; set; }
        public double Rating { get; set; }
        public string AffiliateUrl { get; set; }
        public string Tagline { get; set; }
    }

    public class AdSlot
    {
        public string SlotId { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Format { get; set; }
        public bool IsEnabled { get; set; } = true;
        public string AdSenseAdClient { get; set; } = "ca-pub-7928340192837461";
        public string AdSenseAdSlot { get; set; } = "8920192837";
    }

    // View Models
    public class HomeViewModel
    {
        public Movie FeaturedMovie { get; set; }
        public List<Movie> MustWatchMovies { get; set; } = new List<Movie>();
        public List<Movie> FreeMovies { get; set; } = new List<Movie>();
        public List<Movie> PremiumMovies { get; set; } = new List<Movie>();
        public List<Movie> Trending { get; set; } = new List<Movie>();
        public List<Movie> TopRated { get; set; } = new List<Movie>();
        public List<Movie> Popular { get; set; } = new List<Movie>();
        public List<Movie> RecentlyAdded { get; set; } = new List<Movie>();
        public List<Movie> Recommended { get; set; } = new List<Movie>();
        public List<Movie> Bollywood { get; set; } = new List<Movie>();
        public List<Movie> Hollywood { get; set; } = new List<Movie>();
        public List<Movie> SouthIndian { get; set; } = new List<Movie>();
        public List<Movie> ActionMovies { get; set; } = new List<Movie>();
        public List<Movie> ComedyMovies { get; set; } = new List<Movie>();
        public List<Movie> RomanceMovies { get; set; } = new List<Movie>();
        public List<WatchProgress> ContinueWatching { get; set; } = new List<WatchProgress>();
    }

    public class MustWatchViewModel
    {
        public List<Movie> Movies { get; set; } = new List<Movie>();
        public string SelectedGenre { get; set; } = "All";
        public string SearchQuery { get; set; } = "";
        public Dictionary<string, int> GenreCounts { get; set; } = new Dictionary<string, int>();
    }

    public class WatchViewModel
    {
        public Movie Movie { get; set; }
        public List<Movie> SimilarMovies { get; set; } = new List<Movie>();
        public List<Movie> SponsoredMovies { get; set; } = new List<Movie>();
        public List<AffiliateProduct> AffiliateProducts { get; set; } = new List<AffiliateProduct>();
        public AdSlot BelowPlayerAd { get; set; }
        public AdSlot SidebarAd { get; set; }
        public List<Review> Reviews { get; set; } = new List<Review>();
        public bool IsVip { get; set; }
        public int ResumeSeconds { get; set; }
    }

    public class TrailersViewModel
    {
        public List<MovieTrailer> Trailers { get; set; } = new List<MovieTrailer>();
        public string SelectedFreshness { get; set; } = "All";
        public string SelectedGenre { get; set; } = "All";
        public string SelectedIndustry { get; set; } = "All";
        public string SearchQuery { get; set; } = "";
    }

    public class CinemasViewModel
    {
        public List<Cinema> Cinemas { get; set; } = new List<Cinema>();
        public string SelectedCity { get; set; } = "Mumbai";
        public double? UserLatitude { get; set; }
        public double? UserLongitude { get; set; }
        public List<string> SupportedCities { get; set; } = new List<string>
        {
            "Mumbai", "Delhi-NCR", "Bengaluru", "Hyderabad", "Pune", "Chennai", "Kolkata", "Ahmedabad"
        };
    }

    public class AdminDashboardViewModel
    {
        public decimal TotalRevenue { get; set; }
        public decimal AdSenseRevenue { get; set; }
        public decimal AffiliateRevenue { get; set; }
        public decimal RentalRevenue { get; set; }
        public decimal PurchaseRevenue { get; set; }
        public decimal VipRevenue { get; set; }
        public int TotalMovies { get; set; }
        public int TotalTrailers { get; set; }
        public int TotalUsers { get; set; }
        public int YouTubeDailyQuota { get; set; } = 10000;
        public int YouTubeQuotaRemaining { get; set; } = 9900;
        public List<Movie> RecentMovies { get; set; } = new List<Movie>();
    }
}
