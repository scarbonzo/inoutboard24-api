namespace inoutboard24_api.Models
{
    public class Status
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public bool Working { get; set; } //Does this status count as being out
        public bool Enabled { get; set; }
    }
}
