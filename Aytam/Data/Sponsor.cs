using System.Collections.Generic;

namespace Aytam.Data
{
    public class Sponsor : Person
    {
        public List<Sponsorship> Sponsorships { get; set; } = new List<Sponsorship>();

    }
}