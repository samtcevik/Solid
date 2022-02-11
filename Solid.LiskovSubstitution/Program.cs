// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Employee employeeFullTime = new FullTimeEmployee();
Employee employeePartTime = new PartTimeEmployee();
class Employee {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
}

class FullTimeEmployee:Employee {
    public int Weekday { get; set; }
}

class PartTimeEmployee:Employee {
    public int Hour { get; set; }
}