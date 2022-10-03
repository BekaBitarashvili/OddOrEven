internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Please Enter Any Number: ");
        int randomNumber = int.Parse(Console.ReadLine());


        if (randomNumber % 2 == 0)
        {
            Console.WriteLine("Even");
        }
        else if (randomNumber % 2 == 1)
        {
            Console.WriteLine("Odd");
        }
        else if (randomNumber == 0)
        {
            Console.WriteLine("ZERO");
        }
}