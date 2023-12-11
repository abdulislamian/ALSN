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
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ALSN.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Translators> Translators { get; set; }
        public DbSet<TranslOffice> translOffices { get; set; }
        public DbSet<TranslOfficeDetails> translOfficeDetails { get; set; }
        public DbSet<Translation> Translation { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<DocumentsType> DocumentsType { get; set; }
        public DbSet<TranslationPrice> translationPrice { get; set; }
        //public DbSet<ServiceCategory> serviceCategory { get; set; }
        public DbSet<Coupons> Coupons { get; set; }
        public DbSet<Ticket> tickets { get; set; }
        public DbSet<Feedback> feedback { get; set; }
        public DbSet<BankDetails> bankDetails { get; set; }
        public DbSet<OrderAssign> orderAssign { get; set; }
        public DbSet<AcceptedOrders> acceptedOrders { get; set; }
        public DbSet<RejectOrder> rejectOrder { get; set; }
        public DbSet<Language> language { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

           // modelBuilder.Entity<Translators>()
           //.HasOne(t => t.TranslOffice)
           //.WithOne()
           //.HasForeignKey<Translators>(t => t.TransOfficeId);

           // modelBuilder.Entity<Guest>()
           //.HasOne(t => t.TranslOffice)
           //.WithOne()
           //.HasForeignKey<Translators>(t => t.TransOfficeId);



            Seed(modelBuilder);
        }

        private void Seed(ModelBuilder modelBuilder)
        {
            SeedGuests(modelBuilder);
            SeedTranslators(modelBuilder);
            SeedApplicationUsers(modelBuilder);
            SeedTranslationOfficers(modelBuilder);
        }
        private void SeedGuests(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Guest>().HasData(
                new Guest
                {
                    Id = Guid.NewGuid().ToString(),
                    FullName = "Sample Guest",
                    Email = "sample.guest@example.com",
                    PasswordHash = "hashed_password_here", 
                    ContactNo = "03149276066",
                    LocalizationLanguage= "English"
                }
            );
        }

        private void SeedTranslators(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Translators>().HasData(
                new Translators
                {
                    Id = Guid.NewGuid().ToString(),
                    FullName = "Sample Translator",
                    Email = "sample.translator@example.com",
                    PasswordHash = "hashed_password_here",
                    ContactNo = "03149276066",
                    LocalizationLanguage = "English",
                    fullAddress="Xyz Address",
                    TransOfficeId = "e580075e-6b2c-439a-b164-e001877962d6"
                }
                //,new Translators
                //{
                //    TranslOffice = 
                //}
            );
        }
        private void SeedApplicationUsers(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {
                    Id = Guid.NewGuid().ToString(),
                    UserName = "sample.applicationuser",
                    Email = "sample.applicationuser@example.com",
                    PasswordHash = "hashed_password_here",
                    ContactNo = "03149276066",
                    LocalizationLanguage = "English",
                    FullName="Abdullah Khan"
                }
            );
        }

        private void SeedTranslationOfficers(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TranslOffice>().HasData(
                new TranslOffice
                {
                    Id = "e580075e-6b2c-439a-b164-e001877962d6",
                    FullName = "Sample Translation Officer",
                    Email = "sample.officer@example.com",
                    PasswordHash = "hashed_password_here",
                    ContactNo = "03149276066",
                    LocalizationLanguage = "English",
                    City="Peshawar",
                    CompOwnerName="ABC",
                    CompanyName="XYZ company",
                }
            );
        }
    }
}
