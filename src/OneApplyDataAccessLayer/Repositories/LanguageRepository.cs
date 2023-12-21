using OneApplyDataAccessLayer.Data;
using OneApplyDataAccessLayer.Entities.Resumes;
using OneApplyDataAccessLayer.Interfaces;

namespace OneApplyDataAccessLayer.Repositories;

public class LanguageRepository : Repository<Language>, ILanguageInterface
{
    public LanguageRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}
