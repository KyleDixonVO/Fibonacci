namespace FibPractice
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Fib fib = new Fib();

            fib.CalculateFib(100000);
            fib.ValueAtIndex(10);
        }


    }
}