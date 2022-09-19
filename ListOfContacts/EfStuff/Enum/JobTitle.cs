using System.ComponentModel.DataAnnotations;

namespace ListOfContacts.EfStuff.Enum
{
    public enum JobTitle
    {
        [Display(Name = "МАЗ")]
        MAZ = 0,
        [Display(Name = "МТЗ")]
        MTZ,
        [Display(Name = "Грин")]
        Green,
        [Display(Name = "Епам")]
        Epam,
        [Display(Name = "Майкрософт")]
        Microsoft,
        [Display(Name = "Нетфликс")]
        Netflix,
    }
}
