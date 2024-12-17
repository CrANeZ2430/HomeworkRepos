namespace Homework3;

public class Employee
{
    public Employee(string firstName, string lastName, DateTime dateOfBirth, DateTime dateOfEmployment)
    {
        if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            throw new ArgumentException("First name and last name are required to be not null or empty");

        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
        DateOfEmployment = dateOfEmployment;
    }

    public string FirstName { get; }
    public string LastName { get; }
    public DateTime DateOfBirth { get; }
    public DateTime DateOfEmployment { get; }

    public override string ToString()
    {
        return $"{FirstName} {LastName}";
    }
}
