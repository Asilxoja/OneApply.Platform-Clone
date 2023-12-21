using OneApplyDataAccessLayer.Data;
using OneApplyDataAccessLayer.Entities.Resumes;
using OneApplyDataAccessLayer.Interfaces;

namespace OneApplyDataAccessLayer.Repositories;

public class LinkRepository : Repository<Link>, ILinkInterface
{
    public LinkRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}
