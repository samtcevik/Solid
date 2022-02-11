// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



//The Class is not proper to the Single Responsibility Principle.
public class Customer {
    List<Customer> list = new List<Customer>() {
        new Customer() {Name = "Samet", Id = 1},
        new Customer() {Name ="Esma", Id=2}
    };
    public string Name { get; set; }
    public int Id { get; set; }

    public bool ValidateName(string name) => !string.IsNullOrEmpty(name);

    public string GetName(int id) => list.Find(x => x.Id == id).Name;
}

//Separated Classes according to responsibilities.
public class Customer2 {
    public int Id { get; set; }
    public string Name { get; set; }
}

public class CustomerManager {

    List<Customer> list = new List<Customer>() {
        new Customer() {Name = "Samet", Id = 1},
        new Customer() {Name ="Esma", Id=2}
    };
    public string GetName(int id) => list.Find(x => x.Id == id).Name;
}

public class CustomerValidator {
    public bool ValidateName(string name) => !string.IsNullOrEmpty(name);
}