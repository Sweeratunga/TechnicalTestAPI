namespace TechnicalTestAPI.DataAccessLayer.Models.Dtos
{
    public class ShiftDto
    {
        public int Id { get; set; }
        public string? Location { get; set; }
        public string? Role { get; set; }
        
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
    }
}
