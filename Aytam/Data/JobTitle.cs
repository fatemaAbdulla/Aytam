using System;
using System.ComponentModel.DataAnnotations;


namespace Aytam.Data

{
    public class JobTitle
    {
        [Key]
        public Guid ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}