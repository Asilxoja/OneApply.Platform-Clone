

using Microsoft.EntityFrameworkCore;
using OneApplyDataAccessLayer.Data;
using OneApplyDataAccessLayer.Interfaces;

namespace OneApplyDataAccessLayer.Repositories;

public class UnitOfWork(ApplicationDbContext dbContext,
                        ICertificateInterface certificateInterface,
                        IEducationInterface educationInterface, 
                        ILanguageInterface languageInterface,
                        ILinkInterface linkInterface, 
                        IProjectInterface projectInterface,
                        ISkillInterface skillInterface,
                        IWorkExperienceInterface workExperienceInterface) : IUnitOfWork
{
    private readonly ApplicationDbContext _dbContext = dbContext;
    
    public ICertificateInterface CertificateInterface { get; } = certificateInterface;

    public IEducationInterface EducationInterface { get; } = educationInterface;

    public ILanguageInterface LanguageInterface { get; } = languageInterface;

    public ILinkInterface LinkInterface { get; } = linkInterface;

    public IProjectInterface ProjectInterface { get; } = projectInterface;

    public ISkillInterface SkillInterface { get; } = skillInterface;

    public IWorkExperienceInterface WorkExperienceInterface { get; } = workExperienceInterface;

    public void Dispose()
     => GC.SuppressFinalize(this);
    public async Task SaveAsync()
            => await _dbContext.SaveChangesAsync();
}
