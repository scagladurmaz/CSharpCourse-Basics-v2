namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //interface'ler newlenemez dedik ama interface en nihayetinde bir referans tip olduğu için onu implemente eden classın referansını tutabilir
           // IPersonManager customerManager = new CustomerManager();
            

            //IPersonManager employeeManager = new EmployeeManager();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new  InternManager());
            
        }
    }

    interface IPersonManager
    {
        //unimplemented operations
        void Add();

        void Update();

    }

    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //müşteri ekleme kodları
            Console.WriteLine("Müşteri eklendi!");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri Güncellendi");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            //personel ekleme kodları
            Console.WriteLine("Personel eklendi!");

        }

        public void Update()
        {
            Console.WriteLine("Personel Güncellendi");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager) 
        {
            personManager.Add();
        }
  
    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer güncellendi");
        }
    }

}