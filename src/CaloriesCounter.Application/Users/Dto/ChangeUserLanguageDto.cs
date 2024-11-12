using System.ComponentModel.DataAnnotations;

namespace CaloriesCounter.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}