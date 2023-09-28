namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount willsAccount = new BankAccount();
            Console.WriteLine("How much would you like to deposit?");
            var amountToDep = double.Parse(Console.ReadLine());

            willsAccount.Deposit(amountToDep);

            Console.WriteLine($"Thank you, your account balance is now: {willsAccount.GetBalance()}");
        }
        //In the main method of your application, create a new instance of the BankAccount class.
        //Allow the user of the application to Deposit money and retrieve their balance through the console.
    }
}
