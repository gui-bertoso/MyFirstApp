namespace MyFirstApp;

public class MyApp
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 10; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i + " é par");
            }
            else
            {
                Console.WriteLine(i + " is impar");
            }
        }
    }
}