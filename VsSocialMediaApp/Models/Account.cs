namespace VsSocialMediaApp.Models
{
    public class Account
    {
        public ulong Id { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }

        // these arent coded yet will add them later
        public string? PasswordHash { get; set; }
        public string? PasswordSalt { get; set; }
    }
}
