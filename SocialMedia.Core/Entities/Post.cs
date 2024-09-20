namespace SocialMedia.Core.Entities
{
    public partial class Post
    {

        public Post()
        {
            Comments = new HashSet<Comment>();
        }

        public int PostId { get; set; }

        public int UserId { get; set; }

        public DateTime Date { get; set; }

        public string Description { get; set; } = null!;

        public string? Image { get; set; }

        public virtual User User { get; set; } = null!;

        public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }
}