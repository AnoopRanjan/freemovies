using System;
using System.Collections.Generic;
using System.Linq;
using CinePulse.Mvc.Models;

namespace CinePulse.Mvc.Data
{
    public static class MovieDataStore
    {
        public static List<Movie> Movies { get; } = new List<Movie>();
        public static List<Genre> Genres { get; } = new List<Genre>();
        public static List<Actor> Actors { get; } = new List<Actor>();
        public static List<MovieTrailer> Trailers { get; } = new List<MovieTrailer>();
        public static List<Cinema> Cinemas { get; } = new List<Cinema>();
        public static List<Review> Reviews { get; } = new List<Review>();
        public static List<AffiliateProduct> AffiliateProducts { get; } = new List<AffiliateProduct>();
        public static UserProfile CurrentUser { get; } = new UserProfile();
        public static List<AdSlot> AdSlots { get; } = new List<AdSlot>();

        static MovieDataStore()
        {
            InitializeData();
        }

        private static void InitializeData()
        {
            // 1. Genres
            Genres.AddRange(new[]
            {
                new Genre { Id = 1, Name = "Action", Slug = "action", Icon = "fa-fire", Description = "High-octane excitement and martial arts" },
                new Genre { Id = 2, Name = "Comedy", Slug = "comedy", Icon = "fa-face-laugh-squint", Description = "Hilarious laughter and slapstick fun" },
                new Genre { Id = 3, Name = "Romance", Slug = "romance", Icon = "fa-heart", Description = "Heartwarming love stories and emotional bonds" },
                new Genre { Id = 4, Name = "Drama", Slug = "drama", Icon = "fa-masks-theater", Description = "Emotionally gripping and intense journeys" },
                new Genre { Id = 5, Name = "Thriller", Slug = "thriller", Icon = "fa-bolt", Description = "Edge-of-the-seat suspense and mysteries" },
                new Genre { Id = 6, Name = "Science Fiction", Slug = "sci-fi", Icon = "fa-rocket", Description = "Futuristic tech and space odysseys" },
                new Genre { Id = 7, Name = "Crime", Slug = "crime", Icon = "fa-shield-halved", Description = "Underworld kingpins and detectives" },
                new Genre { Id = 8, Name = "Family", Slug = "family", Icon = "fa-users", Description = "Wholesome entertainment for all ages" },
                new Genre { Id = 9, Name = "Horror", Slug = "horror", Icon = "fa-ghost", Description = "Supernatural chills and classic terror" },
                new Genre { Id = 10, Name = "Regional Cinema", Slug = "regional", Icon = "fa-globe", Description = "Vibrant South Indian and Indian regional cinema" }
            });

            // 2. Actors
            Actors.AddRange(new[]
            {
                new Actor
                {
                    Id = 1, Name = "Shah Rukh Khan", Slug = "shah-rukh-khan",
                    PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/6/6e/Shah_Rukh_Khan_graces_the_launch_of_the_new_Santro.jpg",
                    Biography = "The Baadshah of Bollywood and global cinematic icon with over 3 decades of blockbuster records.",
                    BirthPlace = "New Delhi, India", BirthYear = 1965, Nationality = "Indian",
                    KnownFor = "Jawan, Pathaan, DDLJ, Chak De! India, Raees",
                    Awards = "14 Filmfare Awards, Padma Shri, Legion of Honour", FollowersCount = 44000000,
                    WikimediaAttribution = "Bollywood Hungama / Wikimedia Commons, CC BY 3.0",
                    UpcomingProjects = new List<string> { "King (2025)", "Pathaan 2" }
                },
                new Actor
                {
                    Id = 2, Name = "Deepika Padukone", Slug = "deepika-padukone",
                    PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/b/b6/Deepika_Padukone_Cannes_2018_%28cropped%29.jpg",
                    Biography = "One of India's highest-paid leading actresses, acclaimed producer and cultural icon.",
                    BirthPlace = "Copenhagen, Denmark", BirthYear = 1986, Nationality = "Indian",
                    KnownFor = "Kalki 2898 AD, Jawan, Pathaan, Padmaavat, Piku",
                    Awards = "3 Filmfare Awards, TIME 100 Most Influential People", FollowersCount = 76000000,
                    WikimediaAttribution = "Georges Biard / Wikimedia Commons, CC BY-SA 4.0",
                    UpcomingProjects = new List<string> { "Singham Again", "The Intern" }
                },
                new Actor
                {
                    Id = 3, Name = "Salman Khan", Slug = "salman-khan",
                    PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/8/86/Salman_Khan_at_Renault_Star_Guild_Awards.jpg",
                    Biography = "Bollywood's Bhaijaan, superstar of high-voltage mass entertainers and romantic blockbusters.",
                    BirthPlace = "Indore, India", BirthYear = 1965, Nationality = "Indian",
                    KnownFor = "Tere Naam, Bodyguard, Bajrangi Bhaijaan, Tiger 3, Sultan",
                    Awards = "2 National Film Awards, 2 Filmfare Awards", FollowersCount = 68000000,
                    WikimediaAttribution = "Bollywood Hungama / Wikimedia Commons, CC BY 3.0",
                    UpcomingProjects = new List<string> { "Sikandar (Eid 2025)", "Tiger vs Pathaan" }
                },
                new Actor
                {
                    Id = 4, Name = "Amitabh Bachchan", Slug = "amitabh-bachchan",
                    PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/9/91/Amitabh_Bachchan_photoshoot.jpg",
                    Biography = "The Shahenshah of Indian Cinema with a titanic cultural impact spanning over five decades.",
                    BirthPlace = "Allahabad, India", BirthYear = 1942, Nationality = "Indian",
                    KnownFor = "Sholay, Deewaar, Don, Kalki 2898 AD, Black",
                    Awards = "4 National Film Awards, Dadasaheb Phalke Award, Padma Vibhushan", FollowersCount = 48000000,
                    WikimediaAttribution = "Elena Ternovaja / Wikimedia Commons, CC BY-SA 3.0",
                    UpcomingProjects = new List<string> { "Kalki 2898 AD Part 2", "Vettaiyan" }
                },
                new Actor
                {
                    Id = 5, Name = "Akshay Kumar", Slug = "akshay-kumar",
                    PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/2/2e/Akshay_Kumar.jpg",
                    Biography = "Bollywood's beloved Khiladi, king of comedy, action, and socially conscious cinematic triumphs.",
                    BirthPlace = "Amritsar, India", BirthYear = 1967, Nationality = "Indian",
                    KnownFor = "Hera Pheri, Welcome, Housefull 2, Khatta Meetha, OMG",
                    Awards = "National Film Award, 2 Filmfare Awards, Padma Shri", FollowersCount = 65000000,
                    WikimediaAttribution = "Bollywood Hungama / Wikimedia Commons, CC BY 3.0",
                    UpcomingProjects = new List<string> { "Singham Again", "Housefull 5", "Welcome to the Jungle" }
                },
                new Actor
                {
                    Id = 6, Name = "Aamir Khan", Slug = "aamir-khan",
                    PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/d/df/Aamir_Khan_2013.jpg",
                    Biography = "Mr. Perfectionist of Indian Cinema known for groundbreaking worldwide cinematic sensations.",
                    BirthPlace = "Mumbai, India", BirthYear = 1965, Nationality = "Indian",
                    KnownFor = "Raja Hindustani, 1947 Earth, Dangal, 3 Idiots, PK, Lagaan",
                    Awards = "4 National Film Awards, 9 Filmfare Awards, Padma Bhushan", FollowersCount = 39000000,
                    WikimediaAttribution = "Bollywood Hungama / Wikimedia Commons, CC BY 3.0",
                    UpcomingProjects = new List<string> { "Sitaare Zameen Par" }
                },
                new Actor
                {
                    Id = 7, Name = "Leonardo DiCaprio", Slug = "leonardo-dicaprio",
                    PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/4/46/Leonardo_Dicaprio_Cannes_2019.jpg",
                    Biography = "Academy Award winning Hollywood actor renowned for complex dramatic and visionary collaborations.",
                    BirthPlace = "Los Angeles, USA", BirthYear = 1974, Nationality = "American",
                    KnownFor = "Inception, Titanic, The Wolf of Wall Street, The Revenant",
                    Awards = "Academy Award (Oscar), BAFTA, 3 Golden Globes", FollowersCount = 61000000,
                    WikimediaAttribution = "Georges Biard / Wikimedia Commons, CC BY-SA 4.0",
                    UpcomingProjects = new List<string> { "Paul Thomas Anderson Untitled Film (2025)" }
                },
                new Actor
                {
                    Id = 8, Name = "Cillian Murphy", Slug = "cillian-murphy",
                    PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/a/a5/Cillian_Murphy_at_Berlinale_2024.jpg",
                    Biography = "Irish actor acclaimed for his hypnotic intensity across Christopher Nolan epics and Peaky Blinders.",
                    BirthPlace = "Douglas, Ireland", BirthYear = 1976, Nationality = "Irish",
                    KnownFor = "Oppenheimer, Inception, Dunkirk, Peaky Blinders, 28 Days Later",
                    Awards = "Academy Award (Oscar) Best Actor, BAFTA, Golden Globe", FollowersCount = 14000000,
                    WikimediaAttribution = "Harald Krichel / Wikimedia Commons, CC BY-SA 4.0",
                    UpcomingProjects = new List<string> { "Peaky Blinders The Movie", "28 Years Later" }
                },
                new Actor
                {
                    Id = 9, Name = "Prabhas", Slug = "prabhas",
                    PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/e/ec/Prabhas_at_Saaho_Interview.jpg",
                    Biography = "Pan-Indian Rebel Star who redefined Indian box office records with Baahubali and Kalki.",
                    BirthPlace = "Chennai, India", BirthYear = 1979, Nationality = "Indian",
                    KnownFor = "Kalki 2898 AD, Salaar, Baahubali 1 & 2, Chatrapathi",
                    Awards = "Nandi Award, Filmfare Awards South", FollowersCount = 12000000,
                    WikimediaAttribution = "Bollywood Hungama / Wikimedia Commons, CC BY 3.0",
                    UpcomingProjects = new List<string> { "Salaar: Part 2 – Shouryaanga Parvam", "The Raja Saab" }
                },
                new Actor
                {
                    Id = 10, Name = "Karisma Kapoor", Slug = "karisma-kapoor",
                    PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/f/f6/Karisma_Kapoor_promoting_Murder_Mubarak.jpg",
                    Biography = "Iconic 90s Bollywood queen celebrated for national award-winning dramatic and romantic performances.",
                    BirthPlace = "Mumbai, India", BirthYear = 1974, Nationality = "Indian",
                    KnownFor = "Raja Hindustani, Zubeidaa, Dil To Pagal Hai, Fiza",
                    Awards = "National Film Award, 4 Filmfare Awards", FollowersCount = 9500000,
                    WikimediaAttribution = "Bollywood Hungama / Wikimedia Commons, CC BY 3.0",
                    UpcomingProjects = new List<string> { "Brown (Series)" }
                }
            });

            // 3. Movies (45 Titles with verified YouTube IDs & Authentic Movie Pictures)
            Movies.AddRange(new[]
            {
                // === MUST WATCH FREE BOLLYWOOD BLOCKBUSTERS (Ids 19 to 45) ===
                new Movie
                {
                    Id = 19,
                    Title = "Raja Hindustani",
                    Slug = "raja-hindustani",
                    Tagline = "A heart-touching romantic saga between a small-town taxi driver and a wealthy heiress.",
                    Description = "A humble taxi driver from a hill station and an affluent city girl fall deeply in love and marry against family wishes, weathering misunderstandings to find true union. Official full movie released by Shemaroo Movies.",
                    PosterUrl = "https://upload.wikimedia.org/wikipedia/en/a/a2/Raja_Hindustani.jpg",
                    BackdropUrl = "https://img.youtube.com/vi/gIR-oQbD-ok/maxresdefault.jpg",
                    OfficialThumbnailUrl = "https://img.youtube.com/vi/gIR-oQbD-ok/maxresdefault.jpg",
                    YouTubeVideoId = "gIR-oQbD-ok",
                    OfficialChannelName = "Shemaroo Movies (Official)",
                    ReleaseYear = 1996, DurationMinutes = 175, AgeRating = "U", Language = "Hindi", RegionCategory = "Bollywood", Country = "India",
                    ImdbRating = 6.2, ViewCount = 14800000, QualityBadge = "1080p FHD",
                    IsFeatured = true, IsTrending = true, IsPopular = true, IsTopRated = true, IsFree = true, IsMustWatch = true,
                    Genres = new List<string> { "Romance", "Drama", "Musical" }, Director = "Dharmesh Darshan",
                    Cast = new List<MovieCastItem>
                    {
                        new MovieCastItem { ActorName = "Aamir Khan", CharacterName = "Raja Hindustani", PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/d/df/Aamir_Khan_2013.jpg" },
                        new MovieCastItem { ActorName = "Karisma Kapoor", CharacterName = "Aarti Sehgal", PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/f/f6/Karisma_Kapoor_promoting_Murder_Mubarak.jpg" }
                    }
                },
                new Movie
                {
                    Id = 20,
                    Title = "Tere Naam",
                    Slug = "tere-naam",
                    Tagline = "Unfortunately a true love story. Salman Khan's career-defining cult performance.",
                    Description = "Radhe Mohan, a fierce college rowdy, falls in love with Nirjara, an innocent priest's daughter. A tragic attack alters their destiny in one of Bollywood's most poignant love stories. Official full movie on Ultra Movie Parlour.",
                    PosterUrl = "https://upload.wikimedia.org/wikipedia/en/0/05/Tere_Naam_poster.jpg",
                    BackdropUrl = "https://img.youtube.com/vi/z3KmITqO5Jk/maxresdefault.jpg",
                    OfficialThumbnailUrl = "https://img.youtube.com/vi/z3KmITqO5Jk/maxresdefault.jpg",
                    YouTubeVideoId = "z3KmITqO5Jk",
                    OfficialChannelName = "Ultra Movie Parlour (Official)",
                    ReleaseYear = 2003, DurationMinutes = 132, AgeRating = "U/A 16+", Language = "Hindi", RegionCategory = "Bollywood", Country = "India",
                    ImdbRating = 7.2, ViewCount = 12500000, QualityBadge = "1080p FHD",
                    IsFeatured = true, IsTrending = true, IsPopular = true, IsTopRated = true, IsFree = true, IsMustWatch = true,
                    Genres = new List<string> { "Romance", "Drama", "Action" }, Director = "Satish Kaushik",
                    Cast = new List<MovieCastItem>
                    {
                        new MovieCastItem { ActorName = "Salman Khan", CharacterName = "Radhe Mohan", PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/8/86/Salman_Khan_at_Renault_Star_Guild_Awards.jpg" },
                        new MovieCastItem { ActorName = "Bhoomika Chawla", CharacterName = "Nirjara", PhotoUrl = "https://images.unsplash.com/photo-1534528741775-53994a69daeb?w=200" }
                    }
                },
                new Movie
                {
                    Id = 21,
                    Title = "Vivah: Journey From Engagement To Marriage",
                    Slug = "vivah-engagement-to-marriage",
                    Tagline = "True love begins when hearts connect beyond physical perfection.",
                    Description = "Prem and Poonam are arranged to marry and slowly discover pure unconditional love. Days before the wedding, an unexpected fire tests the strength of their commitment. Official full movie on Rajshri Productions.",
                    PosterUrl = "https://upload.wikimedia.org/wikipedia/en/8/85/Vivah_poster.jpg",
                    BackdropUrl = "https://img.youtube.com/vi/HYM8qgaDYQc/maxresdefault.jpg",
                    OfficialThumbnailUrl = "https://img.youtube.com/vi/HYM8qgaDYQc/maxresdefault.jpg",
                    YouTubeVideoId = "HYM8qgaDYQc",
                    OfficialChannelName = "Rajshri Productions (Official)",
                    ReleaseYear = 2006, DurationMinutes = 178, AgeRating = "U", Language = "Hindi", RegionCategory = "Bollywood", Country = "India",
                    ImdbRating = 6.6, ViewCount = 8900000, QualityBadge = "1080p FHD",
                    IsFeatured = false, IsTrending = true, IsPopular = true, IsFree = true, IsMustWatch = true,
                    Genres = new List<string> { "Romance", "Drama", "Family" }, Director = "Sooraj R. Barjatya",
                    Cast = new List<MovieCastItem>
                    {
                        new MovieCastItem { ActorName = "Shahid Kapoor", CharacterName = "Prem", PhotoUrl = "https://images.unsplash.com/photo-1506794778202-cad84cf45f1d?w=200" },
                        new MovieCastItem { ActorName = "Amrita Rao", CharacterName = "Poonam", PhotoUrl = "https://images.unsplash.com/photo-1544005313-94ddf0286df2?w=200" }
                    }
                },
                new Movie
                {
                    Id = 22,
                    Title = "Bodyguard",
                    Slug = "bodyguard",
                    Tagline = "My love... my duty. Salman Khan's record-smashing romantic action blockbuster.",
                    Description = "Lovely Singh is assigned to guard Divya, a wealthy businessman's daughter. To distract him, Divya starts pranking him as an anonymous admirer, unaware that real affection is blooming. Official 4K full movie on Ultra Movie Parlour.",
                    PosterUrl = "https://upload.wikimedia.org/wikipedia/en/a/a2/Bodyguard_Hindi_Poster.jpg",
                    BackdropUrl = "https://img.youtube.com/vi/isoqYRZ6MFM/maxresdefault.jpg",
                    OfficialThumbnailUrl = "https://img.youtube.com/vi/isoqYRZ6MFM/maxresdefault.jpg",
                    YouTubeVideoId = "isoqYRZ6MFM",
                    OfficialChannelName = "Ultra Movie Parlour (Official)",
                    ReleaseYear = 2011, DurationMinutes = 130, AgeRating = "U/A 13+", Language = "Hindi", RegionCategory = "Bollywood", Country = "India",
                    ImdbRating = 6.0, ViewCount = 19600000, QualityBadge = "4K UHD",
                    IsFeatured = false, IsPopular = true, IsFree = true, IsMustWatch = true,
                    Genres = new List<string> { "Action", "Romance", "Comedy" }, Director = "Siddique",
                    Cast = new List<MovieCastItem>
                    {
                        new MovieCastItem { ActorName = "Salman Khan", CharacterName = "Lovely Singh", PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/8/86/Salman_Khan_at_Renault_Star_Guild_Awards.jpg" },
                        new MovieCastItem { ActorName = "Kareena Kapoor", CharacterName = "Divya", PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/0/07/Kareena_Kapoor_promoting_Good_Newwz.jpg" }
                    }
                },
                new Movie
                {
                    Id = 23,
                    Title = "Heroes",
                    Slug = "heroes",
                    Tagline = "Every Indian has a story of courage and sacrifice.",
                    Description = "Two film school students journey across India to deliver three letters written by fallen soldiers to their families, discovering true meaning of valor and national pride. Official 4K movie on Ultra Movie Parlour.",
                    PosterUrl = "https://upload.wikimedia.org/wikipedia/en/2/29/Heroes_poster.jpg",
                    BackdropUrl = "https://img.youtube.com/vi/IjOBXWz-wic/maxresdefault.jpg",
                    OfficialThumbnailUrl = "https://img.youtube.com/vi/IjOBXWz-wic/maxresdefault.jpg",
                    YouTubeVideoId = "IjOBXWz-wic",
                    OfficialChannelName = "Ultra Movie Parlour (Official)",
                    ReleaseYear = 2008, DurationMinutes = 135, AgeRating = "U/A 13+", Language = "Hindi", RegionCategory = "Bollywood", Country = "India",
                    ImdbRating = 6.8, ViewCount = 6800000, QualityBadge = "4K UHD",
                    IsFeatured = false, IsTrending = true, IsPopular = true, IsTopRated = true, IsFree = true, IsMustWatch = true,
                    Genres = new List<string> { "Action", "Drama" }, Director = "Samir Karnik",
                    Cast = new List<MovieCastItem>
                    {
                        new MovieCastItem { ActorName = "Salman Khan", CharacterName = "Balkar Singh", PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/8/86/Salman_Khan_at_Renault_Star_Guild_Awards.jpg" },
                        new MovieCastItem { ActorName = "Sunny Deol", CharacterName = "Vikram Shergill", PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/e/ec/Sunny_Deol_at_Gadar_2_success_party.jpg" }
                    }
                },
                new Movie
                {
                    Id = 24,
                    Title = "Hera Pheri",
                    Slug = "hera-pheri",
                    Tagline = "Yeh Baburao ka style hai! The supreme comedy of errors.",
                    Description = "Two eccentric tenants and their quirky landlord accidentally intercept a ransom call intended for a wealthy tycoon, sparking a cascade of hilarious comedic schemes. Officially released free by Shemaroo Movies.",
                    PosterUrl = "https://upload.wikimedia.org/wikipedia/en/4/41/Hera_Pheri_2000_poster.jpg",
                    BackdropUrl = "https://img.youtube.com/vi/TIQ5hrfermg/maxresdefault.jpg",
                    OfficialThumbnailUrl = "https://img.youtube.com/vi/TIQ5hrfermg/maxresdefault.jpg",
                    YouTubeVideoId = "TIQ5hrfermg",
                    OfficialChannelName = "Shemaroo Movies (Official)",
                    ReleaseYear = 2000, DurationMinutes = 156, AgeRating = "U", Language = "Hindi", RegionCategory = "Bollywood", Country = "India",
                    ImdbRating = 8.2, ViewCount = 18500000, QualityBadge = "1080p FHD",
                    IsFeatured = true, IsTrending = true, IsPopular = true, IsTopRated = true, IsFree = true, IsMustWatch = true,
                    Genres = new List<string> { "Comedy", "Crime" }, Director = "Priyadarshan",
                    Cast = new List<MovieCastItem>
                    {
                        new MovieCastItem { ActorName = "Akshay Kumar", CharacterName = "Raju", PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/2/2e/Akshay_Kumar.jpg" },
                        new MovieCastItem { ActorName = "Suniel Shetty", CharacterName = "Shyam", PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/7/7b/Suniel_Shetty_at_an_event.jpg" },
                        new MovieCastItem { ActorName = "Paresh Rawal", CharacterName = "Baburao Ganpatrao Apte", PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/f/fc/Paresh_Rawal_at_an_event.jpg" }
                    }
                },
                new Movie
                {
                    Id = 25,
                    Title = "Housefull 2: The Dirty Dozen",
                    Slug = "housefull-2",
                    Tagline = "Twice the confusion, quadruple the laughter!",
                    Description = "Four brothers who dislike each other each claim to be a wealthy millionaire's son to impress four respective fathers-in-law, leading to non-stop slapstick madness. Official full movie on Shemaroo Movies.",
                    PosterUrl = "https://upload.wikimedia.org/wikipedia/en/2/28/Housefull_2_Poster.jpg",
                    BackdropUrl = "https://img.youtube.com/vi/jcHHttzqtWw/maxresdefault.jpg",
                    OfficialThumbnailUrl = "https://img.youtube.com/vi/jcHHttzqtWw/maxresdefault.jpg",
                    YouTubeVideoId = "jcHHttzqtWw",
                    OfficialChannelName = "Shemaroo Movies (Official)",
                    ReleaseYear = 2012, DurationMinutes = 160, AgeRating = "U/A 13+", Language = "Hindi", RegionCategory = "Bollywood", Country = "India",
                    ImdbRating = 6.3, ViewCount = 14200000, QualityBadge = "1080p FHD",
                    IsFeatured = false, IsTrending = true, IsPopular = true, IsFree = true, IsMustWatch = true,
                    Genres = new List<string> { "Comedy", "Romance" }, Director = "Sajid Khan",
                    Cast = new List<MovieCastItem>
                    {
                        new MovieCastItem { ActorName = "Akshay Kumar", CharacterName = "Sunny", PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/2/2e/Akshay_Kumar.jpg" },
                        new MovieCastItem { ActorName = "John Abraham", CharacterName = "Max", PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/6/6f/John_Abraham_at_Vedaa_trailer_launch.jpg" }
                    }
                },
                new Movie
                {
                    Id = 26,
                    Title = "Dhol",
                    Slug = "dhol",
                    Tagline = "Char bekaar, ek dhol aur aafat hazaar!",
                    Description = "Four lazy friends looking for easy wealth try to woo a rich neighborhood girl, only to unwittingly entangle themselves with a lethal underworld contract killer. Official full movie on Shemaroo Movies.",
                    PosterUrl = "https://upload.wikimedia.org/wikipedia/en/4/4b/Dhol_poster.jpg",
                    BackdropUrl = "https://img.youtube.com/vi/Chia-e0i3t0/maxresdefault.jpg",
                    OfficialThumbnailUrl = "https://img.youtube.com/vi/Chia-e0i3t0/maxresdefault.jpg",
                    YouTubeVideoId = "Chia-e0i3t0",
                    OfficialChannelName = "Shemaroo Movies (Official)",
                    ReleaseYear = 2007, DurationMinutes = 144, AgeRating = "U/A 13+", Language = "Hindi", RegionCategory = "Bollywood", Country = "India",
                    ImdbRating = 6.5, ViewCount = 11400000, QualityBadge = "1080p FHD",
                    IsPopular = true, IsFree = true, IsMustWatch = true,
                    Genres = new List<string> { "Comedy", "Crime" }, Director = "Priyadarshan",
                    Cast = new List<MovieCastItem>
                    {
                        new MovieCastItem { ActorName = "Rajpal Yadav", CharacterName = "Martand 'Maru' Dhamdhere", PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/a/a2/Rajpal_Yadav_at_an_event.jpg" }
                    }
                },
                new Movie
                {
                    Id = 27,
                    Title = "Deewane Huye Paagal",
                    Slug = "deewane-huye-paagal",
                    Tagline = "A roller coaster ride of crazy lovers and relentless comedy.",
                    Description = "Multiple quirky suitors all pretend to be someone else to win over the lovely Tanya, sparking chaotic cross-country chases and uproarious misunderstandings. Official full movie on Shemaroo Movies.",
                    PosterUrl = "https://upload.wikimedia.org/wikipedia/en/9/94/Deewane_Huye_Paagal_poster.jpg",
                    BackdropUrl = "https://img.youtube.com/vi/Mwhra8KI8UU/maxresdefault.jpg",
                    OfficialThumbnailUrl = "https://img.youtube.com/vi/Mwhra8KI8UU/maxresdefault.jpg",
                    YouTubeVideoId = "Mwhra8KI8UU",
                    OfficialChannelName = "Shemaroo Movies (Official)",
                    ReleaseYear = 2005, DurationMinutes = 155, AgeRating = "U", Language = "Hindi", RegionCategory = "Bollywood", Country = "India",
                    ImdbRating = 6.4, ViewCount = 9800000, QualityBadge = "1080p FHD",
                    IsPopular = true, IsFree = true, IsMustWatch = true,
                    Genres = new List<string> { "Comedy", "Romance" }, Director = "Vikram Bhatt"
                },
                new Movie
                {
                    Id = 28,
                    Title = "Welcome",
                    Slug = "welcome-comedy",
                    Tagline = "Control Majnu bhai, control! The king of family slapstick comedies.",
                    Description = "A simple, respectable bachelor falls for a beautiful girl without knowing that her brothers are two of the most feared underworld dons looking to go straight. Official full movie on Shemaroo.",
                    PosterUrl = "https://upload.wikimedia.org/wikipedia/en/9/9e/Welcome_2007_poster.jpg",
                    BackdropUrl = "https://img.youtube.com/vi/vtq3j2wCndo/maxresdefault.jpg",
                    OfficialThumbnailUrl = "https://img.youtube.com/vi/vtq3j2wCndo/maxresdefault.jpg",
                    YouTubeVideoId = "vtq3j2wCndo",
                    OfficialChannelName = "Shemaroo (Official)",
                    ReleaseYear = 2007, DurationMinutes = 159, AgeRating = "U/A 13+", Language = "Hindi", RegionCategory = "Bollywood", Country = "India",
                    ImdbRating = 7.0, ViewCount = 22400000, QualityBadge = "1080p FHD",
                    IsFeatured = true, IsTrending = true, IsPopular = true, IsTopRated = true, IsFree = true, IsMustWatch = true,
                    Genres = new List<string> { "Comedy", "Crime", "Romance" }, Director = "Anees Bazmee",
                    Cast = new List<MovieCastItem>
                    {
                        new MovieCastItem { ActorName = "Akshay Kumar", CharacterName = "Rajiv Saini", PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/2/2e/Akshay_Kumar.jpg" },
                        new MovieCastItem { ActorName = "Katrina Kaif", CharacterName = "Sanjana Shetty", PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/4/4b/Katrina_Kaif_at_Kalyan_Jewelers_launch.jpg" },
                        new MovieCastItem { ActorName = "Nana Patekar", CharacterName = "Don Uday Shetty", PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/7/7b/Nana_Patekar_at_an_event.jpg" }
                    }
                },
                new Movie
                {
                    Id = 29,
                    Title = "Sholay",
                    Slug = "sholay-cult-action",
                    Tagline = "Kitne aadmi the? Indian cinema's greatest action epic.",
                    Description = "A retired police commissioner hires two lovable rogues with hearts of gold to capture the sadistic dacoit Gabbar Singh who butchered his family. Official 4K full movie on NH Studioz.",
                    PosterUrl = "https://upload.wikimedia.org/wikipedia/en/5/52/Sholay-poster.jpg",
                    BackdropUrl = "https://img.youtube.com/vi/TR5Q0gnAPGU/maxresdefault.jpg",
                    OfficialThumbnailUrl = "https://img.youtube.com/vi/TR5Q0gnAPGU/maxresdefault.jpg",
                    YouTubeVideoId = "TR5Q0gnAPGU",
                    OfficialChannelName = "NH Studioz (Official)",
                    ReleaseYear = 1975, DurationMinutes = 204, AgeRating = "U/A 13+", Language = "Hindi", RegionCategory = "Bollywood", Country = "India",
                    ImdbRating = 8.1, ViewCount = 25000000, QualityBadge = "4K UHD",
                    IsFeatured = true, IsTrending = true, IsPopular = true, IsTopRated = true, IsFree = true, IsMustWatch = true,
                    Genres = new List<string> { "Action", "Adventure", "Drama" }, Director = "Ramesh Sippy",
                    Cast = new List<MovieCastItem>
                    {
                        new MovieCastItem { ActorName = "Amitabh Bachchan", CharacterName = "Jai", PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/9/91/Amitabh_Bachchan_photoshoot.jpg" },
                        new MovieCastItem { ActorName = "Dharmendra", CharacterName = "Veeru", PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/8/8c/Dharmendra_at_Gadar_2_success_party.jpg" }
                    }
                },
                new Movie
                {
                    Id = 30,
                    Title = "Deewaar",
                    Slug = "deewaar-1975",
                    Tagline = "Mere paas maa hai. The unforgettable moral clash between two brothers.",
                    Description = "Two impoverished brothers choose diverging paths: Vijay rises as an underworld kingpin driven by rage, while Ravi becomes an honest police officer tasked with bringing his brother to justice. Official movie on YouTube.",
                    PosterUrl = "https://upload.wikimedia.org/wikipedia/en/2/22/Deewaar_poster.jpg",
                    BackdropUrl = "https://img.youtube.com/vi/Xc9CN_zpJDc/maxresdefault.jpg",
                    OfficialThumbnailUrl = "https://img.youtube.com/vi/Xc9CN_zpJDc/maxresdefault.jpg",
                    YouTubeVideoId = "Xc9CN_zpJDc",
                    OfficialChannelName = "YouTube Movies (Official)",
                    ReleaseYear = 1975, DurationMinutes = 174, AgeRating = "U", Language = "Hindi", RegionCategory = "Bollywood", Country = "India",
                    ImdbRating = 8.0, ViewCount = 9200000, QualityBadge = "1080p FHD",
                    IsPopular = true, IsTopRated = true, IsFree = true, IsMustWatch = true,
                    Genres = new List<string> { "Action", "Crime", "Drama" }, Director = "Yash Chopra"
                },
                new Movie
                {
                    Id = 31,
                    Title = "Don (1978)",
                    Slug = "don-1978",
                    Tagline = "Don ko pakadna mushkil hi nahi, namumkin hai.",
                    Description = "When the elusive international crime kingpin Don is killed in a police shootout, a naive street lookalike is recruited by an inspector to infiltrate the cartel and capture the mastermind. Official full movie on Revere Records.",
                    PosterUrl = "https://upload.wikimedia.org/wikipedia/en/0/00/Don_1978_poster.jpg",
                    BackdropUrl = "https://img.youtube.com/vi/NPVzd_7UQRQ/maxresdefault.jpg",
                    OfficialThumbnailUrl = "https://img.youtube.com/vi/NPVzd_7UQRQ/maxresdefault.jpg",
                    YouTubeVideoId = "NPVzd_7UQRQ",
                    OfficialChannelName = "Revere Records (Official)",
                    ReleaseYear = 1978, DurationMinutes = 166, AgeRating = "U/A 13+", Language = "Hindi", RegionCategory = "Bollywood", Country = "India",
                    ImdbRating = 7.7, ViewCount = 8400000, QualityBadge = "1080p FHD",
                    IsTrending = true, IsPopular = true, IsTopRated = true, IsFree = true, IsMustWatch = true,
                    Genres = new List<string> { "Action", "Thriller", "Crime" }, Director = "Chandra Barot"
                },
                new Movie
                {
                    Id = 32,
                    Title = "Gol Maal (1979)",
                    Slug = "gol-maal-1979",
                    Tagline = "A mustache that launched a thousand laughs! Hrishikesh Mukherjee's comedy gem.",
                    Description = "A job seeker invents a fictional, mustache-less twin brother to appease his eccentric, anti-sports employer, triggering escalating deceptions in this golden comedy. Official full movie on NH Comedy Duniya.",
                    PosterUrl = "https://upload.wikimedia.org/wikipedia/en/9/91/Gol_Maal_poster.jpg",
                    BackdropUrl = "https://img.youtube.com/vi/jxPYbYeA-VQ/maxresdefault.jpg",
                    OfficialThumbnailUrl = "https://img.youtube.com/vi/jxPYbYeA-VQ/maxresdefault.jpg",
                    YouTubeVideoId = "jxPYbYeA-VQ",
                    OfficialChannelName = "NH Comedy Duniya (Official)",
                    ReleaseYear = 1979, DurationMinutes = 120, AgeRating = "U", Language = "Hindi", RegionCategory = "Bollywood", Country = "India",
                    ImdbRating = 8.5, ViewCount = 7200000, QualityBadge = "1080p FHD",
                    IsPopular = true, IsTopRated = true, IsFree = true, IsMustWatch = true,
                    Genres = new List<string> { "Comedy", "Romance" }, Director = "Hrishikesh Mukherjee"
                },
                new Movie
                {
                    Id = 33,
                    Title = "Chupke Chupke",
                    Slug = "chupke-chupke-1975",
                    Tagline = "The sweetest botanical prank in Indian cinema history.",
                    Description = "A newlywed botany professor disguises himself as an uneducated driver in his wife's brother-in-law's household to test the family's supposed judge of human character. Official full movie on NH Comedy Duniya.",
                    PosterUrl = "https://upload.wikimedia.org/wikipedia/en/f/f6/Chupke_Chupke.jpg",
                    BackdropUrl = "https://img.youtube.com/vi/ltaFcAoI30E/maxresdefault.jpg",
                    OfficialThumbnailUrl = "https://img.youtube.com/vi/ltaFcAoI30E/maxresdefault.jpg",
                    YouTubeVideoId = "ltaFcAoI30E",
                    OfficialChannelName = "NH Comedy Duniya (Official)",
                    ReleaseYear = 1975, DurationMinutes = 127, AgeRating = "U", Language = "Hindi", RegionCategory = "Bollywood", Country = "India",
                    ImdbRating = 8.3, ViewCount = 6900000, QualityBadge = "1080p FHD",
                    IsPopular = true, IsTopRated = true, IsFree = true, IsMustWatch = true,
                    Genres = new List<string> { "Comedy", "Romance", "Drama" }, Director = "Hrishikesh Mukherjee"
                },
                new Movie
                {
                    Id = 34,
                    Title = "Gharaonda",
                    Slug = "gharaonda-1977",
                    Tagline = "Building dreams brick by brick in Mumbai's towering skyline.",
                    Description = "Two middle-class sweethearts save every penny to buy a modest apartment in Mumbai, but when their builder absconds with the funds, heartbreak and compromise challenge their ideals. Official full movie on Goldmines Bollywood.",
                    PosterUrl = "https://upload.wikimedia.org/wikipedia/en/9/9d/Gharaonda_poster.jpg",
                    BackdropUrl = "https://img.youtube.com/vi/TLXMSYSu-Ig/maxresdefault.jpg",
                    OfficialThumbnailUrl = "https://img.youtube.com/vi/TLXMSYSu-Ig/maxresdefault.jpg",
                    YouTubeVideoId = "TLXMSYSu-Ig",
                    OfficialChannelName = "Goldmines Bollywood (Official)",
                    ReleaseYear = 1977, DurationMinutes = 138, AgeRating = "U", Language = "Hindi", RegionCategory = "Bollywood", Country = "India",
                    ImdbRating = 7.7, ViewCount = 4800000, QualityBadge = "1080p FHD",
                    IsPopular = true, IsTopRated = true, IsFree = true, IsMustWatch = true,
                    Genres = new List<string> { "Drama", "Romance" }, Director = "Bhimsain"
                },
                new Movie
                {
                    Id = 35,
                    Title = "Pati Patni",
                    Slug = "pati-patni-classic",
                    Tagline = "A classic domestic comedy of marital misunderstandings and laughter.",
                    Description = "A delightful social comedy exploring the quirks of marriage, traditional values, and heartwarming reconciliations starring Sanjeev Kumar, Mumtaz, and Mehmood. Official full movie on Rajshri Productions.",
                    PosterUrl = "https://upload.wikimedia.org/wikipedia/en/e/e0/Pati_Patni_1966.jpg",
                    BackdropUrl = "https://img.youtube.com/vi/w849fnZIuPk/maxresdefault.jpg",
                    OfficialThumbnailUrl = "https://img.youtube.com/vi/w849fnZIuPk/maxresdefault.jpg",
                    YouTubeVideoId = "w849fnZIuPk",
                    OfficialChannelName = "Rajshri Productions (Official)",
                    ReleaseYear = 1966, DurationMinutes = 145, AgeRating = "U", Language = "Hindi", RegionCategory = "Bollywood", Country = "India",
                    ImdbRating = 7.1, ViewCount = 3800000, QualityBadge = "1080p FHD",
                    IsPopular = true, IsFree = true, IsMustWatch = true,
                    Genres = new List<string> { "Comedy", "Drama" }, Director = "S.A. Akbar"
                },
                new Movie
                {
                    Id = 36,
                    Title = "Aarti",
                    Slug = "aarti-1962",
                    Tagline = "Sacrifice, love, and unwavering marital devotion.",
                    Description = "Aarti calls off her engagement to a wealthy suitor to marry an unemployed doctor who saved her life, bravely weathering extreme hardship and in-law conflicts. Official full movie on Rajshri Productions.",
                    PosterUrl = "https://upload.wikimedia.org/wikipedia/en/b/b3/Aarti_1962_film.jpg",
                    BackdropUrl = "https://img.youtube.com/vi/UU8J3zXoG8o/maxresdefault.jpg",
                    OfficialThumbnailUrl = "https://img.youtube.com/vi/UU8J3zXoG8o/maxresdefault.jpg",
                    YouTubeVideoId = "UU8J3zXoG8o",
                    OfficialChannelName = "Rajshri Productions (Official)",
                    ReleaseYear = 1962, DurationMinutes = 152, AgeRating = "U", Language = "Hindi", RegionCategory = "Bollywood", Country = "India",
                    ImdbRating = 7.3, ViewCount = 4100000, QualityBadge = "1080p FHD",
                    IsPopular = true, IsTopRated = true, IsFree = true, IsMustWatch = true,
                    Genres = new List<string> { "Drama", "Romance" }, Director = "Phani Majumdar"
                },
                new Movie
                {
                    Id = 37,
                    Title = "Nadiya Ke Paar",
                    Slug = "nadiya-ke-paar",
                    Tagline = "The original rural heartland love story that inspired Hum Aapke Hain Koun.",
                    Description = "Set in rural Uttar Pradesh, Chandan and Gunja fall in love, but fate and familial tragedy force difficult decisions about duty and romance. Official full movie on Rajshri Productions.",
                    PosterUrl = "https://upload.wikimedia.org/wikipedia/en/1/18/Nadiya_Ke_Paar_1982.jpg",
                    BackdropUrl = "https://img.youtube.com/vi/EuF5w3oiYnk/maxresdefault.jpg",
                    OfficialThumbnailUrl = "https://img.youtube.com/vi/EuF5w3oiYnk/maxresdefault.jpg",
                    YouTubeVideoId = "EuF5w3oiYnk",
                    OfficialChannelName = "Rajshri Productions (Official)",
                    ReleaseYear = 1982, DurationMinutes = 140, AgeRating = "U", Language = "Hindi", RegionCategory = "Bollywood", Country = "India",
                    ImdbRating = 7.8, ViewCount = 8900000, QualityBadge = "1080p FHD",
                    IsTrending = true, IsPopular = true, IsTopRated = true, IsFree = true, IsMustWatch = true,
                    Genres = new List<string> { "Romance", "Drama", "Family" }, Director = "Govind Moonis"
                },
                new Movie
                {
                    Id = 38,
                    Title = "Vishwatma",
                    Slug = "vishwatma-action",
                    Tagline = "Saat Samundar Paar! High-voltage Bollywood action in Kenya.",
                    Description = "Three determined Indian operatives are sent to Nairobi to hunt down the dangerous crime lord Azghar Jurrat who fled Indian justice. Official 4K full movie on Shemaroo Movies.",
                    PosterUrl = "https://upload.wikimedia.org/wikipedia/en/4/4b/Vishwatma_poster.jpg",
                    BackdropUrl = "https://img.youtube.com/vi/N5ocp5a5XK8/maxresdefault.jpg",
                    OfficialThumbnailUrl = "https://img.youtube.com/vi/N5ocp5a5XK8/maxresdefault.jpg",
                    YouTubeVideoId = "N5ocp5a5XK8",
                    OfficialChannelName = "Shemaroo Movies (Official)",
                    ReleaseYear = 1992, DurationMinutes = 176, AgeRating = "U/A 13+", Language = "Hindi", RegionCategory = "Bollywood", Country = "India",
                    ImdbRating = 6.3, ViewCount = 11200000, QualityBadge = "4K UHD",
                    IsTrending = true, IsPopular = true, IsFree = true, IsMustWatch = true,
                    Genres = new List<string> { "Action", "Thriller" }, Director = "Rajiv Rai"
                },
                new Movie
                {
                    Id = 39,
                    Title = "Ajay",
                    Slug = "ajay-sunny-deol",
                    Tagline = "A fearless man fights a corrupt feudal kingdom for love and dignity.",
                    Description = "Ajay, an honest and principled young man, falls in love with Manorama, whose ruthless feudal family will stop at nothing to eradicate him. Official full movie on Shemaroo Movies.",
                    PosterUrl = "https://upload.wikimedia.org/wikipedia/en/2/23/Ajay_1996.jpg",
                    BackdropUrl = "https://img.youtube.com/vi/AVLwfpA4vXU/maxresdefault.jpg",
                    OfficialThumbnailUrl = "https://img.youtube.com/vi/AVLwfpA4vXU/maxresdefault.jpg",
                    YouTubeVideoId = "AVLwfpA4vXU",
                    OfficialChannelName = "Shemaroo Movies (Official)",
                    ReleaseYear = 1996, DurationMinutes = 150, AgeRating = "U/A 13+", Language = "Hindi", RegionCategory = "Bollywood", Country = "India",
                    ImdbRating = 6.2, ViewCount = 9800000, QualityBadge = "1080p FHD",
                    IsPopular = true, IsFree = true, IsMustWatch = true,
                    Genres = new List<string> { "Action", "Romance", "Drama" }, Director = "Suneel Darshan"
                },
                new Movie
                {
                    Id = 40,
                    Title = "Khatta Meetha",
                    Slug = "khatta-meetha",
                    Tagline = "Sachin Tichkule's hilarious struggle against government bureaucracy.",
                    Description = "A struggling, broke road contractor tries to navigate absurd government red tape, corrupt municipal officials, and eccentric relatives in Priyadarshan's biting satire. Official full movie on Shemaroo Movies.",
                    PosterUrl = "https://upload.wikimedia.org/wikipedia/en/a/a2/Khatta_Meetha_2010_poster.jpg",
                    BackdropUrl = "https://img.youtube.com/vi/3RxIqTUbkj8/maxresdefault.jpg",
                    OfficialThumbnailUrl = "https://img.youtube.com/vi/3RxIqTUbkj8/maxresdefault.jpg",
                    YouTubeVideoId = "3RxIqTUbkj8",
                    OfficialChannelName = "Shemaroo Movies (Official)",
                    ReleaseYear = 2010, DurationMinutes = 157, AgeRating = "U/A 13+", Language = "Hindi", RegionCategory = "Bollywood", Country = "India",
                    ImdbRating = 6.0, ViewCount = 13500000, QualityBadge = "1080p FHD",
                    IsTrending = true, IsPopular = true, IsFree = true, IsMustWatch = true,
                    Genres = new List<string> { "Comedy", "Drama" }, Director = "Priyadarshan"
                },
                new Movie
                {
                    Id = 41,
                    Title = "Hulchul",
                    Slug = "hulchul-comedy",
                    Tagline = "Fake romance ignites real family warfare! Priyadarshan's laugh marathon.",
                    Description = "Two warring feudal families clash again when young Anjali and Jai pretend to be in love to avenge previous grudges, only for real romance to turn both dynasties upside down. Official full movie on Bolly Comedy.",
                    PosterUrl = "https://upload.wikimedia.org/wikipedia/en/e/eb/Hulchul_2004_poster.jpg",
                    BackdropUrl = "https://img.youtube.com/vi/OA0nc6vZwcA/maxresdefault.jpg",
                    OfficialThumbnailUrl = "https://img.youtube.com/vi/OA0nc6vZwcA/maxresdefault.jpg",
                    YouTubeVideoId = "OA0nc6vZwcA",
                    OfficialChannelName = "Bolly Comedy (Official)",
                    ReleaseYear = 2004, DurationMinutes = 150, AgeRating = "U", Language = "Hindi", RegionCategory = "Bollywood", Country = "India",
                    ImdbRating = 7.1, ViewCount = 16200000, QualityBadge = "1080p FHD",
                    IsTrending = true, IsPopular = true, IsTopRated = true, IsFree = true, IsMustWatch = true,
                    Genres = new List<string> { "Comedy", "Drama", "Romance" }, Director = "Priyadarshan"
                },
                new Movie
                {
                    Id = 42,
                    Title = "Zubeidaa",
                    Slug = "zubeidaa-drama",
                    Tagline = "The tragic and passionate secret life of a royal princess.",
                    Description = "A young journalist pieces together the mysterious, passionate life of his late mother, who abandoned her family to marry a royal prince in Rajasthan. Official full movie on Shemaroo Movies.",
                    PosterUrl = "https://upload.wikimedia.org/wikipedia/en/b/b5/Zubeidaa.jpg",
                    BackdropUrl = "https://img.youtube.com/vi/Ny9GQPRIh2A/maxresdefault.jpg",
                    OfficialThumbnailUrl = "https://img.youtube.com/vi/Ny9GQPRIh2A/maxresdefault.jpg",
                    YouTubeVideoId = "Ny9GQPRIh2A",
                    OfficialChannelName = "Shemaroo Movies (Official)",
                    ReleaseYear = 2001, DurationMinutes = 153, AgeRating = "U/A 13+", Language = "Hindi", RegionCategory = "Bollywood", Country = "India",
                    ImdbRating = 6.2, ViewCount = 5400000, QualityBadge = "1080p FHD",
                    IsPopular = true, IsTopRated = true, IsFree = true, IsMustWatch = true,
                    Genres = new List<string> { "Drama", "Romance" }, Director = "Shyam Benegal"
                },
                new Movie
                {
                    Id = 43,
                    Title = "Commando 2: The Black Money Trail",
                    Slug = "commando-2",
                    Tagline = "A one-man army unleashed against international money laundering cartels.",
                    Description = "Captain Karanvir Singh Dogra leads an elite team to Malaysia to extradite Vicky Chaddha, the shadowy banker managing billions in illicit black money. Official 4K full movie on Shemaroo.",
                    PosterUrl = "https://upload.wikimedia.org/wikipedia/en/6/67/Commando_2_poster.jpg",
                    BackdropUrl = "https://img.youtube.com/vi/SG0bvpT101c/maxresdefault.jpg",
                    OfficialThumbnailUrl = "https://img.youtube.com/vi/SG0bvpT101c/maxresdefault.jpg",
                    YouTubeVideoId = "SG0bvpT101c",
                    OfficialChannelName = "Shemaroo (Official)",
                    ReleaseYear = 2017, DurationMinutes = 144, AgeRating = "A", Language = "Hindi", RegionCategory = "Bollywood", Country = "India",
                    ImdbRating = 5.4, ViewCount = 14800000, QualityBadge = "4K UHD",
                    IsTrending = true, IsPopular = true, IsFree = true, IsMustWatch = true,
                    Genres = new List<string> { "Action", "Thriller" }, Director = "Deven Bhojani"
                },
                new Movie
                {
                    Id = 44,
                    Title = "Khamoshi: The Musical",
                    Slug = "khamoshi-the-musical",
                    Tagline = "Words may be silent, but hearts sing an immortal symphony.",
                    Description = "Annie, the daughter of deaf-mute parents, is blessed with an ethereal musical gift. When she falls in love with a composer, family loyalty and artistic passion collide. Official 4K full movie on Ultra Movie Parlour.",
                    PosterUrl = "https://upload.wikimedia.org/wikipedia/en/f/f6/Khamoshi_The_Musical_1996.jpg",
                    BackdropUrl = "https://img.youtube.com/vi/guam2wqXtUo/maxresdefault.jpg",
                    OfficialThumbnailUrl = "https://img.youtube.com/vi/guam2wqXtUo/maxresdefault.jpg",
                    YouTubeVideoId = "guam2wqXtUo",
                    OfficialChannelName = "Ultra Movie Parlour (Official)",
                    ReleaseYear = 1996, DurationMinutes = 160, AgeRating = "U", Language = "Hindi", RegionCategory = "Bollywood", Country = "India",
                    ImdbRating = 7.5, ViewCount = 6700000, QualityBadge = "4K UHD",
                    IsPopular = true, IsTopRated = true, IsFree = true, IsMustWatch = true,
                    Genres = new List<string> { "Drama", "Musical", "Romance" }, Director = "Sanjay Leela Bhansali"
                },
                new Movie
                {
                    Id = 45,
                    Title = "1947 Earth",
                    Slug = "1947-earth",
                    Tagline = "Friendships shattered by borders. Deepa Mehta's powerful historic drama.",
                    Description = "A group of friends in 1947 Lahore find their secular camaraderie torn apart as the religious violence of Partition engulfs their city, seen through the eyes of an eight-year-old girl. Official 4K full movie on Ultra Movie Parlour.",
                    PosterUrl = "https://upload.wikimedia.org/wikipedia/en/c/c9/1947_Earth.jpg",
                    BackdropUrl = "https://img.youtube.com/vi/0raE72NeTmM/maxresdefault.jpg",
                    OfficialThumbnailUrl = "https://img.youtube.com/vi/0raE72NeTmM/maxresdefault.jpg",
                    YouTubeVideoId = "0raE72NeTmM",
                    OfficialChannelName = "Ultra Movie Parlour (Official)",
                    ReleaseYear = 1998, DurationMinutes = 110, AgeRating = "A", Language = "Hindi", RegionCategory = "Bollywood", Country = "India",
                    ImdbRating = 7.7, ViewCount = 8200000, QualityBadge = "4K UHD",
                    IsFeatured = true, IsTrending = true, IsPopular = true, IsTopRated = true, IsFree = true, IsMustWatch = true,
                    Genres = new List<string> { "Drama", "Romance" }, Director = "Deepa Mehta"
                },

                // === OPEN MOVIES & HOLLYWOOD / PAN-INDIA CINEMA (Ids 1 to 18) ===
                new Movie
                {
                    Id = 1,
                    Title = "Tears of Steel",
                    Slug = "tears-of-steel",
                    Tagline = "What if humanity's past meets futuristic cybernetic warfare in Amsterdam?",
                    Description = "A dystopian sci-fi short film set in futuristic Amsterdam where scientists attempt to alter the past to rescue humanity from destructive cyborgs. Officially released by Blender Foundation under Creative Commons.",
                    PosterUrl = "https://upload.wikimedia.org/wikipedia/commons/4/41/Tears_of_Steel_poster.jpg",
                    BackdropUrl = "https://img.youtube.com/vi/R6MlUcmOul8/maxresdefault.jpg",
                    OfficialThumbnailUrl = "https://img.youtube.com/vi/R6MlUcmOul8/maxresdefault.jpg",
                    YouTubeVideoId = "R6MlUcmOul8",
                    OfficialChannelName = "Blender Studio (Official)",
                    ReleaseYear = 2012, DurationMinutes = 12, AgeRating = "U/A 13+", Language = "English", RegionCategory = "Hollywood", Country = "Netherlands",
                    ImdbRating = 7.1, ViewCount = 142050, QualityBadge = "4K UHD",
                    IsFeatured = true, IsTrending = true, IsPopular = true, IsFree = true,
                    Genres = new List<string> { "Science Fiction", "Action" }, Director = "Ian Hubert"
                },
                new Movie
                {
                    Id = 2,
                    Title = "Sita Sings the Blues",
                    Slug = "sita-sings-the-blues",
                    Tagline = "The world's first animated mythological jazz blues epic.",
                    Description = "Acclaimed animated feature combining the ancient Indian epic Ramayana with 1920s jazz vocals by Annette Hanshaw. Nina Paley created and dedicated this masterpiece to the public domain.",
                    PosterUrl = "https://upload.wikimedia.org/wikipedia/commons/e/e0/Sita_Sings_the_Blues_poster.jpg",
                    BackdropUrl = "https://img.youtube.com/vi/f8LvBnz7oRA/maxresdefault.jpg",
                    OfficialThumbnailUrl = "https://img.youtube.com/vi/f8LvBnz7oRA/maxresdefault.jpg",
                    YouTubeVideoId = "f8LvBnz7oRA",
                    OfficialChannelName = "Nina Paley Public Domain Archives",
                    ReleaseYear = 2008, DurationMinutes = 82, AgeRating = "U", Language = "English", RegionCategory = "Bollywood", Country = "India/USA",
                    ImdbRating = 7.6, ViewCount = 98740, QualityBadge = "1080p FHD",
                    IsTrending = true, IsPopular = true, IsTopRated = true, IsFree = true,
                    Genres = new List<string> { "Animation", "Musical", "Drama" }, Director = "Nina Paley"
                },
                new Movie
                {
                    Id = 3,
                    Title = "Big Buck Bunny",
                    Slug = "big-buck-bunny",
                    Tagline = "A large rabbit with a bigger heart and zero patience for bullies.",
                    Description = "A heartwarming and hilarious animated adventure following a giant woodland rabbit who decides to teach mischievous forest rodents a lesson in kindness. Created by Blender Institute.",
                    PosterUrl = "https://upload.wikimedia.org/wikipedia/commons/c/c5/Big_buck_bunny_poster_big.jpg",
                    BackdropUrl = "https://img.youtube.com/vi/aqz-KE-bpKQ/maxresdefault.jpg",
                    OfficialThumbnailUrl = "https://img.youtube.com/vi/aqz-KE-bpKQ/maxresdefault.jpg",
                    YouTubeVideoId = "aqz-KE-bpKQ",
                    OfficialChannelName = "Blender Studio (Official)",
                    ReleaseYear = 2008, DurationMinutes = 10, AgeRating = "U", Language = "English", RegionCategory = "Hollywood", Country = "Netherlands",
                    ImdbRating = 7.8, ViewCount = 310500, QualityBadge = "4K UHD",
                    IsPopular = true, IsRecentlyAdded = true, IsTopRated = true, IsFree = true,
                    Genres = new List<string> { "Animation", "Comedy" }, Director = "Sacha Goedegebure"
                },
                new Movie
                {
                    Id = 4,
                    Title = "Night of the Living Dead",
                    Slug = "night-of-the-living-dead",
                    Tagline = "They keep coming back in a night of unrelenting terror.",
                    Description = "George A. Romero's iconic groundbreaking horror masterpiece following seven strangers trapped in a rural Pennsylvania farmhouse besieged by reanimated corpses. Public domain milestone.",
                    PosterUrl = "https://upload.wikimedia.org/wikipedia/commons/1/15/Night_of_the_Living_Dead_theatrical_poster.jpg",
                    BackdropUrl = "https://img.youtube.com/vi/H91BxkBXttE/maxresdefault.jpg",
                    OfficialThumbnailUrl = "https://img.youtube.com/vi/H91BxkBXttE/maxresdefault.jpg",
                    YouTubeVideoId = "H91BxkBXttE",
                    OfficialChannelName = "Public Domain Cinema Classics",
                    ReleaseYear = 1968, DurationMinutes = 96, AgeRating = "A", Language = "English", RegionCategory = "Hollywood", Country = "USA",
                    ImdbRating = 7.9, ViewCount = 215400, QualityBadge = "1080p FHD",
                    IsTrending = true, IsPopular = true, IsTopRated = true, IsFree = true,
                    Genres = new List<string> { "Horror", "Mystery" }, Director = "George A. Romero"
                },
                new Movie
                {
                    Id = 5,
                    Title = "The General (Buster Keaton)",
                    Slug = "the-general-buster-keaton",
                    Tagline = "The greatest comedic railway chase ever put to celluloid.",
                    Description = "Buster Keaton's legendary silent comedy masterpiece featuring death-defying real stunts on moving locomotives during the Civil War. Preserved and legally embeddable via Public Domain Cinema.",
                    PosterUrl = "https://upload.wikimedia.org/wikipedia/commons/c/c7/The_General_%281926_film%29_poster.jpg",
                    BackdropUrl = "https://img.youtube.com/vi/D_UdtS-8QS0/maxresdefault.jpg",
                    OfficialThumbnailUrl = "https://img.youtube.com/vi/D_UdtS-8QS0/maxresdefault.jpg",
                    YouTubeVideoId = "D_UdtS-8QS0",
                    OfficialChannelName = "Classic Movie Archive",
                    ReleaseYear = 1926, DurationMinutes = 75, AgeRating = "U", Language = "Silent / Music", RegionCategory = "Hollywood", Country = "USA",
                    ImdbRating = 8.1, ViewCount = 185000, QualityBadge = "1080p FHD",
                    IsPopular = true, IsTopRated = true, IsFree = true,
                    Genres = new List<string> { "Comedy", "Adventure", "Action" }, Director = "Buster Keaton"
                },
                new Movie
                {
                    Id = 6,
                    Title = "Spring (Blender Open Movie)",
                    Slug = "spring-blender-movie",
                    Tagline = "A shepherd girl awakens the spirits of the ancient seasons.",
                    Description = "A breathtaking fantasy adventure of a shepherd girl and her loyal dog who venture into the alpine clouds to awaken springtime and ward off eternal winter. Rendered entirely with open source tools.",
                    PosterUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e2/Spring_-_Blender_Open_Movie.webm/page1-1280px-Spring_-_Blender_Open_Movie.webm.jpg",
                    BackdropUrl = "https://img.youtube.com/vi/WhWc3b3KhnY/maxresdefault.jpg",
                    OfficialThumbnailUrl = "https://img.youtube.com/vi/WhWc3b3KhnY/maxresdefault.jpg",
                    YouTubeVideoId = "WhWc3b3KhnY",
                    OfficialChannelName = "Blender Studio (Official)",
                    ReleaseYear = 2019, DurationMinutes = 8, AgeRating = "U", Language = "Music / Fantasy", RegionCategory = "Hollywood", Country = "Netherlands",
                    ImdbRating = 7.7, ViewCount = 120000, QualityBadge = "4K UHD",
                    IsTrending = true, IsTopRated = true, IsFree = true,
                    Genres = new List<string> { "Animation", "Fantasy" }, Director = "Andy Goralczyk"
                },
                new Movie
                {
                    Id = 7,
                    Title = "Charge (Blender Sci-Fi CGI)",
                    Slug = "charge-blender-sci-fi",
                    Tagline = "An old android fights to maintain power in a neon-drenched storm.",
                    Description = "An old, battery-drained security android wages a desperate battle against relentless robotic enforcers in an abandoned power station. Official Blender Open Movie short.",
                    PosterUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/62/Charge_-_Blender_Open_Movie.webm/page1-1280px-Charge_-_Blender_Open_Movie.webm.jpg",
                    BackdropUrl = "https://img.youtube.com/vi/UXqq0ZvbOnk/maxresdefault.jpg",
                    OfficialThumbnailUrl = "https://img.youtube.com/vi/UXqq0ZvbOnk/maxresdefault.jpg",
                    YouTubeVideoId = "UXqq0ZvbOnk",
                    OfficialChannelName = "Blender Studio (Official)",
                    ReleaseYear = 2022, DurationMinutes = 4, AgeRating = "U/A 13+", Language = "English", RegionCategory = "Hollywood", Country = "Netherlands",
                    ImdbRating = 7.5, ViewCount = 95000, QualityBadge = "4K UHD",
                    IsTrending = true, IsFree = true,
                    Genres = new List<string> { "Science Fiction", "Action" }, Director = "Hjalti Hjalmarsson"
                },
                new Movie
                {
                    Id = 8,
                    Title = "Oppenheimer: The Epic Saga",
                    Slug = "oppenheimer-epic-saga",
                    Tagline = "The world forever changes when humanity unleashes the secret fire.",
                    Description = "The monumental, multi-Oscar winning biographical drama charting J. Robert Oppenheimer's role in the Manhattan Project and the moral labyrinth that followed the dawn of the atomic age.",
                    PosterUrl = "https://upload.wikimedia.org/wikipedia/en/4/4a/Oppenheimer_%28film%29.jpg",
                    BackdropUrl = "https://img.youtube.com/vi/uYPbbksJxIg/maxresdefault.jpg",
                    OfficialThumbnailUrl = "https://img.youtube.com/vi/uYPbbksJxIg/maxresdefault.jpg",
                    YouTubeVideoId = "uYPbbksJxIg",
                    OfficialChannelName = "Universal Pictures",
                    ReleaseYear = 2023, DurationMinutes = 180, AgeRating = "A", Language = "English", RegionCategory = "Hollywood", Country = "USA",
                    ImdbRating = 8.9, ViewCount = 7400000, QualityBadge = "4K UHD",
                    IsFeatured = true, IsTrending = true, IsPopular = true, IsTopRated = true, IsFree = false, IsPremium = true,
                    RentalPriceInr = 149, PurchasePriceInr = 499,
                    Genres = new List<string> { "Drama", "History", "Thriller" }, Director = "Christopher Nolan",
                    Cast = new List<MovieCastItem>
                    {
                        new MovieCastItem { ActorName = "Cillian Murphy", CharacterName = "J. Robert Oppenheimer", PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/a/a5/Cillian_Murphy_at_Berlinale_2024.jpg" }
                    }
                },
                new Movie
                {
                    Id = 9,
                    Title = "RRR: Rise Roar Revolt",
                    Slug = "rrr-rise-roar-revolt",
                    Tagline = "Fire and water unite to forge an invincible revolution.",
                    Description = "A fictionalized tale of two legendary Indian revolutionaries, Alluri Sitarama Raju and Komaram Bheem, who forge a fiery brotherhood before embarking on an epic struggle against British colonial rule.",
                    PosterUrl = "https://upload.wikimedia.org/wikipedia/en/d/d7/RRR_Poster.jpg",
                    BackdropUrl = "https://img.youtube.com/vi/NgBoMJy386M/maxresdefault.jpg",
                    OfficialThumbnailUrl = "https://img.youtube.com/vi/NgBoMJy386M/maxresdefault.jpg",
                    YouTubeVideoId = "NgBoMJy386M",
                    OfficialChannelName = "DVV Entertainment",
                    ReleaseYear = 2022, DurationMinutes = 187, AgeRating = "U/A 16+", Language = "Telugu / Hindi", RegionCategory = "Regional Cinema", Country = "India",
                    ImdbRating = 8.8, ViewCount = 8900000, QualityBadge = "4K UHD",
                    IsFeatured = true, IsTrending = true, IsPopular = true, IsTopRated = true, IsFree = false, IsPremium = true,
                    RentalPriceInr = 99, PurchasePriceInr = 299,
                    Genres = new List<string> { "Action", "Drama", "Regional Cinema" }, Director = "S.S. Rajamouli"
                },
                new Movie
                {
                    Id = 10,
                    Title = "Jawan",
                    Slug = "jawan-srk",
                    Tagline = "Ready? An electrifying quest to rectify the wrongs in society.",
                    Description = "A prison warden recruits inmates to commit outrageous heists that shed light on corruption and injustice, leading to an emotional reunion with his long-lost father who was framed for treason.",
                    PosterUrl = "https://upload.wikimedia.org/wikipedia/en/3/39/Jawan_film_poster.jpg",
                    BackdropUrl = "https://img.youtube.com/vi/MWOlnZSnXJo/maxresdefault.jpg",
                    OfficialThumbnailUrl = "https://img.youtube.com/vi/MWOlnZSnXJo/maxresdefault.jpg",
                    YouTubeVideoId = "MWOlnZSnXJo",
                    OfficialChannelName = "Red Chillies Entertainment",
                    ReleaseYear = 2023, DurationMinutes = 169, AgeRating = "U/A 16+", Language = "Hindi", RegionCategory = "Bollywood", Country = "India",
                    ImdbRating = 7.1, ViewCount = 5200000, QualityBadge = "4K UHD",
                    IsFeatured = true, IsTrending = true, IsPopular = true, IsFree = false, IsPremium = true,
                    RentalPriceInr = 99, PurchasePriceInr = 299,
                    Genres = new List<string> { "Action", "Thriller", "Drama" }, Director = "Atlee",
                    Cast = new List<MovieCastItem>
                    {
                        new MovieCastItem { ActorName = "Shah Rukh Khan", CharacterName = "Vikram Rathore / Azad", PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/6/6e/Shah_Rukh_Khan_graces_the_launch_of_the_new_Santro.jpg" },
                        new MovieCastItem { ActorName = "Deepika Padukone", CharacterName = "Aishwarya Rathore", PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/b/b6/Deepika_Padukone_Cannes_2018_%28cropped%29.jpg" }
                    }
                },
                new Movie
                {
                    Id = 11,
                    Title = "Inception: Dream Architecture",
                    Slug = "inception-dream-architecture",
                    Tagline = "Your mind is the scene of the crime.",
                    Description = "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a CEO in Nolan's mind-bending masterpiece.",
                    PosterUrl = "https://upload.wikimedia.org/wikipedia/en/2/2e/Inception_%282010%29_theatrical_poster.jpg",
                    BackdropUrl = "https://img.youtube.com/vi/YoHD9XEInc0/maxresdefault.jpg",
                    OfficialThumbnailUrl = "https://img.youtube.com/vi/YoHD9XEInc0/maxresdefault.jpg",
                    YouTubeVideoId = "YoHD9XEInc0",
                    OfficialChannelName = "Warner Bros. Pictures",
                    ReleaseYear = 2010, DurationMinutes = 148, AgeRating = "U/A 13+", Language = "English", RegionCategory = "Hollywood", Country = "USA",
                    ImdbRating = 8.8, ViewCount = 5800000, QualityBadge = "4K UHD",
                    IsPopular = true, IsTopRated = true, IsFree = false, IsPremium = true,
                    RentalPriceInr = 99, PurchasePriceInr = 299,
                    Genres = new List<string> { "Science Fiction", "Action", "Thriller" }, Director = "Christopher Nolan",
                    Cast = new List<MovieCastItem>
                    {
                        new MovieCastItem { ActorName = "Leonardo DiCaprio", CharacterName = "Dom Cobb", PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/4/46/Leonardo_Dicaprio_Cannes_2019.jpg" }
                    }
                },
                new Movie
                {
                    Id = 12,
                    Title = "Kalki 2898 AD",
                    Slug = "kalki-2898-ad",
                    Tagline = "The beginning of the end of Kali Yuga.",
                    Description = "A futuristic sci-fi mythology epic set in the dystopian city of Kasi in 2898 AD where an invincible protector guards a sacred unborn savior prophecy from an immortal tyrant.",
                    PosterUrl = "https://upload.wikimedia.org/wikipedia/en/4/4c/Kalki_2898_AD.jpg",
                    BackdropUrl = "https://img.youtube.com/vi/kQDd1AhGIHk/maxresdefault.jpg",
                    OfficialThumbnailUrl = "https://img.youtube.com/vi/kQDd1AhGIHk/maxresdefault.jpg",
                    YouTubeVideoId = "kQDd1AhGIHk",
                    OfficialChannelName = "Vyjayanthi Network",
                    ReleaseYear = 2024, DurationMinutes = 181, AgeRating = "U/A 16+", Language = "Telugu / Hindi", RegionCategory = "Regional Cinema", Country = "India",
                    ImdbRating = 8.3, ViewCount = 4100000, QualityBadge = "4K UHD HDR",
                    IsFeatured = true, IsTrending = true, IsPopular = true, IsTopRated = true, IsFree = false, IsPremium = true,
                    RentalPriceInr = 149, PurchasePriceInr = 499,
                    Genres = new List<string> { "Action", "Science Fiction", "Regional Cinema" }, Director = "Nag Ashwin",
                    Cast = new List<MovieCastItem>
                    {
                        new MovieCastItem { ActorName = "Prabhas", CharacterName = "Bhairava", PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/e/ec/Prabhas_at_Saaho_Interview.jpg" },
                        new MovieCastItem { ActorName = "Amitabh Bachchan", CharacterName = "Ashwatthama", PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/9/91/Amitabh_Bachchan_photoshoot.jpg" },
                        new MovieCastItem { ActorName = "Deepika Padukone", CharacterName = "SUM-80", PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/b/b6/Deepika_Padukone_Cannes_2018_%28cropped%29.jpg" }
                    }
                },
                new Movie
                {
                    Id = 13,
                    Title = "John Wick: Chapter 4",
                    Slug = "john-wick-chapter-4",
                    Tagline = "No way back. One way out.",
                    Description = "John Wick uncovers a path to defeating The High Table, but before he can earn his freedom, he must face off against a new enemy with powerful alliances across Paris, Osaka, and Berlin.",
                    PosterUrl = "https://upload.wikimedia.org/wikipedia/en/0/07/John_Wick_-_Chapter_4_promotional_poster.jpg",
                    BackdropUrl = "https://img.youtube.com/vi/qEVUtrk8_B4/maxresdefault.jpg",
                    OfficialThumbnailUrl = "https://img.youtube.com/vi/qEVUtrk8_B4/maxresdefault.jpg",
                    YouTubeVideoId = "qEVUtrk8_B4",
                    OfficialChannelName = "Lionsgate Movies",
                    ReleaseYear = 2023, DurationMinutes = 169, AgeRating = "A", Language = "English", RegionCategory = "Hollywood", Country = "USA",
                    ImdbRating = 8.0, ViewCount = 2800000, QualityBadge = "4K UHD",
                    IsTrending = true, IsPopular = true, IsTopRated = true, IsFree = false, IsPremium = true,
                    RentalPriceInr = 149, PurchasePriceInr = 399,
                    Genres = new List<string> { "Action", "Crime", "Thriller" }, Director = "Chad Stahelski"
                },
                new Movie
                {
                    Id = 14,
                    Title = "Pathaan: Shadow Protocol",
                    Slug = "pathaan-shadow-protocol",
                    Tagline = "Apni kursi ki peti baandh lo.",
                    Description = "An Indian secret agent embarks on a dangerous globe-trotting mission to stop a vengeful private mercenary syndicate from detonating a biological weapon on Indian soil.",
                    PosterUrl = "https://upload.wikimedia.org/wikipedia/en/c/c3/Pathaan_film_poster.jpg",
                    BackdropUrl = "https://img.youtube.com/vi/vqu4z34wENw/maxresdefault.jpg",
                    OfficialThumbnailUrl = "https://img.youtube.com/vi/vqu4z34wENw/maxresdefault.jpg",
                    YouTubeVideoId = "vqu4z34wENw",
                    OfficialChannelName = "YRF Spy Universe",
                    ReleaseYear = 2023, DurationMinutes = 146, AgeRating = "U/A 13+", Language = "Hindi", RegionCategory = "Bollywood", Country = "India",
                    ImdbRating = 7.5, ViewCount = 2950000, QualityBadge = "4K UHD",
                    IsPopular = true, IsFree = false, IsPremium = true,
                    RentalPriceInr = 99, PurchasePriceInr = 299,
                    Genres = new List<string> { "Action", "Thriller" }, Director = "Siddharth Anand",
                    Cast = new List<MovieCastItem>
                    {
                        new MovieCastItem { ActorName = "Shah Rukh Khan", CharacterName = "Pathaan", PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/6/6e/Shah_Rukh_Khan_graces_the_launch_of_the_new_Santro.jpg" },
                        new MovieCastItem { ActorName = "Deepika Padukone", CharacterName = "Rubina Mohsin", PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/b/b6/Deepika_Padukone_Cannes_2018_%28cropped%29.jpg" }
                    }
                },
                new Movie
                {
                    Id = 15,
                    Title = "Interstellar: Across Space & Time",
                    Slug = "interstellar-space-time",
                    Tagline = "Mankind was born on Earth. It was never meant to die here.",
                    Description = "When Earth becomes uninhabitable, an ex-NASA pilot is recruited to fly a spacecraft through a mysterious wormhole near Saturn to find a viable new home planet for human survival.",
                    PosterUrl = "https://upload.wikimedia.org/wikipedia/en/b/bc/Interstellar_film_poster.jpg",
                    BackdropUrl = "https://img.youtube.com/vi/zSWdZVtXT7E/maxresdefault.jpg",
                    OfficialThumbnailUrl = "https://img.youtube.com/vi/zSWdZVtXT7E/maxresdefault.jpg",
                    YouTubeVideoId = "zSWdZVtXT7E",
                    OfficialChannelName = "Warner Bros. Pictures",
                    ReleaseYear = 2014, DurationMinutes = 169, AgeRating = "U/A 13+", Language = "English", RegionCategory = "Hollywood", Country = "USA",
                    ImdbRating = 8.7, ViewCount = 6200000, QualityBadge = "4K UHD HDR",
                    IsTrending = true, IsPopular = true, IsTopRated = true, IsFree = false, IsPremium = true,
                    RentalPriceInr = 99, PurchasePriceInr = 299,
                    Genres = new List<string> { "Science Fiction", "Drama", "Adventure" }, Director = "Christopher Nolan"
                },
                new Movie
                {
                    Id = 16,
                    Title = "Salaar: Part 1 – Ceasefire",
                    Slug = "salaar-ceasefire",
                    Tagline = "Blood, friendship, and the kingdom of Khansaar.",
                    Description = "In the lawless dystopian city-state of Khansaar, a fiercely loyal warrior emerges from exile to fulfill an oath and defend his childhood friend against ruthless criminal syndicates.",
                    PosterUrl = "https://upload.wikimedia.org/wikipedia/en/a/a6/Salaar_Part_1_%E2%80%93_Ceasefire.jpg",
                    BackdropUrl = "https://img.youtube.com/vi/HihakYi5M2I/maxresdefault.jpg",
                    OfficialThumbnailUrl = "https://img.youtube.com/vi/HihakYi5M2I/maxresdefault.jpg",
                    YouTubeVideoId = "HihakYi5M2I",
                    OfficialChannelName = "Hombale Films",
                    ReleaseYear = 2023, DurationMinutes = 175, AgeRating = "A", Language = "Telugu", RegionCategory = "Regional Cinema", Country = "India",
                    ImdbRating = 7.8, ViewCount = 2100000, QualityBadge = "4K UHD",
                    IsTrending = true, IsPopular = true, IsFree = false, IsPremium = true,
                    RentalPriceInr = 99, PurchasePriceInr = 299,
                    Genres = new List<string> { "Action", "Drama", "Regional Cinema" }, Director = "Prashanth Neel",
                    Cast = new List<MovieCastItem>
                    {
                        new MovieCastItem { ActorName = "Prabhas", CharacterName = "Deva / Salaar", PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/e/ec/Prabhas_at_Saaho_Interview.jpg" }
                    }
                },
                new Movie
                {
                    Id = 17,
                    Title = "12th Fail: Restart",
                    Slug = "12th-fail-restart",
                    Tagline = "Haar nahi maanunga, restart karunga.",
                    Description = "The inspiring real-life journey of Manoj Kumar Sharma, who overcomes extreme poverty, corruption, and numerous setbacks in Chambal to become an upright IPS officer.",
                    PosterUrl = "https://upload.wikimedia.org/wikipedia/en/f/f2/12th_Fail_poster.jpeg",
                    BackdropUrl = "https://img.youtube.com/vi/KjbtuqENvVE/maxresdefault.jpg",
                    OfficialThumbnailUrl = "https://img.youtube.com/vi/KjbtuqENvVE/maxresdefault.jpg",
                    YouTubeVideoId = "KjbtuqENvVE",
                    OfficialChannelName = "Vidhu Vinod Chopra Films",
                    ReleaseYear = 2023, DurationMinutes = 147, AgeRating = "U", Language = "Hindi", RegionCategory = "Bollywood", Country = "India",
                    ImdbRating = 8.9, ViewCount = 3400000, QualityBadge = "1080p FHD",
                    IsTrending = true, IsPopular = true, IsTopRated = true, IsFree = false, IsPremium = true,
                    RentalPriceInr = 49, PurchasePriceInr = 199,
                    Genres = new List<string> { "Drama", "Biography" }, Director = "Vidhu Vinod Chopra"
                },
                new Movie
                {
                    Id = 18,
                    Title = "Manjummel Boys",
                    Slug = "manjummel-boys",
                    Tagline = "A friend is one who walks in when the whole world walks out.",
                    Description = "A group of young men from Kochi embark on a trip to Kodaikanal, where a joyful vacation turns into a harrowing real-life rescue mission inside the treacherous Guna Caves.",
                    PosterUrl = "https://upload.wikimedia.org/wikipedia/en/e/ed/Manjummel_Boys_poster.jpg",
                    BackdropUrl = "https://img.youtube.com/vi/rqBuKT_8dMY/maxresdefault.jpg",
                    OfficialThumbnailUrl = "https://img.youtube.com/vi/rqBuKT_8dMY/maxresdefault.jpg",
                    YouTubeVideoId = "rqBuKT_8dMY",
                    OfficialChannelName = "DisneyPlus Hotstar",
                    ReleaseYear = 2024, DurationMinutes = 135, AgeRating = "U/A 13+", Language = "Malayalam", RegionCategory = "Regional Cinema", Country = "India",
                    ImdbRating = 8.6, ViewCount = 2600000, QualityBadge = "4K UHD",
                    IsTrending = true, IsPopular = true, IsTopRated = true, IsFree = false, IsPremium = true,
                    RentalPriceInr = 49, PurchasePriceInr = 199,
                    Genres = new List<string> { "Adventure", "Thriller", "Regional Cinema" }, Director = "Chidambaram"
                }
            });

            // 4. Movie Trailers (14 official trailers across Bollywood, Hollywood & Indian regional cinema)
            Trailers.AddRange(new[]
            {
                new MovieTrailer { Id = 1, Title = "Kalki 2898 AD - Official Theatrical Trailer", MovieTitle = "Kalki 2898 AD", YouTubeVideoId = "kQDd1AhGIHk", OfficialChannelName = "Vyjayanthi Network", PublishedAt = DateTime.UtcNow.AddHours(-12), UpcomingCinemaReleaseDate = DateTime.UtcNow.Date.AddDays(14), Language = "Hindi", Genre = "Action", CastNames = "Prabhas, Deepika Padukone, Amitabh Bachchan, Kamal Haasan", Director = "Nag Ashwin", DurationSeconds = 184, Industry = "South Indian", FreshnessCategory = "Latest", ViewCount = 1420000, IsFeatured = true },
                new MovieTrailer { Id = 2, Title = "Singham Again - Official Hindi Trailer", MovieTitle = "Singham Again", YouTubeVideoId = "MD7v0-igVIM", OfficialChannelName = "JioStudios", PublishedAt = DateTime.UtcNow.AddHours(-24), UpcomingCinemaReleaseDate = DateTime.UtcNow.Date.AddDays(7), Language = "Hindi", Genre = "Action", CastNames = "Ajay Devgn, Kareena Kapoor Khan, Ranveer Singh, Deepika Padukone, Akshay Kumar", Director = "Rohit Shetty", DurationSeconds = 298, Industry = "Bollywood", FreshnessCategory = "Latest", ViewCount = 2850000, IsFeatured = true },
                new MovieTrailer { Id = 3, Title = "Deadpool & Wolverine - Official Teaser & Trailer", MovieTitle = "Deadpool & Wolverine", YouTubeVideoId = "uJMCNJP2ipI", OfficialChannelName = "Marvel Studios", PublishedAt = DateTime.UtcNow.AddHours(-36), UpcomingCinemaReleaseDate = DateTime.UtcNow.Date.AddDays(5), Language = "English", Genre = "Action", CastNames = "Ryan Reynolds, Hugh Jackman, Emma Corrin", Director = "Shawn Levy", DurationSeconds = 158, Industry = "Hollywood", FreshnessCategory = "Latest", ViewCount = 5900000, IsFeatured = true },
                new MovieTrailer { Id = 4, Title = "Gladiator II - Official Trailer", MovieTitle = "Gladiator II", YouTubeVideoId = "4rgYUipGJNo", OfficialChannelName = "Paramount Pictures", PublishedAt = DateTime.UtcNow.AddDays(-3), UpcomingCinemaReleaseDate = DateTime.UtcNow.Date.AddDays(21), Language = "English", Genre = "Action", CastNames = "Paul Mescal, Pedro Pascal, Denzel Washington", Director = "Ridley Scott", DurationSeconds = 195, Industry = "Hollywood", FreshnessCategory = "Upcoming", ViewCount = 3120000, IsFeatured = false },
                new MovieTrailer { Id = 5, Title = "Stree 2 - Official Theatrical Trailer", MovieTitle = "Stree 2", YouTubeVideoId = "VlvOgk5BHS4", OfficialChannelName = "JioStudios", PublishedAt = DateTime.UtcNow.AddDays(-4), UpcomingCinemaReleaseDate = DateTime.UtcNow.Date.AddDays(10), Language = "Hindi", Genre = "Comedy", CastNames = "Shraddha Kapoor, Rajkummar Rao, Pankaj Tripathi", Director = "Amar Kaushik", DurationSeconds = 172, Industry = "Bollywood", FreshnessCategory = "Last7Days", ViewCount = 4210000, IsFeatured = false },
                new MovieTrailer { Id = 6, Title = "Dune: Part Two - Official 4K Trailer", MovieTitle = "Dune: Part Two", YouTubeVideoId = "Way9Dexny3w", OfficialChannelName = "Warner Bros. Pictures", PublishedAt = DateTime.UtcNow.AddDays(-6), UpcomingCinemaReleaseDate = DateTime.UtcNow.Date.AddDays(4), Language = "English", Genre = "Science Fiction", CastNames = "Timothée Chalamet, Zendaya, Rebecca Ferguson", Director = "Denis Villeneuve", DurationSeconds = 182, Industry = "Hollywood", FreshnessCategory = "Last7Days", ViewCount = 8400000, IsFeatured = false },
                new MovieTrailer { Id = 7, Title = "Jawan: Prevue & Theatrical Trailer", MovieTitle = "Jawan", YouTubeVideoId = "MWOlnZSnXJo", OfficialChannelName = "Red Chillies Entertainment", PublishedAt = DateTime.UtcNow.AddDays(-15), Language = "Hindi", Genre = "Action", CastNames = "Shah Rukh Khan, Nayanthara, Vijay Sethupathi", Director = "Atlee", DurationSeconds = 165, Industry = "Bollywood", FreshnessCategory = "Last30Days", ViewCount = 12500000, IsFeatured = false },
                new MovieTrailer { Id = 8, Title = "Oppenheimer - Official Trailer", MovieTitle = "Oppenheimer", YouTubeVideoId = "uYPbbksJxIg", OfficialChannelName = "Universal Pictures", PublishedAt = DateTime.UtcNow.AddDays(-20), Language = "English", Genre = "Drama", CastNames = "Cillian Murphy, Emily Blunt, Robert Downey Jr.", Director = "Christopher Nolan", DurationSeconds = 184, Industry = "Hollywood", FreshnessCategory = "Last30Days", ViewCount = 9800000, IsFeatured = false },
                new MovieTrailer { Id = 9, Title = "Mission: Impossible – The Final Reckoning", MovieTitle = "Mission: Impossible – The Final Reckoning", YouTubeVideoId = "fsQgc9pCyDU", OfficialChannelName = "Paramount Pictures", PublishedAt = DateTime.UtcNow.AddDays(-2), UpcomingCinemaReleaseDate = DateTime.UtcNow.Date.AddDays(60), Language = "English", Genre = "Action", CastNames = "Tom Cruise, Hayley Atwell, Ving Rhames", Director = "Christopher McQuarrie", DurationSeconds = 135, Industry = "Hollywood", FreshnessCategory = "Upcoming", ViewCount = 7600000, IsFeatured = true },
                new MovieTrailer { Id = 10, Title = "Fighter - Official Teaser & Trailer", MovieTitle = "Fighter", YouTubeVideoId = "6amIq_mP4xM", OfficialChannelName = "Star Studios Premiere", PublishedAt = DateTime.UtcNow.AddDays(-25), Language = "Hindi", Genre = "Action", CastNames = "Hrithik Roshan, Deepika Padukone, Anil Kapoor", Director = "Siddharth Anand", DurationSeconds = 191, Industry = "Bollywood", FreshnessCategory = "Last30Days", ViewCount = 6500000, IsFeatured = false },
                new MovieTrailer { Id = 11, Title = "Bhool Bhulaiyaa 3 - Official Trailer", MovieTitle = "Bhool Bhulaiyaa 3", YouTubeVideoId = "6YMY62tMLUA", OfficialChannelName = "T-Series", PublishedAt = DateTime.UtcNow.AddHours(-18), UpcomingCinemaReleaseDate = DateTime.UtcNow.Date.AddDays(12), Language = "Hindi", Genre = "Horror", CastNames = "Kartik Aaryan, Vidya Balan, Madhuri Dixit, Triptii Dimri", Director = "Anees Bazmee", DurationSeconds = 228, Industry = "Bollywood", FreshnessCategory = "Latest", ViewCount = 4900000, IsFeatured = true },
                new MovieTrailer { Id = 12, Title = "Pushpa 2: The Rule - Theatrical Trailer", MovieTitle = "Pushpa 2: The Rule", YouTubeVideoId = "1kVK0MZlbI4", OfficialChannelName = "T-Series", PublishedAt = DateTime.UtcNow.AddDays(-1), UpcomingCinemaReleaseDate = DateTime.UtcNow.Date.AddDays(30), Language = "Hindi", Genre = "Action", CastNames = "Allu Arjun, Rashmika Mandanna, Fahadh Faasil", Director = "Sukumar", DurationSeconds = 168, Industry = "South Indian", FreshnessCategory = "Upcoming", ViewCount = 18900000, IsFeatured = true },
                new MovieTrailer { Id = 13, Title = "Joker: Folie à Deux - Official Trailer", MovieTitle = "Joker: Folie à Deux", YouTubeVideoId = "_OKAwz2MsJs", OfficialChannelName = "Warner Bros. Pictures", PublishedAt = DateTime.UtcNow.AddDays(-5), UpcomingCinemaReleaseDate = DateTime.UtcNow.Date.AddDays(15), Language = "English", Genre = "Drama", CastNames = "Joaquin Phoenix, Lady Gaga, Brendan Gleeson", Director = "Todd Phillips", DurationSeconds = 170, Industry = "Hollywood", FreshnessCategory = "Last7Days", ViewCount = 5400000, IsFeatured = false },
                new MovieTrailer { Id = 14, Title = "Interstellar - 10th Anniversary IMAX Rerelease", MovieTitle = "Interstellar", YouTubeVideoId = "zSWdZVtXT7E", OfficialChannelName = "Paramount Pictures", PublishedAt = DateTime.UtcNow.AddDays(-4), UpcomingCinemaReleaseDate = DateTime.UtcNow.Date.AddDays(18), Language = "English", Genre = "Science Fiction", CastNames = "Matthew McConaughey, Anne Hathaway, Jessica Chastain", Director = "Christopher Nolan", DurationSeconds = 152, Industry = "Hollywood", FreshnessCategory = "Upcoming", ViewCount = 3800000, IsFeatured = false }
            });

            // 5. Cinemas & Multiplexes across Indian Metros
            Cinemas.AddRange(new[]
            {
                new Cinema
                {
                    Id = 1, Name = "PVR ICON Phoenix Palladium", Chain = "PVR INOX", City = "Mumbai",
                    Address = "462, Senapati Bapat Marg, Lower Parel, Mumbai, Maharashtra 400013",
                    Latitude = 18.9950, Longitude = 72.8258, TotalScreens = 7,
                    Amenities = new List<string> { "IMAX 4K Laser", "4DX", "Dolby Atmos", "In-seat dining" },
                    PartnerWebsiteUrl = "https://in.bookmyshow.com/explore/movies-mumbai",
                    Showtimes = new List<Showtime>
                    {
                        new Showtime { Id = 1, CinemaId = 1, MovieTitle = "Kalki 2898 AD", Format = "IMAX 3D Laser", Time = "11:30 AM", PriceInr = 450, AvailabilityStatus = "Available" },
                        new Showtime { Id = 2, CinemaId = 1, MovieTitle = "Kalki 2898 AD", Format = "IMAX 3D Laser", Time = "03:45 PM", PriceInr = 550, AvailabilityStatus = "Filling Fast" },
                        new Showtime { Id = 3, CinemaId = 1, MovieTitle = "Singham Again", Format = "Dolby Atmos 2D", Time = "07:15 PM", PriceInr = 380, AvailabilityStatus = "Almost Full" }
                    }
                },
                new Cinema
                {
                    Id = 2, Name = "PVR INOX Plaza Connaught Place", Chain = "PVR INOX", City = "Delhi-NCR",
                    Address = "H Block, Connaught Circus, New Delhi, Delhi 110001",
                    Latitude = 28.6315, Longitude = 77.2167, TotalScreens = 4,
                    Amenities = new List<string> { "IMAX Laser", "Dolby Atmos", "Recliners" },
                    PartnerWebsiteUrl = "https://in.bookmyshow.com/explore/movies-ncr",
                    Showtimes = new List<Showtime>
                    {
                        new Showtime { Id = 4, CinemaId = 2, MovieTitle = "Singham Again", Format = "Dolby Atmos", Time = "02:00 PM", PriceInr = 350, AvailabilityStatus = "Available" },
                        new Showtime { Id = 5, CinemaId = 2, MovieTitle = "Gladiator II", Format = "IMAX 2D", Time = "06:30 PM", PriceInr = 480, AvailabilityStatus = "Available" }
                    }
                },
                new Cinema
                {
                    Id = 3, Name = "Cinepolis Nexus Forum Mall Koramangala", Chain = "Cinepolis", City = "Bengaluru",
                    Address = "Hosur Road, Koramangala, Bengaluru, Karnataka 560095",
                    Latitude = 12.9352, Longitude = 77.6146, TotalScreens = 11,
                    Amenities = new List<string> { "4DX", "RealD 3D", "VIP Lounge" },
                    PartnerWebsiteUrl = "https://www.cinepolisindia.com/movie-details?city=Bengaluru",
                    Showtimes = new List<Showtime>
                    {
                        new Showtime { Id = 6, CinemaId = 3, MovieTitle = "Pushpa 2: The Rule", Format = "Dolby Atmos", Time = "10:15 AM", PriceInr = 300, AvailabilityStatus = "Available" },
                        new Showtime { Id = 7, CinemaId = 3, MovieTitle = "Pushpa 2: The Rule", Format = "4DX", Time = "05:00 PM", PriceInr = 500, AvailabilityStatus = "Filling Fast" }
                    }
                },
                new Cinema
                {
                    Id = 4, Name = "Prasad Multiplex & Large Screen", Chain = "Independent", City = "Hyderabad",
                    Address = "NTR Gardens, Khairatabad, Hyderabad, Telangana 500063",
                    Latitude = 17.4140, Longitude = 78.4682, TotalScreens = 6,
                    Amenities = new List<string> { "Giant Screen 4K", "Dolby Atmos" },
                    PartnerWebsiteUrl = "https://in.bookmyshow.com/explore/movies-hyderabad",
                    Showtimes = new List<Showtime>
                    {
                        new Showtime { Id = 8, CinemaId = 4, MovieTitle = "Kalki 2898 AD", Format = "Giant Screen 4K", Time = "01:15 PM", PriceInr = 350, AvailabilityStatus = "Almost Full" }
                    }
                }
            });

            // 6. Affiliate Products
            AffiliateProducts.AddRange(new[]
            {
                new AffiliateProduct { Id = 1, Title = "Sony WH-1000XM5 ANC Headphones", Category = "Audiophile Audio", PriceInr = 29990, Rating = 4.8, ImageUrl = "https://images.unsplash.com/photo-1505740420928-5e560c06d30e?w=500", AffiliateUrl = "https://amazon.in/dp/B09XS7JWHH", Tagline = "Experience cinema-grade Dolby Atmos soundscapes" },
                new AffiliateProduct { Id = 2, Title = "Sennheiser Ambeo Soundbar Plus", Category = "Home Cinema", PriceInr = 139990, Rating = 4.9, ImageUrl = "https://images.unsplash.com/photo-1545454675-3531b543be5d?w=500", AffiliateUrl = "https://amazon.in/dp/B0BBRTV31R", Tagline = "7.1.4 3D spatial sound with zero satellites" },
                new AffiliateProduct { Id = 3, Title = "Samsung 65-Inch OLED 4K S90C", Category = "Cinema Displays", PriceInr = 164990, Rating = 4.9, ImageUrl = "https://images.unsplash.com/photo-1593784991095-a205069470b6?w=500", AffiliateUrl = "https://amazon.in/dp/B0C1QY4RZZ", Tagline = "Pure deep blacks & neural quantum processor" }
            });

            // 7. Ad Slots
            AdSlots.AddRange(new[]
            {
                new AdSlot { SlotId = "streaming-banner-ad", Name = "Streaming Page Horizontal Ad Unit", Position = "BelowPlayer", Format = "Leaderboard (728x90 / Responsive)" },
                new AdSlot { SlotId = "streaming-sidebar-ad", Name = "Desktop Right-Sidebar Sponsored Card", Position = "Sidebar", Format = "Rectangle (300x250 / Responsive)" }
            });

            // 8. Reviews
            Reviews.AddRange(new[]
            {
                new Review { Id = 1, MovieId = 24, UserName = "Rohan Malhotra", Rating = 10, Comment = "The greatest Hindi comedy film ever made! Baburao's dialogue delivery is unmatched.", CreatedAt = DateTime.UtcNow.AddDays(-5) },
                new Review { Id = 2, MovieId = 29, UserName = "Vikram Aditya", Rating = 10, Comment = "4K restoration of Sholay looks unbelievable! Ramesh Sippy's framing is timeless.", CreatedAt = DateTime.UtcNow.AddDays(-8) },
                new Review { Id = 3, MovieId = 21, UserName = "Ananya Sen", Rating = 9, Comment = "Pure family values and pristine emotion. One of Rajshri's finest masterpieces.", CreatedAt = DateTime.UtcNow.AddDays(-12) }
            });

            // Initial Continue Watching seed
            CurrentUser.ContinueWatching.AddRange(new[]
            {
                new WatchProgress { MovieId = 24, MovieTitle = "Hera Pheri (2000)", MoviePoster = "https://upload.wikimedia.org/wikipedia/en/0/07/Hera_Pheri_2000_poster.jpg", ProgressSeconds = 3450, DurationSeconds = 9360, LastWatchedAt = DateTime.UtcNow.AddHours(-3) },
                new WatchProgress { MovieId = 21, MovieTitle = "Hum Saath Saath Hain", MoviePoster = "https://upload.wikimedia.org/wikipedia/en/0/09/Hum_Saath-Saath_Hain.jpg", ProgressSeconds = 5400, DurationSeconds = 10620, LastWatchedAt = DateTime.UtcNow.AddHours(-18) }
            });
        }

        // ==========================================
        // Helper Query & Mutation Methods
        // ==========================================
        public static Movie GetFeatured() => Movies.FirstOrDefault(m => m.IsFeatured) ?? Movies.FirstOrDefault();
        public static List<Movie> GetMustWatch() => Movies.Where(m => m.IsMustWatch).ToList();
        public static List<Movie> GetFreeMovies() => Movies.Where(m => m.IsFree).ToList();
        public static List<Movie> GetPremiumMovies() => Movies.Where(m => m.IsPremium).ToList();
        public static List<Movie> GetTrending() => Movies.Where(m => m.IsTrending).ToList();
        public static List<Movie> GetTopRated() => Movies.Where(m => m.IsTopRated).ToList();
        public static List<Movie> GetPopular() => Movies.Where(m => m.IsPopular).ToList();
        public static List<Movie> GetRecentlyAdded() => Movies.Where(m => m.IsRecentlyAdded).ToList();
        public static List<Movie> GetRecommended() => Movies.Take(12).ToList();
        public static List<Movie> GetByIndustry(string industry) =>
            Movies.Where(m => m.Industry.Equals(industry, StringComparison.OrdinalIgnoreCase)).ToList();
        public static List<Movie> GetByGenre(string genre) =>
            Movies.Where(m => m.Genres.Contains(genre, StringComparer.OrdinalIgnoreCase)).ToList();
        public static List<WatchProgress> GetContinueWatching() => CurrentUser.ContinueWatching;

        public static List<Movie> SearchMovies(string q)
        {
            if (string.IsNullOrWhiteSpace(q)) return new List<Movie>();
            return Movies.Where(m =>
                m.Title.IndexOf(q, StringComparison.OrdinalIgnoreCase) >= 0 ||
                m.Description.IndexOf(q, StringComparison.OrdinalIgnoreCase) >= 0 ||
                (m.Director != null && m.Director.IndexOf(q, StringComparison.OrdinalIgnoreCase) >= 0) ||
                m.Genres.Any(g => g.IndexOf(q, StringComparison.OrdinalIgnoreCase) >= 0) ||
                m.Cast.Any(c => c.ActorName.IndexOf(q, StringComparison.OrdinalIgnoreCase) >= 0)).ToList();
        }

        public static Movie GetMovieById(int id) => Movies.FirstOrDefault(m => m.Id == id);
        public static Movie GetMovieBySlug(string slug) => Movies.FirstOrDefault(m => m.Slug.Equals(slug, StringComparison.OrdinalIgnoreCase));

        public static List<Movie> GetSimilarMovies(int movieId, int take = 6)
        {
            var movie = GetMovieById(movieId);
            if (movie == null) return Movies.Take(take).ToList();

            return Movies.Where(m => m.Id != movieId && m.Genres.Any(g => movie.Genres.Contains(g)))
                         .Take(take)
                         .ToList();
        }

        public static List<AffiliateProduct> GetAffiliateProducts() => AffiliateProducts;

        public static AdSlot GetAdSlot(string positionOrId) =>
            AdSlots.FirstOrDefault(a => a.SlotId.Equals(positionOrId, StringComparison.OrdinalIgnoreCase) ||
                                       a.Position.Equals(positionOrId, StringComparison.OrdinalIgnoreCase)) ?? AdSlots.FirstOrDefault();

        public static List<Review> GetReviews(int movieId) =>
            Reviews.Where(r => r.MovieId == movieId).OrderByDescending(r => r.CreatedAt).ToList();

        public static void AddReview(Review review)
        {
            review.Id = Reviews.Count > 0 ? Reviews.Max(r => r.Id) + 1 : 1;
            Reviews.Insert(0, review);
        }

        public static bool ToggleWatchlist(int movieId)
        {
            if (CurrentUser.Watchlist.Contains(movieId))
            {
                CurrentUser.Watchlist.Remove(movieId);
                return false;
            }
            else
            {
                CurrentUser.Watchlist.Add(movieId);
                return true;
            }
        }

        public static List<MovieTrailer> GetTrailers() => Trailers;

        public static List<Cinema> GetCinemas(string city = null)
        {
            if (string.IsNullOrWhiteSpace(city) || city.Equals("All", StringComparison.OrdinalIgnoreCase))
                return Cinemas;
            return Cinemas.Where(c => c.City.Equals(city, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public static List<Genre> GetGenres() => Genres;
        public static List<Actor> GetActors() => Actors;

        public static Actor GetActorBySlug(string slug) =>
            Actors.FirstOrDefault(a => a.Slug.Equals(slug, StringComparison.OrdinalIgnoreCase));

        public static List<Movie> GetMoviesByActor(string actorName) =>
            Movies.Where(m => m.Cast.Any(c => c.ActorName.IndexOf(actorName, StringComparison.OrdinalIgnoreCase) >= 0)).ToList();
    }
}
