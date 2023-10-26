namespace Interfaces
{
internal class Program
{
    private static void Main(string[] args)
    {
    //    PersonManager personManager = new PersonManager();
    //    personManager.Add(new  Customer2 {
    //     Id=1,
    //     FirstName = "engin",
    //     LastName = "Demiroğ",
    //     Adress = "Ankara",
    //    });

    //    IPerson person = new Customer2();
    //    person.Id = 2;
    //    System.Console.WriteLine(person.Id);
    ICustomerDal[] customerDals = new ICustomerDal[2]
    {
        new SqlServerCustomerDal(),
        new OracleCustomerDal()
    };

    foreach (var item in customerDals)
    {
        item.Add();
    }
       
    }

}

    interface IPerson
    {
         int Id { get; set; }
         string FirstName { get; set; }
         string LastName { get; set; }
    }


    class Customer2:IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
    }

    class Student:IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }
  
    class PersonManager
    {
        public void Add(Customer2 customer2)
        {
          System.Console.WriteLine(customer2.FirstName);
        }
    }






}
