﻿namespace HumanResourceManagement.Models
{
    public class Employee : UserActivity
    {
        public int Id { get; set; }

        public string EmpId { get; set; }

        public string FirstName {  get; set; }

        public string MiddleName { get; set; }
        
        public string LastName { get; set; }

        public string FullName => $"{FirstName} {MiddleName} {LastName}";

        public int PhoneNumber {  get; set; }

        public string Email {  get; set; }

        public string Country {  get; set; }

        public string Address { get; set; }

        public String Department { get; set; }

        public string Desingnation { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime DateOfJoin { get; set; }


    }
}
