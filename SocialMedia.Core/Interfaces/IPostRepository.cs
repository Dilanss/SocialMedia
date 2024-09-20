using SocialMedia.Core.Entities;

namespace SocialMedia.Core.Interfaces
{
    public interface IPostRepository
    {
            Task<IEnumerable<Post>> GetPosts();
    }
}
