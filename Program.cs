
namespace Access_modifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Ahmed", "Muscat", 24);
            Console.WriteLine(person.name);
            Console.WriteLine(person.address);
            Console.WriteLine(person.age);
            Console.WriteLine("------------------------------------------------");

            BankAccount bank = new BankAccount();
            bank.accNo = "123XXXXXXX565";
            //bank.accSalary = 21.230;

            Console.WriteLine("Account number is : " + bank.accNo);
            Console.WriteLine("Amount to be deposited : " + bank.accSalary);
            Console.WriteLine("------------------------------------------------");

            rectangle calcRectangle = new rectangle(2,3);
            Console.WriteLine();
        }
    }
}