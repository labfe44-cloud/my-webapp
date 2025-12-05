using Microsoft.EntityFrameworkCore;
using XuanPhu.Web.Models.Entities;
using XuanPhu.Web.Models.Entities.Blog;
using XuanPhu.Web.Models.Entities.Season;
using XuanPhu.Web.Models.Entities.Eventing;
using XuanPhu.Web.Models.Entities.Tourism;
using XuanPhu.Web.Models.Entities.Map;
using XuanPhu.Web.Models.Entities.Partnership;
using XuanPhu.Web.Models.Entities.Education;
using XuanPhu.Web.Models.Entities.Contact;

namespace XuanPhu.Web.Data
{
    public class XuanPhuDbContext : DbContext
    {
        public XuanPhuDbContext(DbContextOptions<XuanPhuDbContext> options)
            : base(options)
        {
        }

        // ============================
        // CMS / Core
        // ============================
        public DbSet<Page> Pages => Set<Page>();
        public DbSet<SeoPopup> SeoPopups => Set<SeoPopup>();
        public DbSet<MediaFile> MediaFiles => Set<MediaFile>();

        // ============================
        // BLOG
        // ============================
        public DbSet<BlogPost> BlogPosts => Set<BlogPost>();
        public DbSet<BlogTag> BlogTags => Set<BlogTag>();
        public DbSet<BlogPostTag> BlogPostTags => Set<BlogPostTag>();

        // ============================
        // SEASON
        // ============================
        public DbSet<SeasonCard> SeasonCards => Set<SeasonCard>();

        // ============================
        // EVENT
        // ============================
        public DbSet<Event> Events => Set<Event>();
        public DbSet<EventRegistration> EventRegistrations => Set<EventRegistration>();
        public DbSet<ParticipationRegistration> ParticipationRegistrations => Set<ParticipationRegistration>();

        // ============================
        // TOUR
        // ============================
        public DbSet<TourType> TourTypes => Set<TourType>();
        public DbSet<Tour> Tours => Set<Tour>();
        public DbSet<TourRegistration> TourRegistrations => Set<TourRegistration>();

        // ============================
        // MAP
        // ============================
        public DbSet<MapLocation> MapLocations => Set<MapLocation>();
        public DbSet<JourneyRoute> JourneyRoutes => Set<JourneyRoute>();
        public DbSet<JourneyStop> JourneyStops => Set<JourneyStop>();

        // ============================
        // PARTNERSHIP
        // ============================
        public DbSet<PartnerLead> PartnerLeads => Set<PartnerLead>();

        // ============================
        // EDUCATION
        // ============================
        public DbSet<EducationProgram> EducationPrograms => Set<EducationProgram>();
        public DbSet<ProgramImage> ProgramImages => Set<ProgramImage>();
        public DbSet<ProgramDocument> ProgramDocuments => Set<ProgramDocument>();

        // ============================
        // CONTACT
        // ============================
        public DbSet<ContactRequest> ContactRequests => Set<ContactRequest>();
        public DbSet<NewsletterSubscription> NewsletterSubscriptions => Set<NewsletterSubscription>();


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ============================
            // TABLE NAMES
            // ============================
            modelBuilder.Entity<Page>().ToTable("Pages");
            modelBuilder.Entity<SeoPopup>().ToTable("SeoPopups");
            modelBuilder.Entity<MediaFile>().ToTable("MediaFiles");

            modelBuilder.Entity<BlogPost>().ToTable("BlogPosts");
            modelBuilder.Entity<BlogTag>().ToTable("BlogTags");
            modelBuilder.Entity<BlogPostTag>().ToTable("BlogPostTags");

            modelBuilder.Entity<SeasonCard>().ToTable("SeasonCards");

            modelBuilder.Entity<Event>().ToTable("Events");
            modelBuilder.Entity<EventRegistration>().ToTable("EventRegistrations");
            modelBuilder.Entity<ParticipationRegistration>().ToTable("ParticipationRegistrations");

            modelBuilder.Entity<TourType>().ToTable("TourTypes");
            modelBuilder.Entity<Tour>().ToTable("Tours");
            modelBuilder.Entity<TourRegistration>().ToTable("TourRegistrations");

            modelBuilder.Entity<MapLocation>().ToTable("MapLocations");
            modelBuilder.Entity<JourneyRoute>().ToTable("JourneyRoutes");
            modelBuilder.Entity<JourneyStop>().ToTable("JourneyStops");

            modelBuilder.Entity<PartnerLead>().ToTable("PartnerLeads");

            modelBuilder.Entity<EducationProgram>().ToTable("EducationPrograms");
            modelBuilder.Entity<ProgramImage>().ToTable("ProgramImages");
            modelBuilder.Entity<ProgramDocument>().ToTable("ProgramDocuments");

            modelBuilder.Entity<ContactRequest>().ToTable("ContactRequests");
            modelBuilder.Entity<NewsletterSubscription>().ToTable("NewsletterSubscriptions");


            // ============================
            // UNIQUE INDICES
            // ============================
            modelBuilder.Entity<Page>()
                .HasIndex(x => x.Slug)
                .IsUnique();

            modelBuilder.Entity<BlogPost>()
                .HasIndex(x => x.Slug)
                .IsUnique();

            // ============================
            // M:N BlogPost <-> BlogTag
            // ============================
            modelBuilder.Entity<BlogPostTag>()
                .HasKey(x => new { x.BlogPostId, x.BlogTagId });

            modelBuilder.Entity<BlogPostTag>()
                .HasOne(pt => pt.BlogPost)
                .WithMany(p => p.BlogPostTags)
                .HasForeignKey(pt => pt.BlogPostId);

            modelBuilder.Entity<BlogPostTag>()
                .HasOne(pt => pt.BlogTag)
                .WithMany(t => t.BlogPostTags)
                .HasForeignKey(pt => pt.BlogTagId);

            // ============================
            // INDEXES (PERFORMANCE)
            // ============================
            modelBuilder.Entity<Event>()
                .HasIndex(x => x.StartDateTime);

            modelBuilder.Entity<JourneyStop>()
                .HasIndex(x => new { x.JourneyRouteId, x.OrderIndex });

            modelBuilder.Entity<TourRegistration>()
                .HasIndex(x => new { x.TourTypeId, x.CreatedAt });

            modelBuilder.Entity<PartnerLead>()
                .HasIndex(x => new { x.Type, x.Status });

            // ============================
            // RELATIONSHIPS / CASCADE
            // ============================
            modelBuilder.Entity<EventRegistration>()
                .HasOne(x => x.Event)
                .WithMany(e => e.Registrations)
                .HasForeignKey(x => x.EventId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ProgramImage>()
                .HasOne(x => x.EducationProgram)
                .WithMany(e => e.Images)
                .HasForeignKey(x => x.EducationProgramId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ProgramDocument>()
                .HasOne(x => x.EducationProgram)
                .WithMany(e => e.Documents)
                .HasForeignKey(x => x.EducationProgramId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
