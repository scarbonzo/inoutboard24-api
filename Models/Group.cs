namespace inoutboard24_api.Models
{
    public class Group
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public bool Enabled { get; set; }
    }
}
