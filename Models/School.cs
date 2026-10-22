using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace A1.Models
{
    public class School
    {
        [Key]
        public int Id { set; get; }

        [MaxLength(100)]
        [Required]
        public string Name { set; get; } = string.Empty;

        public string Address { get; set; } = string.Empty; 

        public string City { get; set; } = string.Empty;

        public Collection<Student> Students { set; get; } = new Collection<Student>() ;

        public Collection<Teacher> Teachers { set; get; } = new Collection<Teacher>() ;
    }
}
