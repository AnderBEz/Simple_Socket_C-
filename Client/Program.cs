namespace Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client c = new Client("localhost", 4404);
            string user;
            string password;
            c.Start();
            while (true)
            {
                Console.WriteLine("Ingresa tu usuario. ");
                user = Console.ReadLine();
                c.Send(user);

                Console.WriteLine("Ingresa tu contrasena. ");
                password = Console.ReadLine();
                c.Send(password);

                Console.WriteLine("El estatus del login es: {0}", c.Receive());
            }

            Console.ReadKey();
        }
    }
}
