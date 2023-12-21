using OneApplyDataAccessLayer.Data;
using OneApplyDataAccessLayer.Entities.Resumes;
using OneApplyDataAccessLayer.Interfaces;

namespace OneApplyDataAccessLayer.Repositories;

public class ProjectRepository : Repository<Project>, IProjectInterface
{
    public ProjectRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}
