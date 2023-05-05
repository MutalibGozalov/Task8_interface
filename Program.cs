namespace Task8_Interface;
internal class Program
{
    private static void Main(string[] args)
    {
        User user = new User(1, "Peter Parker", "peter@web.com", "ssswSF123");
        bool valid = user.PasswordChecker(user.Password);
        System.Console.WriteLine(valid);
        Console.WriteLine(user.ShowInfo());
    }
}