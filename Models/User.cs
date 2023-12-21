namespace inoutboard24_api.Models
{
    public class User
    {
        public int Id { get; set; }
        public required string Username { get; set; }
        public required string DisplayName { get; set; }
        public required int GroupId { get; set; }
        public required bool Enabled { get; set; }
    }
}
