﻿using System;

namespace TPS.Data.Users
{
    public class Employee : IPerson, IEmployee
    {
        public int EmployeeId { get; set; }

        public int PersonId { get; set; }

        public bool IsEmployed { get; set; }

        public DateTime JoinedAt { get; set; }

        public DateTime? LeftAt { get; set; }
    }

    public interface IEmployee
    {
        int EmployeeId { get; set; }
    }
}