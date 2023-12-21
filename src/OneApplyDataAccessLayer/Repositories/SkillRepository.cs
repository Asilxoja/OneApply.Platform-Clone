using OneApplyDataAccessLayer.Data;
using OneApplyDataAccessLayer.Entities.Resumes;
using OneApplyDataAccessLayer.Interfaces;

namespace OneApplyDataAccessLayer.Repositories;

public class SkillRepository : Repository<Skill>, ISkillInterface
{
    public SkillRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}
