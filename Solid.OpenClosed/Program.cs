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

//Now We are creating the system with a new design to obey The OCP by using Polymorphism

public enum WeekDay{
    FullTime = 22,
    PartTime = 14,
    Supporter = 4

}
public interface IEmployee {
    double CalculateSalary();
}

public class FullTimeNew:IEmployee {
    public double CalculateSalary() {
        return (int)WeekDay.FullTime * 100.00;
    }
}

public class PartTimeNew:IEmployee {
    public double CalculateSalary() {
        return (int)WeekDay.PartTime * 100.00;
    }
}

public class SupporterNew:IEmployee {
    public double CalculateSalary() {
        return (int)WeekDay.Supporter * 100.00;
    }
}

public class CalculatorNew{
    IEmployee _employee;
    public CalculatorNew(IEmployee employee) {
        _employee = employee;
    }

    public double CalculateSalary() {
        return _employee.CalculateSalary();
    }
}


public class BaseUI {
    public void ShowSalary() {
        CalculatorNew calculatorFullTime = new CalculatorNew(new FullTimeNew());
        CalculatorNew calculatorPartTime = new CalculatorNew(new PartTimeNew());
        CalculatorNew calculatorSupporter = new CalculatorNew(new SupporterNew());
    }
}