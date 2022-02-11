// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//The Scenario is not proper to the open-closed principle.

public class FullTime {
    public void CalculatorSalary() {
        Console.WriteLine("FullTime");
    }
}

public class PartTime {
    public void CalculatorSalary() {
        Console.WriteLine("PartTime");
    }
}

public class Calculator {
    public void CalculatorSalary(string employeeType) {
        if(employeeType == null) {
            new ArgumentNullException("You have to set employee type");
        } else if(employeeType == "FullTime") {
            new FullTime().CalculatorSalary();
        } else {
            new PartTime().CalculatorSalary();
        }
    }
}

//Let's say we decided to hire support staff on special occasions.
//We need to change the salary calculation method for each new class we add.
//This is not a desired situation. It causes too many conditional cases,
//and while it may seem harmless at first, the method becomes more complex
//as the number of classes increases.
public class Supporter {
    public void CalculatorSalary() {
        Console.WriteLine("Supporter");
    }
}

public class Calculator2 {
    public void CalculatorSalary(string employeeType) {
        if(employeeType == null) {
            new ArgumentNullException("You have to set employee type");
        } else if(employeeType == "FullTime") {
            new FullTime().CalculatorSalary();
        } else if(employeeType == "Supporter") {
            new Supporter().CalculatorSalary();
        } else {
            new PartTime().CalculatorSalary();
        }
    }
}

