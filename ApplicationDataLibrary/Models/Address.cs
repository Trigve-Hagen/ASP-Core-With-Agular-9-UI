using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ApplicationDataLibrary.Models
{
    public class Address
    {
        public int Id { get; set; }

        public int PersonId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string StreetAddress { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string City { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string State { get; set; }

        [Required]
        [Column(TypeName = "int")]
        public int ZipCode { get; set; }

    }
}
