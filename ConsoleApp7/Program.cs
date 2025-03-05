namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Services services = new Services("Server=LAPTOP-P8PNFQFL;Database=Students;Integrated Security=True;TrustServerCertificate=True;");
            services.insertstudent();
        }
       
    }

}
