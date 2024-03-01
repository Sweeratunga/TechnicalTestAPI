namespace TechnicalTestAPI.DataAccessLayer.Models.Dtos
{
    public class PersonDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime? StartDate { get; set; }
        public bool Active { get; set; }

        public List<ShiftDto>? Shifts { get; set; }
    }
}
