using System.ComponentModel.DataAnnotations;

namespace myATM.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}