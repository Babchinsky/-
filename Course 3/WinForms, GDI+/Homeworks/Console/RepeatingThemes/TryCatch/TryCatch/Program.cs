public class Math
{
    public int NumToInt()
    {
        try
        {
            int num = Convert.ToInt32(Console.ReadLine());
            return num;
        }
        catch (FormatException)
        {
            throw;
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Math m = new Math();
        try
        {
            int num = m.NumToInt();
            Console.WriteLine(num);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
