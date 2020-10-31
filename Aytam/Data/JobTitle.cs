using System.ComponentModel.DataAnnotations;


namespace Aytam.Data

{
    public class JobTitle
    {
        [Key]
        public string Title { get; set; }
        public string Description { get; set; }
    }
}