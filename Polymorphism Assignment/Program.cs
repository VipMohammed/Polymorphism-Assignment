using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of Employee and assign values
        Employee employee = new Employee
        {
            Id = 103,
            FirstName = "Mohammed",
            LastName = "Khan"
        };

        // Use polymorphism: assign the Employee object to an IQuittable interface reference
        IQuittable quittableEmployee = employee;

        // Call the Quit method using the interface reference
        quittableEmployee.Quit();

        // This demonstrates polymorphism: the method call is resolved at runtime
    }
}