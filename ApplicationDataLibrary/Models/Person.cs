using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ApplicationDataLibrary.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string FirstName { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string LastName { get; set; }

        [Required]
        [Column(TypeName = "int")]
        public int Status { get; set; } // 1 = Active, 2 = Inactive

        [Required]
        [Column(TypeName = "int")]
        public int MemberType { get; set; } // 1 = Admin, 2 = Client, 3 = Service Provider

        [Required]
        [Column(TypeName = "nvarchar(255)")]
        public string Username { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(255)")]
        public string Password { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string ResetToken { get; set; }

        public List<Email> EmailAddresses { get; set; } = new List<Email>();

        public List<Address> Addresses { get; set; } = new List<Address>();
    }
}
