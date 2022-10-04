namespace UniversitySystemWebApp.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string RegistrationNumber { get; set; }
        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public int DepartmentId { get; set; }
    }
}