using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ApplicationDataLibrary.Models
{
    public class Email
    {
        public int Id { get; set; }

        public int PersonId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string EmailAddress { get; set; }
    }
}
