using ALSN.Domain.Entities.Documents;
using ALSN.Domain.Entities.Guest;
using ALSN.Domain.Entities.Guest.Tickets;
using ALSN.Domain.Entities.Guest.Translation;
using ALSN.Domain.Entities.TranslationOffice;
using ALSN.Domain.Entities.TranslationOffice.DeliveryService;
using ALSN.Domain.Entities.TranslationOffice.Order;
using ALSN.Domain.Entities.Translator;
using ALSN.Domain.Entities.Translator.Orders;
using ALSN.Domain.Entities.User;
using ALSN.Domain.Entities.User.Coupons;
using Microsoft.EntityFrameworkCore;

namespace ALSN.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Translator> Translators { get; set; }
        public DbSet<TranslOffice> translOffices { get; set; }
        public DbSet<TranslOfficeDetails> translOfficeDetails { get; set; }
        public DbSet<Translation> Translations { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<DocumentsType> DocumentsTypes { get; set; }
        public DbSet<TranslationPrice> translationPrices { get; set; }
        public DbSet<ServiceCategory> serviceCategories { get; set; }
        public DbSet<Coupons> Coupons { get; set; }
        public DbSet<Ticket> tickets { get; set; }
        public DbSet<Feedback> feedbacks { get; set; }
        public DbSet<BankDetails> bankDetails { get; set; }
        public DbSet<OrderAssign> orderAssigns { get; set; }
        public DbSet<AcceptedOrders> acceptedOrders { get; set; }
        public DbSet<RejectOrder> rejectOrders { get; set; }
        public DbSet<Language> languages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Translation>()
               .HasOne(t => t.translationPrice)
               .WithMany()
               .HasForeignKey(t => t.TranslationPriceId)
               .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TranslationPrice>()
                .HasOne(tp => tp.DocumentsType)
                .WithOne(dt => dt.TranslationPrice)
                .HasForeignKey<DocumentsType>(dt => dt.DocTypeId);

            modelBuilder.Entity<OrderAssign>()
                .HasOne(oa => oa.translation)
                .WithOne(t => t.OrderAssign)
                .HasForeignKey<OrderAssign>(oa => oa.TranslationId);

            modelBuilder.Entity<Feedback>()
                .HasOne(f => f.Translation)
                .WithOne(t => t.feedback)
                .HasForeignKey<Feedback>(f => f.translationId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
