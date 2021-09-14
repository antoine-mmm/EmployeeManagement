using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee()
                {
                    ID = 1,
                    Name = "Mary",
                    Department = Dept.IT,
                    Email = "mary@pragimtech.com"
                },
                new Employee()
                {
                    ID = 2,
                    Name = "John",
                    Department = Dept.HR,
                    Email = "john@pragimtech.com"
                }
            );
            //modelBuilder.Entity<AspNetUsers>



            
        }
    }
}
