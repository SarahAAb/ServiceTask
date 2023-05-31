using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServiceTask.data
{
    [Table("Intrested")]
    public class Intrested
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
