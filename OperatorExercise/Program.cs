namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            var sum = a + b;
            var diff = a - b;
            var product = a * b;
            var quotient = a / b;
            var remainder = a % b;

            Console.WriteLine($"{a} + {b} is {sum}. \n " +
                $"{a} - {b} is {diff}. \n" +
                $"{a} * {b} is {product}. \n" +
                $"{a} / {b} is {quotient} remainder {remainder}.");
        }
    }
}
