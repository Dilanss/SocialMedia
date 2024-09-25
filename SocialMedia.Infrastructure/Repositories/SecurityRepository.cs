using Microsoft.EntityFrameworkCore;
using SocialMedia.Core.Entities;
using SocialMedia.Core.Interfaces;
using SocialMedia.Infrastructure.Data;

namespace SocialMedia.Infrastructure.Repositories
{
    public class SecurityRepository : BaseRepository<Security>, ISecurityRepository
    {
        public SecurityRepository(SocialMediaContext context) : base(context)
        {
        }

        public async Task<Security> GetLoginByCredencials(UserLogin login)
        {
            //return await _entities.FirstOrDefaultAsync(x => x.User == login.User && x.Password == login.Password);
            return await _entities.FirstOrDefaultAsync(x => x.User == login.User);
        }
    }
}
