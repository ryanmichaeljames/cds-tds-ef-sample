using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sample
{
    [Table("contact")]
    public class Contact
    {
        [Column("contactid")]
        public Guid Id { get; set; }

        [Column("firstname")]
        public string FirstName { get; set; }

        [Column("lastname")]
        public string LastName { get; set; }
    }
}
