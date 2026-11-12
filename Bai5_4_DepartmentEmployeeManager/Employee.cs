using System;

namespace Bai5_4_DepartmentEmployeeManager
{
    public class Employee
    {
        public string EmployeeId { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string Position { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public string DepartmentPath { get; set; } = string.Empty;
        public string Gender { get; set; } = "Nam"; // "Nam" or "Nữ"

        public Employee() { }

        public Employee(string id, string name, string position, DateTime startDate, string deptPath, string gender = "Nam")
        {
            EmployeeId = id;
            FullName = name;
            Position = position;
            StartDate = startDate;
            DepartmentPath = deptPath;
            Gender = gender;
        }
    }
}
