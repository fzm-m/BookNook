﻿using Microsoft.AspNetCore.Identity;

namespace BookNook.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class BookNookUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

    }
}
