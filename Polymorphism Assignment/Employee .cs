using System;

// Employee class now implements the IQuittable interface
public class Employee : IQuittable
{
    // Unique identifier for the employee
    public int Id { get; set; }

    // First name of the employee
    public string FirstName { get; set; }

    // Last name of the employee
    public string LastName { get; set; }

    // Overload the '==' operator to compare employees by Id
    public static bool operator ==(Employee emp1, Employee emp2)
    {
        if (ReferenceEquals(emp1, emp2))
            return true;

        if (emp1 is null || emp2 is null)
            return false;

        return emp1.Id == emp2.Id;
    }

    // Overload the '!=' operator as required
    public static bool operator !=(Employee emp1, Employee emp2)
    {
        return !(emp1 == emp2);
    }

    // Override Equals to match the logic of '=='
    public override bool Equals(object obj)
    {
        return this == obj as Employee;
    }

    // Override GetHashCode to ensure consistency
    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }

    // Implement the Quit method from IQuittable
    public void Quit()
    {
        // Display a message indicating the employee has quit
        Console.WriteLine($"{FirstName} {LastName} (ID: {Id}) has quit the job.");
    }
}