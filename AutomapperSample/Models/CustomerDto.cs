using System;

namespace AutomapperSample.Models
{
    public class CustomerDto
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public int Age { get; set; }

        public DateTime DOB { get; set; }
    }
}