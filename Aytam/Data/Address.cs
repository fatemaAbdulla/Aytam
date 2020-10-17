using Microsoft.EntityFrameworkCore;

namespace Aytam.Data
{
    [Owned]
    public class Address
    {
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string City { get; set; }
        public Country Country { get; set; }

    }
}