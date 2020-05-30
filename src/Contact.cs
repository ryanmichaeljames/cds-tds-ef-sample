using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sample
{
    [Table("contact")]
    public class Contact
    {
        [Column("contactid")]
        public Guid Id { get; set; }

        [Column("fullname")]
        public string FullName { get; set; }
    }
}
