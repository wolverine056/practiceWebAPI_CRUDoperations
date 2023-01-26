using System.ComponentModel.DataAnnotations;

namespace practiceWebAPI.Model_file
{
    public class TypeOfProfessions
    {
        public int Id {get;set;}
        [StringLength(100)]
        public string Profession { get;set;}=string.Empty;
    }
}
