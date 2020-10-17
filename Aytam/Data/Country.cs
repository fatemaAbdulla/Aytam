using System.ComponentModel.DataAnnotations;

namespace Aytam.Data
{
    public class Country
    {
        [Key]
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
    }

}