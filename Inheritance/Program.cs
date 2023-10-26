
    internal class Program
{
    private static void Main(string[] args)
    {
        // Customer customer = new Customer();
        // customer.Name = "Engin";
        // customer.LastName = "Demiroğ";
        // customer.Id = 1;

        Person[] persons = new Person[2]
        {
            new Customer {Id = 1, Name = "Engin", LastName = "Demiroğ", City = "Ankara"},
            new Student {Id = 1, Name = "Derin", LastName = "Demiroğ", Department = "Computer Sciences"}
        };

        foreach (var person in persons)
        {
            Console.WriteLine(person.Name);
        };
    }

    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
    }

    class Customer : Person
    {
        public string City { get; set; }
    }

    class Student : Person
    {
        public string Department { get; set; }
    }
}