# CinePulse — Next-Gen AI-Powered Movie Streaming, Trailer Discovery & Cinema Booking Platform

> **Cinematic Excellence, Everywhere.**  
> An original, production-ready, dark-themed OTT movie streaming, discovery, trailer hub, and location-based cinema ticket booking platform inspired by modern entertainment architectures.

---

## 🌟 Architecture & Core Capabilities

CinePulse combines a cinematic, responsive front-end with an enterprise-grade ASP.NET Core 8 REST API backend, an intelligent AI recommendation engine, legal YouTube video integration with quota tracking, Razorpay payment checkout, trailer discovery across freshness windows, nearby cinema multiplex geolocation, and **authorized ticket booking redirection (BookMyShow & Cinepolis India)**.

```
                               ┌────────────────────────────────────────────────────────┐
                               │                  CinePulse OTT Client                  │
                               │   (Tailwind, Vanilla ES6+, FontAwesome, Location API)  │
                               └───────────────────────────┬────────────────────────────┘
                                                           │
                                             REST APIs / JWT Bearer
                                                           │
                               ┌───────────────────────────▼────────────────────────────┐
                               │                 CinePulse ASP.NET Core                 │
                               │                    REST API Engine                     │
                               └───────┬───────────────────┬───────────────────┬────────┘
                                       │                   │                   │
        ┌──────────────────────────────┼───────────────────┼───────────────────┼──────────────────────────────┐
        │                              │                   │                   │                              │
┌───────▼────────────────┐   ┌─────────▼─────────┐   ┌─────▼─────────────┐   ┌─▼──────────────────┐   ┌───────▼────────────────┐
│ Google OAuth 2.0 /     │   │ YouTube IFrame    │   │ Trailer Discovery │   │ Cinema Discovery & │   │ Ticket Booking         │
│ OpenID Connect Service │   │ Verification &    │   │ Freshness Engine  │   │ Location Services  │   │ Redirect Service       │
│ (Identity & Profiling) │   │ Quota Management  │   │ (48h/7d/30d/rel)  │   │ (Haversine Metro)  │   │ (BookMyShow, Cinepolis)│
└────────────────────────┘   └───────────────────┘   └───────────────────┘   └────────────────────┘   └────────────────────────┘
        │                              │                   │                   │                              │
        └──────────────────────────────┼───────────────────┼───────────────────┼──────────────────────────────┘
                                       │
                           ┌───────────▼────────────────────────────┐
                           │      Entity Framework Core (ACID)      │
                           │ Users, Movies, Trailers, Cinemas, Logs │
                           └────────────────────────────────────────┘
```

---

## 🚀 Key Features

### 1. Unified Entertainment Experience (Strict UI/UX Compliance)
- **Zero Separate Bollywood/Hollywood Tabs:** All Bollywood, Hollywood, South Indian, and international cinema live in one unified entertainment catalogue.
- **Dynamic Faceted Filtering:** Language (Hindi, English, Telugu, Tamil, Malayalam, Spanish, Japanese) and Industry (Bollywood, Hollywood, Tollywood, Kollywood, World) are structured as query filters and badges, never as separate navigation silos.
- **Top Navigation Rails:** Unified links: **Home**, **Free Movies**, **Movie Trailers** (`#trailers`), **Upcoming & Cinemas** (`#cinemas`), **Premium Cinema**, **Genres**, **Actors**, **Watchlist**.

### 2. Free Movie Streaming — Verified Legal YouTube Integration
- **Official YouTube IFrame Player API (`YT.Player`):** 100% compliant player with zero overlay obstruction.
- **Verified Studio Channel Attribution:** Curated and catalogued from official studio channels (Yash Raj Films, Rajshri, Shemaroo, Ultra Movie Parlour, Blender Studio, Public Domain Archive).
- **Automated Verification & Quota Management:** Tracks YouTube Data API v3 quota (10,000 units/day) with batch verification status, last verified timestamp, and quota audit logging.
- **Resilient Thumbnails:** Direct official YouTube CDN (`img.youtube.com/vi/{id}/maxresdefault.jpg`) with automatic fallback to `hqdefault.jpg`.

### 3. Movie Trailer Discovery Hub (`#trailers`)
- **Unified Trailer Discovery:** Comprehensive trailer catalogue for Bollywood, Hollywood, and regional blockbusters (*Kalki 2898 AD*, *Singham Again*, *Deadpool & Wolverine*, *Gladiator II*, *Stree 2*, *Dune: Part Two*, etc.).
- **Freshness Window Filters:**
  - *All Releases*
  - *Latest 48 Hours*
  - *Last 7 Days*
  - *Last 30 Days*
  - *Upcoming Cinema Releases*
