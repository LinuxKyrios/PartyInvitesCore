namespace PartyInvites.Models
{
    public class GuestResponse
    {
        public string Name { get; set; }
        public string Nickname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool? WillAttend { get; set; } //Attribute WillAttend is marked as nullable in boolean type.
    }
}