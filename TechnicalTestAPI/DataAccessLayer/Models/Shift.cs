using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechnicalTestAPI.DataAccessLayer.Models
{
    //[Table("Claim")]
    //public class Claim
    //{
    //    [Key]
    //    [Column(TypeName = "varchar(20)")]
    //    public string UCR { get; set; }
    //    [ForeignKey(nameof(Models.Company))]
    //    public int CompanyId { get; set; }
    //    public DateTime ClaimDate { get; set; }
    //    public DateTime? LossDate { get; set; }
    //    [Column("Assured Name", Order = 4, TypeName = "varchar(100)")]
    //    public string? AssuredName { get; set; }

    //    [Column("Incurred Loss", Order = 5, TypeName = "decimal(15, 2)")]
    //    public decimal? IncurredLoss { get; set; }
    //    public bool Closed { get; set; }
    //    [ForeignKey(nameof(ClaimType))]
    //    public int ClaimTypeId { get; set; }

    //    public Company Company { get; }
    //    public ClaimType ClaimType { get; }

    //}
    [Table("Shifts")]
    public class Shift
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Unicode(false)]
        [MaxLength(50)]
        [Column("location")]
        public string? Location { get; set; }

        [Unicode(false)]
        [MaxLength(50)]
        [Column("role")]
        public string? Role { get; set; }

        [Column("person_id")]
        public int PersonId { get; set; }

        [DataType(DataType.Date)]
        [Column("start", TypeName = "Date")]
        public DateTime? Start { get; set; }

        [DataType(DataType.Date)]
        [Column("end", TypeName = "Date")]
        public DateTime? End { get; set; }
        public Shift()
        {

        }
        public Shift(int id, string? location, string? role, int personId, DateTime? start, DateTime? end)
        {
            this.Id = id;
            this.Location = location;
            this.Role = role;
            this.PersonId = personId;
            this.Start = start;
            this.End = end;
        }


    }
}