- **Instant In-Modal Trailer Playback:** Seamless preview modal with channel attribution and real-time view count tracking.
- **Admin Automated Trailer Refresh:** 1-click on-demand background sync pulling newest releases.

### 4. Theatrical Releases & Nearby Cinema Booking (`#cinemas`)
- **Location Permission Protocol:** Transparent 3-option modal (*Allow Location* | *Enter City Manually* | *Change Location Later*). Video streaming is never blocked if location permission is denied.
- **Indian Metro City Support:** Mumbai, Delhi-NCR, Bengaluru, Hyderabad, Pune, Chennai, Kolkata, Ahmedabad.
- **Haversine Geolocation Engine:** Accurate real-world distance calculation (in kilometers) between user coordinates and nearby multiplexes.
- **Multiplex Venue Details:** Venue names, addresses, screen counts, and audio/visual formats (IMAX 3D, 4DX, 2D Dolby Atmos).
- **Real-Time Showtime Grid:** Morning, matinee, evening, and night showtimes with dynamic seat availability badges (*Available*, *Filling Fast*, *Almost Full*).
- **Authorized Ticketing Redirection:**
  - Direct deep-links to **BookMyShow** (`bookmyshow.com/{city}/movies/{title}`) and **Cinepolis India** (`cinepolisindia.com/showtimes?city={city}&movie={title}`).
  - Pre-redirection interstitial modal with complete **Legal Partner Disclosures** informing users they are transitioning to an authorized external ticketing partner.

### 5. Actor & Actress Discovery with Photo Licensing Attribution
- **Wikimedia Commons Compliance:** Every actor profile features complete copyright attribution records (`ImageAttribution`, `ImageLicence`, `ImageSourceUrl` under Creative Commons CC BY-SA 4.0 / CC BY 2.0).
- **Comprehensive Profiles:** High-resolution portrait, biography, date of birth, place of birth, follower counts, known genres, filmography catalogue, and **Upcoming Projects**.

### 6. Main Streaming Page & Viewing Modes (`#watch?id=...`)
- **Prominent 16:9 Video Canvas:** Responsive aspect ratio, zero distortion, with accessible playback controls.
- **Three Distinct Viewing Modes:**
  - **Normal Mode:** 2-column layout with 8-column main video canvas and 4-column right-side monetization sidebar on desktop. Below-player ad slots and metadata are visible.
  - **Theatre Mode:** Expands player to 100% container width (12 columns) for maximum immersion; right sidebar smoothly reflows below the player without breaking layout.
  - **Fullscreen Mode:** Invokes native player canvas fullscreen (`requestFullscreen`). **All external website advertisements, display banners, headers, and sidebars are automatically hidden.** Layout is seamlessly restored upon exit (`fullscreenchange` event).
- **Control Integrity:** Advertisements are strictly prohibited from overlaying essential video player controls or interrupting playback with intrusive popups.

### 7. Comprehensive 6-Channel Revenue System
1. **Google AdSense:** Configurable Publisher Account ID and slot IDs for horizontal and sidebar units.
2. **Direct Brand Sponsorship Campaigns:** Contracted display banners with CTR and eCPM tracking.
3. **Affiliate Marketing:** High-ticket home theatre audio/visual gear with disclosures.
4. **VIP Membership Subscriptions:** Ad-Free UI Experience for active VIP subscribers.
5. **Digital Movie Rentals:** Pay-per-view rentals with 48-hour viewing window.
6. **Digital Movie Purchases:** Perpetual digital ownership with cryptographic entitlement check.

### 8. User Authentication — Google Sign-In & Privacy
- **Google Identity Services:** OAuth 2.0 / OpenID Connect token exchange with avatar, display name, and verified email sync.
- **Instant Demo Review Accounts:** 1-click test login for **Viewer** (`Priya Sharma`) and **Administrator** (`Alex Mercer`).
- **Taste Profile & Preferences:** Multi-select favorite genres, favorite actors, preferred languages.
- **GDPR & Privacy Compliance:** Full account deletion and privacy preferences toggle.

### 5. Free Movie Section — Legally Embeddable YouTube Videos
- Uses the **Official YouTube IFrame Player API** (`YT.Player`).
- Only lists verified, legally embeddable open-source movies, Creative Commons animations, and classic public domain cinema (e.g., Blender Studio's *Tears of Steel*, *Big Buck Bunny*, *Spring*, *Charge*, Nina Paley's *Sita Sings the Blues*, George Romero's *Night of the Living Dead*, Buster Keaton's *The General*).
- Displays prominent **YouTube Channel Attribution** (`Blender Studio (Official)`, `Public Domain Cinema Classics`).
- Free movies remain 100% free with no paywalls, gating, ad removal, or background playback violations.

