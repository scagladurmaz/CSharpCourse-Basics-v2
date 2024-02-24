//Yapıcı blok: class'ı ilk kez yapılandırdığımızda oluşacak kodlar burada yr alır

namespace Constructors
{
    class Program
    {
        static void Main(string[] args) 
        {
            Customer customer1 = new Customer {Id=1, FirstName="Çağla", LastName="Durmaz", City="Sinop" };

            Customer customer2 = new Customer (2, "Özgü", "Durmaz", "Trabzon" );

            Console.WriteLine(customer2.FirstName);


            //Method(2, "fdvdf", "gbsgbsgb","fvdfvsdfv");
        
        }

        //static void Method(int id, string firstName, string lastName, string city)
        //{

        //}


    }

    class Customer
    {
        public Customer()
        {
            
        }


        // default constrctr. yazsak da yazmasak da çalışır bu kısım
        public Customer(int id, string firstName,string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
            
            Console.WriteLine("Yapıcı blok çalıştı.");
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}