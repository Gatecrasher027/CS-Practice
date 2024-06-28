/*Question: Write a program that that demonstrates use of four basic principles of
object-oriented programming /Abstraction/, /Encapsulation/, /Inheritance/ and
/Polymorphism/
2. Use /Abstraction/ to define different classes for each person type such as Student
and Instructor. These classes should have behavior for that type of person.
3. Use /Encapsulation/ to keep many details private in each class.
4. Use /Inheritance/ by leveraging the implementation already created in the Person
class to save code in Student and Instructor classes.
5. Use /Polymorphism/ to create virtual methods that derived classes could override to
create specific behavior such as salary calculations.
6. Make sure to create appropriate /interfaces/ such as ICourseService, IStudentService,
IInstructorService, IDepartmentService, IPersonService, IPersonService (should have
person specific methods). IStudentService, IInstructorService should inherit from
IPersonService.*/

using System;
public abstract class Person
{
    private string _name;
    private DateTime _dob;
    private List<string> _addr;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public DateTime DOB
    {
        get { return _dob; }
        set { _dob = value; }
    }

    public List<string> Addr
    {
        get { return _addr; }
    }

    protected Person(string name, DateTime dob)
    {
        _name = name;
        _dob = dob;
        _addr = new List<string>();
    }

    public void AddAddress(string address)
    {
        _addr.Add(address);
    }

    public int CalculateAge()
    {
        int age = DateTime.Now.Year - _dob.Year;
        if (DateTime.Now.DayOfYear < _dob.DayOfYear)
            age--;

        return age;
    }

    public virtual decimal CalculateSalary()
    {
        return 0;
    }
}

public interface IPersonService
{
    void AddAddress(string address);
    int CalculateAge();
    decimal CalculateSalary();
}

public interface IStudentService : IPersonService
{
    void EnrollC(Course course);
    double CalculateGPA();
}

public interface IInstructorService : IPersonService
{
    void AssignToDept(Department department);
}

public interface ICourseService
{
    void AddStudent(Student student);
    List<Student> GetEnroll();
}

public interface IDepartmentService
{
    void AssignHead(Instructor instructor);
    void AddCourse(Course course);
}

public class Student : Person, IStudentService
{
    private List<Course> _courses;
    private Dictionary<Course, char> _grades;

    public Student(string name, DateTime dob) : base(name, dob)
    {
        _courses = new List<Course>();
        _grades = new Dictionary<Course, char>();
    }

    public void EnrollC(Course course)
    {
        _courses.Add(course);
        course.AddStudent(this);
    }

    public void AddGrade(Course course, char grade)
    {
        if (_courses.Contains(course))
        {
            _grades[course] = grade;
        }
    }

    public double CalculateGPA()
    {
        double totalPoints = 0;
        int totalCourses = _grades.Count;

        if (totalCourses == 0)
        {
            return 0;
        }

        foreach (var grade in _grades.Values)
        {
            totalPoints += Cgpa(grade);
        }

        return totalPoints / totalCourses;
    }

    private double Cgpa(char grade)
    {
        switch (grade)
        {
            case 'A':
                return 4.0;
            case 'B':
                return 3.5;
            case 'C':
                return 2.5;
            case 'D':
                return 1.5;
            case 'F':
                return 0.0;
            default:
                throw new ArgumentException("Invalid grade");
        }
    }
}

public class Instructor : Person, IInstructorService
{
    private decimal _baseSalary;
    private DateTime _joinDate;
    private Department _department;

    public Instructor(string name, DateTime dob, decimal baseSalary, DateTime joinDate)
        : base(name, dob)
    {
        _baseSalary = baseSalary;
        _joinDate = joinDate;
    }

    public void AssignDept(Department department)
    {
        _department = department;
    }

    public override decimal CalculateSalary()
    {
        int yearsOfExperience = DateTime.Now.Year - _joinDate.Year;
        if (DateTime.Now.DayOfYear < _joinDate.DayOfYear)
            yearsOfExperience--;

        return _baseSalary + (yearsOfExperience * 1000);
    }
}

public class Course : ICourseService
{
    public string CourseName { get; set; }
    private List<Student> _enrolledStudents;

    public Course(string courseName)
    {
        CourseName = courseName;
        _enrolledStudents = new List<Student>();
    }

    public void AddStudent(Student student)
    {
        _enrolledStudents.Add(student);
    }

    public List<Student> GetEnroll()
    {
        return _enrolledStudents;
    }
}

public class Department : IDepartmentService
{
    public string DepartmentName { get; set; }
    private Instructor _head;
    private decimal _budget;
    private List<Course> _courses;

    public Department(string departmentName, decimal budget)
    {
        DepartmentName = departmentName;
        _budget = budget;
        _courses = new List<Course>();
    }

    public void AssignHead(Instructor instructor)
    {
        _head = instructor;
    }

    public void AddCourse(Course course)
    {
        _courses.Add(course);
    }
}
