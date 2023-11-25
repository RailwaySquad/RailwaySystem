using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Railway_Group01.Data;

// Add profile data for application users by adding properties to the AppUser class
public class User : IdentityUser
{
    public List<Passenger>? Passengers { get; set; }
    public List<Feedback>? Feedbacks { get; set; }
}