### 6. Premium Cinema — Rentals & Purchases
- **Authorized Video Engine:** Custom HTML5 cinema player with seekbar, volume controls, subtitle selectors, and resolution presets (4K UHD, 1080p, 720p).
- **Cryptographic Entitlement Checks:** The video stream URL is securely gated on the backend; only verified active rentals and purchases receive playback authorization.

### 7. Payment Gateway Integration — Razorpay
- **Server-Side Order Creation:** Generates unique order IDs (`order_rzp_...`) with currency `INR`.
- **Cryptographic Signature Verification:** Verifies `HMAC-SHA256(order_id + "|" + payment_id, secret)` on the backend before granting viewing rights.
- **Razorpay Sandbox Simulator:** Built-in checkout modal supporting UPI (GPay, PhonePe, Paytm, BHIM), Credit/Debit Cards, Net Banking, and Wallets for frictionless local testing.
- **Refund Management:** Administrator refund workflow with instant entitlement revocation and logging.

### 8. AI Movie Recommendation Engine
- **Hybrid Multi-Vector Algorithm:**
  - Genre Affinity Vector (+35% weight)
  - Actor Affinity Vector (+25% weight)
  - Director Match Vector (+15% weight)
  - Rating & Popularity Dampening (+20% weight)
  - Recent Watch History Weighting (penalizes recently finished movies to encourage discovery; boosts genres of movies rated ≥8)
- **Personalized Rails:**
  - *Recommended For You*
  - *Because You Watched [Title]*
  - *Trending in Your Favourite Genres*
  - *More Like This (Similar Movies)* on detail screens

### 9. Comprehensive Admin Dashboard
- **Monetization Operations Tab:**
  - Financial overview aggregating revenue across all 5 revenue channels.
  - Advertising performance metrics (Impressions, Clicks, CTR %, eCPM ₹).
  - Google AdSense Configuration form (Publisher ID, slot IDs, activation toggle).
  - Configurable Ad Placements table with 1-click status toggles.
  - Direct Sponsorship Campaigns ledger.
  - Affiliate Products management ledger.
  - **Export Revenue Report (CSV):** 1-click download of itemized financial audit report (`CinePulse_Revenue_Report_YYYY-MM-DD.csv`).
- **Analytics KPIs:** Total registered users, active viewers, free movie plays, rentals count, purchases count, and total platform revenue.
- **Movie Catalogue CRUD:** Add/Edit/Delete movies with real-time **YouTube Embed Verifier**, distribution rights selector, and pricing configuration.
- **User Role Management:** Promote users to Administrator, demote, or suspend accounts.
- **Transactions & Refund Processor:** Full ledger with 1-click refunds and reason tracking.
- **Review Moderation Queue:** Approve, flag, or reject user reviews.
- **Audit Logs:** Immutable audit trail recording administrative operations.

---

## 🛠️ Technology Stack

