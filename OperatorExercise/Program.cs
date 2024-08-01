namespace OperatorExercise
{
    public class Program
    {
        public static double AreaOfCircle(double radius)
        {
            var area = Math.PI * radius * radius;
            return area;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("What is the radius of your circle?");
            var userInput = Console.ReadLine();
            var radius = double.Parse(userInput);

            AreaOfCircle(radius);

            Console.WriteLine(AreaOfCircle(radius));


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
