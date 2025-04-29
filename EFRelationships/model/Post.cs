using Microsoft.Extensions.Hosting;

namespace EFRelationships.model
{
    public class Post
    {
        public int Id { get; set; }
        public string? Content { get; set; }
        public Blog? Blog { get; set; }
        public int BlogId { get; set; }
    }
}
