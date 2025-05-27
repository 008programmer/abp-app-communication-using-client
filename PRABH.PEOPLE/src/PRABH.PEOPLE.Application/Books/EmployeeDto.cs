using System;

namespace PRABH.PEOPLE.Books
{
    public class EmployeeDto
    {
        public string Name { get; internal set; }
        public int Id { get; internal set; }
        public string Department { get; internal set; }
        public DateTime JoiningDate { get; internal set; }
    }
}