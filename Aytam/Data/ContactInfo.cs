﻿using Microsoft.EntityFrameworkCore;

namespace Aytam.Data
{
    [Owned]
    public class ContactInfo
    {
        public string PhoneNumber { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; }

    }
}