| Layer | Technology |
|---|---|
| **Frontend** | HTML5, CSS3, Tailwind CSS, Vanilla Modern ES6+, FontAwesome 6 |
| **Backend** | ASP.NET Core 8 Web API (C#) |
| **ORM / Data Access** | Entity Framework Core 8 |
| **Database** | In-Memory ACID Relational Store (with SQL Server compatibility) |
| **Authentication** | Google Identity Services (OAuth 2.0 / OpenID Connect) + JWT Bearer |
| **Payments** | Razorpay SDK & Server-Side HMAC-SHA256 Signature Verification |
| **Monetization** | Google AdSense Integration, Direct Banners, Affiliate Marketing, VIP Memberships |
| **Video Playback** | YouTube IFrame Player API (Free) + Authorized HTML5 Player (Premium) |

---

## 📂 Project Structure

```
c:\Games\
├── nuget.config
├── README.md
├── CinePulse\
│   ├── CinePulse.Api.csproj         # ASP.NET Core project file
│   ├── Program.cs                   # Application bootstrap & dependency injection
│   ├── appsettings.json             # Configuration & security keys
│   ├── Models\
│   │   └── Entities.cs              # Relational models (Movie, User, MovieTrailer, Cinema, Showtime, QuotaLog, etc.)
│   ├── Data\
│   │   ├── CinePulseDbContext.cs    # EF Core DbContext with relational mapping
│   │   └── DbInitializer.cs         # Rich seed catalog (50+ movies, 14 trailers, 8 multiplexes, 22 showtimes, 10 actors)
│   ├── DTOs\
│   │   └── Dtos.cs                  # Clean Data Transfer Objects for streaming, trailers, cinemas, and verification
│   ├── Services\
│   │   └── Services.cs              # 9 Services: YouTube, Verification, Trailers, Location, Cinema, Booking, Actors, Catalogue, Auth
│   ├── Controllers\
│   │   └── ApiControllers.cs        # RESTful API controllers (Movies, Trailers, Cinemas, Verification, Auth, Admin, etc.)
│   └── wwwroot\
│       ├── index.html               # Main SPA HTML structure (Unified OTT, Trailers View, Cinemas View, Admin Verification)
│       ├── css\
│       │   └── app.css              # Custom cinematic dark theme & animations
│       └── js\
│           ├── api.js               # Centralized REST API client (with trailers, cinemas, and verification endpoints)
│           ├── auth.js              # Google OAuth & session management
│           ├── player.js            # Dual video engine with Normal, Theatre, Fullscreen modes
│           ├── payments.js          # Razorpay checkout & simulator
│           ├── recommendations.js   # AI recommendations controller
│           ├── monetization.js      # Client-side AdSense, banners, affiliate gear & VIP modals
│           ├── trailers.js          # Trailer discovery, freshness filters, and modal playback
│           ├── cinemas.js           # Location modal, GPS metro resolution, showtimes, BookMyShow/Cinepolis redirect
│           ├── admin.js             # Admin portal, verification center, and quota gauge
│           └── app.js               # Main routing & UI interaction manager
└── CinePulse.Tests\
    ├── CinePulse.Tests.csproj       # Test project file
    └── Program.cs                   # 69 comprehensive end-to-end automated tests
```

---

## ⚡ Quick Start & Running the Platform

### Prerequisites
- [.NET 8.0 SDK](https://dotnet.microsoft.com/download) (or .NET 10) installed.

### 1. Build the Solution
```powershell
cd c:\Games
dotnet build CinePulse\CinePulse.Api.csproj -p:NuGetAudit=false
```

### 2. Run the Automated Test Suite (69 Tests)
```powershell
dotnet run --project CinePulse.Tests\CinePulse.Tests.csproj -p:NuGetAudit=false
```
*Outputs verification results across Database Seeding, Unified Non-Split Catalogue, Free Movies & YouTube CDN Verification, Actor Discovery & Wikimedia Commons CC Attributions, Trailer Discovery & Freshness Windows, Theatrical Releases & Nearby Multiplexes, Geolocation Distance, BookMyShow/Cinepolis Authorized Redirects & Disclosures, YouTube Data API v3 Quota Logs, Google Auth, AI Recommendations, Razorpay Rentals, Multi-Channel Monetization, AdSense, VIP Ad-Free Filter, and Admin CSV Export.*

### 3. Launch the Web Application
```powershell
cd c:\Games\CinePulse
dotnet run --urls "http://localhost:5215"
```
Open **[http://localhost:5215](http://localhost:5215)** in your web browser!

---

## 🔑 Pre-Configured Test Credentials

For effortless testing, use the instant 1-click accounts on the Sign-In modal:

| Role | Name | Email | Capabilities |
|---|---|---|---|
| **Admin** | Alex Mercer | `admin@cinepulse.io` | Full platform control, Monetization Dashboard, AdSense Config, Campaign CRUD, Movie CRUD, Refund Processor, User RBAC |
| **Viewer** | Priya Sharma | `demo@cinepulse.io` | Active VIP Subscription (100% Ad-Free UI), pre-seeded active rental (Jawan), purchase (RRR), personalized taste profile |

---

## 🔒 Security, Legal & Licensing Compliance

1. **YouTube Compliance:**
   - Free movies are streamed exclusively via the official YouTube IFrame Player API.
   - Free movies remain 100% free; no paywalls or gated playback.
   - YouTube creator advertising and branding remain unaltered.
2. **Ad Viewing Integrity:**
   - Advertisements are never placed over essential player controls.
   - In Fullscreen mode, all surrounding website ads and banners are completely hidden.
   - Active VIP subscribers receive an automated 100% ad-free experience on all platform-controlled ad slots.
3. **Payment & Entitlement Safety:**
   - Server-side cryptographic HMAC-SHA256 verification is mandatory before issuing any rental or purchase entitlement.
4. **GDPR Compliance:**
   - Full data privacy controls, including personalized ads opt-out and complete automated account deletion.
