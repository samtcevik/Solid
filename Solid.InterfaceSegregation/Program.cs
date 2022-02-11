// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
interface IRepository {
    void Add();
    void GetCategory(int id);
    void GetProduct(int id);
}

public class CategoryManager:IRepository {
    public void Add() {
        Console.WriteLine();
    }

    public void GetCategory(int id) {
        Console.WriteLine("Category ID : " + id);
    }

    public void GetProduct(int id) {
        throw new NotImplementedException();
    }
}

public class ProductManager:IRepository {
    public void Add() {
        Console.WriteLine("Product Added.");
    }

    public void GetCategory(int id) {
        throw new NotImplementedException();
    }

    public void GetProduct(int id) {
        Console.WriteLine("Product ID : " + id);

    }
}

//The CustomerManager Class doesn't need to contain the GetProduct() method.
//The same applies to the ProductManager Class for the GetCustomer() method.
//But both of them have to contain the Add() method.

interface IRepositoryNew {
    void Add();
}

interface ICustomerRespository {
    void GetCustomer(int id);
}

interface IProductRespository {
    void GetProduct(int id);
}

class CustomerManagerNew:ICustomerRespository, IRepositoryNew {
    public void Add() {
        Console.WriteLine("Customer Added.");
    }

    public void GetCustomer(int id) {
        Console.WriteLine("Customer ID : ", id);
    }
}

class ProductManagerNew:IProductRespository, IRepositoryNew {
    public void Add() {
        Console.WriteLine("Product Added.");
    }

    public void GetProduct(int id) {
        Console.WriteLine("Product ID : ", id);
    }
}    