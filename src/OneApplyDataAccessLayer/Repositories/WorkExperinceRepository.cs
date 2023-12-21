using OneApplyDataAccessLayer.Entities.Resumes;
using OneApplyDataAccessLayer.Interfaces;

namespace OneApplyDataAccessLayer.Repositories;

public class WorkExperinceRepository : IWorkExperienceInterface
{
    public Task<WorkExperience> AddAsync(WorkExperience entity)
    {
        throw new NotImplementedException();
    }

    public Task<WorkExperience> DeleteAsync(WorkExperience entity)
    {
        throw new NotImplementedException();
    }

    public Task<IQueryable<WorkExperience>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<WorkExperience> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(WorkExperience entity)
    {
        throw new NotImplementedException();
    }
}
