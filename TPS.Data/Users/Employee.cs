using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TPS.Data.Users
{
    public class Employee : PersonBase, IEmployee
    {
        public int EmployeeId { get; set; }

        public bool IsEmployed { get; set; }

        public DateTime JoinedAt { get; set; }

        public DateTime? LeftAt { get; set; }

    }

    public interface IEmployee
    {
        int EmployeeId { get; set; }
    }
}