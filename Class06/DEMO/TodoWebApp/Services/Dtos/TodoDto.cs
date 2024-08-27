namespace TodoWebApp.Services.Dtos
{
    public class TodoDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public string Category { get; set; }
        public string Status { get; set; }
    }
}
