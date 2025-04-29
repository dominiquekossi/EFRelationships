namespace EFRelationships.model
{
    public class Profile
    {
        public int Id { get; set; }
        public string? Bio { get; set; }
        public User? User { get; set; }
        public int? UserId { get; set; }
    }
}
