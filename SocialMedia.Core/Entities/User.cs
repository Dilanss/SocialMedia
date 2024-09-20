namespace SocialMedia.Core.Entities
{
    public partial class User
    {

        public User()
        {
            Comments = new HashSet<Comment>();
            Posts = new HashSet<Post>();
        }

        public int UserId { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string Email { get; set; } = null!;

        public DateOnly DateOfBirth { get; set; }

        public string? Telephone { get; set; }

        public bool IsActive { get; set; }

        public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

        public virtual ICollection<Post> Posts { get; set; } = new List<Post>();
    }
}