using EFRelationships.Controllers;

namespace EFRelationships.model
{
    public class User
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public Profile? Profile { get; set; }
        public ICollection <CourseStudent>? CourseStudent { get; set; }
    }
}
