namespace Repository.Dtos
{
    public class RequestDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int GroupId { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
    }
}
