namespace Repository.Dtos
{
    public class UserAccountDto
    {
        public int Id { get; set; }
        public int? TeamId { get; set; }
        public string UserName { get; set; }
        public int Balance { get; set; }
        public bool IsBanker { get; set; }
        public bool CanDoShlTraining { get; set; }
        public bool HasClaimedFree500 { get; set; }
    }
}
