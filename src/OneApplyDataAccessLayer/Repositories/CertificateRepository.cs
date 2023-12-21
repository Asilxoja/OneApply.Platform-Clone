using OneApplyDataAccessLayer.Data;
using OneApplyDataAccessLayer.Entities.Resumes;
using OneApplyDataAccessLayer.Interfaces;

namespace OneApplyDataAccessLayer.Repositories;

public class CertificateRepository : Repository<Certificate>, ICertificateInterface
{
    public CertificateRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}
