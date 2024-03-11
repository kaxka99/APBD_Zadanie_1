namespace Zadanie1;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World");

        Console.WriteLine("Goodbye World!");

    }

    public static float average(int[] intArray)
    {
        float sum = 0.0f, average = 0.0f;
        foreach(int i in intArray)
        {
            sum += i;
        }
        average = sum / intArray.Length;

        return average;
    }
}