using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesApp.Models
{
    public class Employee
    {
        /// <summary>
        /// Id сотрудника
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// ФИО сотрудника
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Должность сотрудника
        /// </summary>
        public string JobTitle { get; set; }
        /// <summary>
        /// Оклад сотрудника
        /// </summary>
        public decimal Salary { get; set; }
        /// <summary>
        /// Дата приёма на работу
        /// </summary>
        public DateTime EmploymentDate { get; set; }
        /// <summary>
        /// Дата увольнения
        /// </summary>
        public DateTime? DismissalDate { get; set; }
    }
}
