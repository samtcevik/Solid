// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Index();
Home();
Product();

static void Index() {
    Container container = new Container();
    container.GetInstance().GetCategory();
}

static void Home() {
    Container container = new Container();
    container.GetInstance().GetCategory();
}

static void Product() {
    Container container = new Container();
    container.GetInstance().GetCategory();
}
public class Container{
    public IRespository GetInstance(){
        return new EfRepository();
        //return new DapperRepository();
        //return new DemoRepository();
    }
}
public interface IRespository {
    void GetCategory();
}
public class EfRepository:IRespository {
    public void GetCategory() {
        Console.WriteLine("EfCategory");
    }
}
public class DapperRepository:IRespository {
    public void GetCategory() {
        Console.WriteLine("DpCategory");
    }
}
public class DemoRepository:IRespository {
    public void GetCategory() {
        Console.WriteLine("DemoCategory");
    }
}