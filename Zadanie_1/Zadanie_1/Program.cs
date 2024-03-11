namespace Zadanie1;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World");

        Console.WriteLine("Goodbye World!");

        int[] inputArray = { 1, 2, 3, 4, 5, 6 };
        int[] inputArray2 = { 1, 6, 4, 4, 5, 9, 3, 2 };
        Console.WriteLine(average(inputArray));
        Console.WriteLine(max(inputArray2));
    }

    public static float average(int[] intArray)
    {
        float sum = 0.0f, averageResult = 0.0f;
        foreach(int i in intArray)
        {
            sum += i;
        }
        averageResult = sum / intArray.Length;

        return averageResult;
    }

    public static float max(int[] intArray)
    {
        int max = intArray[0];
        foreach (int i in intArray)
        {
            if(i > max)
            {
                max = i;
            }
        }
        return max;
    }
}