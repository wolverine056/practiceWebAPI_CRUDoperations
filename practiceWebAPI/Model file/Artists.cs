using System.ComponentModel.DataAnnotations;

namespace practiceWebAPI.Model_file
{
    public class Artists
    {
        public int Id { get; set; }
        [StringLength(60)]
        public string Name { get; set; }=string.Empty;
        public int Experience { get; set; }
        [StringLength(10)]
        public string Status { get; set; }=string.Empty ;
        public int ProfessionId { get; set; }
        public TypeOfProfessions? TypeOfProfession {get;set;}
        
    }
}
