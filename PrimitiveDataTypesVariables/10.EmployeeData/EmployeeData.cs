using System;
class EmployeeData
{
    static void Main()
    {
        Console.WriteLine("Enter your first name:");
        string firstName = Console.ReadLine();
        Console.WriteLine("Enter your last name:");
        string lastName = Console.ReadLine();
        Console.WriteLine("Enter your age:");
        byte age = (byte) int.Parse(Console.ReadLine());
        Console.WriteLine("Enter your gender m/f:");
        char gender = Convert.ToChar(Console.ReadLine());
        long perIdNum = 8306112507L;
        Console.WriteLine("Enter your Unique employee number:");
        int empNumber = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Here is the Employee Data you requested");
        Console.WriteLine("First Name: {0}", firstName);
        Console.WriteLine("Last Name: {0}", lastName);
        Console.WriteLine("Age: {0}", age);
        Console.WriteLine("Gender m/f: {0}", gender);
        Console.WriteLine("Personel ID number: {0}", perIdNum);
        Console.WriteLine("Unique employee number: {0}", empNumber);
    }
}
