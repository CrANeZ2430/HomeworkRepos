namespace Homework3;

public class Student
{
    public Student(string firstName, string lastName, byte mark)
    {
        if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            throw new ArgumentException("First name and last name are required to be not null or empty");
        if (mark is 0 or > 12)
            throw new ArgumentException("Mark must be between 1 and 12");

        FirstName = firstName;
        LastName = lastName;
        Mark = mark;
    }

    public string FirstName { get; }
    public string LastName { get; }
    public byte Mark { get; }

    public override string ToString()
    {
        return $"{FirstName} {LastName}";
    }
}
