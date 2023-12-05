using Microsoft.AspNetCore.Identity;

namespace Railway_Group01.Data;

// Add profile data for application users by adding properties to the AppUser class
public class User : IdentityUser
{
    public List<Feedback>? Feedbacks { get; set; }
    public List<Booking>? Bookings { get; set; }
    public List<Cancelling>? Cancellings { get; set; }
}

