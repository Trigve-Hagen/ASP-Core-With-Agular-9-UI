using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace ApplicationDataLibrary.Models
{
    public static class ApplicationSeeder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            byte[] salt = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: "password",
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA1,
                iterationCount: 10000,
                numBytesRequested: 256 / 8
            ));
            modelBuilder.Entity<Person>().HasData(
                new Person
                {
                    Id = 1,
                    FirstName = "Trigve",
                    LastName = "Hagen",
                    Status = 1,
                    MemberType = 1,
                    Username = "trigve1",
                    Password = hashed
                },
                new Person
                {
                    Id = 2,
                    FirstName = "Trigve",
                    LastName = "Hagen",
                    Status = 1,
                    MemberType = 2,
                    Username = "trigve2",
                    Password = hashed
                },
                new Person
                {
                    Id = 3,
                    FirstName = "Trigve",
                    LastName = "Hagen",
                    Status = 1,
                    MemberType = 3,
                    Username = "trigve3",
                    Password = hashed
                }
            );

            modelBuilder.Entity<Address>().HasData(
                new Address
                {
                    Id = 1,
                    StreetAddress = "13066 Paddy Creek Ln",
                    City = "Lodi",
                    State = "CA",
                    ZipCode = 95240,
                    PersonId = 1
                },
                new Address
                {
                    Id = 2,
                    StreetAddress = "13066 Paddy Creek Ln",
                    City = "Lodi",
                    State = "CA",
                    ZipCode = 95240,
                    PersonId = 2
                },
                new Address
                {
                    Id = 3,
                    StreetAddress = "13066 Paddy Creek Ln",
                    City = "Lodi",
                    State = "CA",
                    ZipCode = 95240,
                    PersonId = 3
                }
            );

            modelBuilder.Entity<Email>().HasData(
                new Email
                {
                    Id = 1,
                    EmailAddress = "trigve.hagen@gmail.com",
                    PersonId = 1
                },
                new Email
                {
                    Id = 2,
                    EmailAddress = "trigve.hagen@gmail.com",
                    PersonId = 2
                },
                new Email
                {
                    Id = 3,
                    EmailAddress = "trigve.hagen@gmail.com",
                    PersonId = 3
                }
            );
        }
    }
}
