using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    //Class GuestResponse model data with basic validation
    public class GuestResponse
    {
        [Required(ErrorMessage = "Input your name and last name")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Input your Nickname")]
        public string Nickname { get; set; }
        
        [Required(ErrorMessage = "Input your email address")]
        [RegularExpressionAttribute(".+\\@.+\\..+",
            ErrorMessage = "Input correct email address")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Input your phone number")]
        public string Phone { get; set; }
        
        [Required(ErrorMessage = "Declare if you are The Master of The Universe or looser")]
        public bool? WillAttend { get; set; } //Attribute WillAttend is marked as nullable in boolean type.
    }
}