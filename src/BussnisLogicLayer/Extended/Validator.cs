using OneApplyDataAccessLayer.Entities.Resumes;

namespace BusnissLogicLayer.Extended
{
    public static class Validator
    {
        // Validator for Education class
        public static bool IsValid(this Education education)
            => education != null
               && !string.IsNullOrEmpty(education.Name)
               && !string.IsNullOrEmpty(education.Specialty);

        // Validator for Language class
        public static bool IsValid(this Language language)
            => language != null
               && !string.IsNullOrEmpty(language.Name)
               && language.Name.Length >= 2
               && language.Name.Length <= 255
               && language.Lavel != null
               && !string.IsNullOrEmpty(language.UserId);

    }
}
