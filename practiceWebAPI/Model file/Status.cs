using System.ComponentModel.DataAnnotations;

namespace practiceWebAPI.Model_file
{
    public class Status
    {
        public int Id { get; set; }
        [StringLength(30)]
        public string StatusOptons { get; set; }=string.Empty;
    }
}
