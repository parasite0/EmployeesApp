using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EmployeesApp.Models;

namespace EmployeesApp
{
    /// <summary>
    /// Контекст данных, используемый для взаимодействия с базой данных
    /// </summary>
    class EmployeesContext : DbContext
    {
        public EmployeesContext()
            : base("DefaultConnection") 
        { }
        /// <summary>
        /// Набор сущностей, хранящихся в базе данных
        /// </summary>
        public DbSet<Employee> Employees { get; set; }     
    }
}
