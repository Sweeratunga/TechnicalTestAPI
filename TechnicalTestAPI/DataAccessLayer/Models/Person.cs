using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechnicalTestAPI.DataAccessLayer.Models
{

    [Table("People")]
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Unicode(false)]
        [MaxLength(50)]
        [Column("name")]
        public string? Name { get; set; }

        [DataType(DataType.Date)]
        [Column("date_of_birth", TypeName = "Date")]
        public DateTime? DateOfBirth { get; set; }

        [DataType(DataType.Date)]
        [Column("start_date", TypeName = "Date")]
        public DateTime? StartDate { get; set; }
        [Column("active")]
        public bool? Active { get; set; }
        public Person()
        {

        }
        public Person(int id, string name, DateTime dob, DateTime startDate, bool active)
        {
            this.Id = id;
            this.Name = name;
            this.DateOfBirth = dob;
            this.StartDate = startDate;
            this.Active = active;
        }
        public ICollection<Shift>? Shifts { get; }
    }
}
