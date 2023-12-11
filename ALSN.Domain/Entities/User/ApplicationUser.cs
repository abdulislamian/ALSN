namespace ALSN.Domain.Entities.User
{
    public class ApplicationUser: Microsoft.AspNetCore.Identity.IdentityUser
    {
        public string FullName { get; set; }
        public string LocalizationLanguage { get; set; }
        public string ContactNo { get; set; }
    }
}
