using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServiceTask.data
{
    [Table("Services")]
    public class Service
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
