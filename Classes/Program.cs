namespace Classes;
internal class Program
{
    private static void Main(string[] args)
    {
        CustomerManager customerManager = new CustomerManager();
        customerManager.Add();
        customerManager.Updated();

        ProductManager productManager = new ProductManager();
        productManager.Add();
        productManager.Updated();

        Customer  customer = new Customer();
        customer.Id = 1;
        customer.FirstNmae = "Engin";
        customer.LastName = "Demiroğ";
        customer.City = "Ankara";

       System.Console.WriteLine(customer.FirstNmae);
        
    }
}

class CustomerManager
{
    public void Add()
    {
        System.Console.WriteLine("Customer Added!");
    }
    public void Updated()
    {
        System.Console.WriteLine("Customer Updated!");
    }
}

