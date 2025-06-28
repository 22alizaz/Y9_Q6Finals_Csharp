namespace Y9_Q6Finals_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string user1 = "Yusuf5";
            string user2 = "Mary80";
            string pass1 = "33kk";
            string pass2 = "af5r";
            bool access = false;
            while (access == false)
            {
                Console.WriteLine("Enter username");
                string username = Console.ReadLine();
                Console.WriteLine("Enter password");
                string password = Console.ReadLine();
                if (username == user1 && password == pass1)
                {
                    Console.WriteLine("Access granted");
                    access = true;
                }
                else if (username == user2 && password == pass2)
                {
                    Console.WriteLine("Access granted");
                    access = true;
                } else
                {
                    Console.WriteLine("Access denied");
                }
                    
            }
        }
    }
}
