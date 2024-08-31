namespace Tutorial.Models
{
    public class AuthorEntity
    {
        public Guid Id { get; set; }

        public string UserName { get; set; } = string.Empty;

        public Guid CourseID { get; set; }
        public CourseEntity? Course { get; set; }
    }
}
