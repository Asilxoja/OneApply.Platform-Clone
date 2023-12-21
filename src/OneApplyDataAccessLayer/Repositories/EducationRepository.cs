using OneApplyDataAccessLayer.Data;
using OneApplyDataAccessLayer.Entities.Resumes;
using OneApplyDataAccessLayer.Interfaces;

namespace OneApplyDataAccessLayer.Repositories;

public class EducationRepository : Repository<Education>, IEducationInterface
{
    public EducationRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}
