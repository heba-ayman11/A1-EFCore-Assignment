using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace A1.Models
{
    public class Subject
    {
        [Key]
        public int Id { get; set; } 

        [Required]
        public string Name { get; set; } = string.Empty; 

        public int Credits { get; set; } 

        public string Code { get; set; } = string.Empty; 

        public Teacher Teacher { get; set; }
        [ForeignKey(nameof(TeacherId))]
        public int TeacherId { get; set; }

        public Collection <Student> Students { get; set; } = new Collection<Student>();
    }


}
