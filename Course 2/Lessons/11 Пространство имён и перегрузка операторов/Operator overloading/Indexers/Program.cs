using System;

class myarray
{
    int[] ar;
    public myarray()
    {
        ar = new int[10];
    }
    public myarray(params int[] b)
    {
        ar = new int[b.Length];
        for (int i = 0; i < b.Length; i++)
            ar[i] = b[i];
    }
    public myarray(int size)
    {
        ar = new int[size];
    }
    public int this[int index]
    {
        get
        {
            if (index >= 0 && index < ar.Length)
            {
                return ar[index];
            }
            else
            {
                throw new Exception("Некорректный индекс! " + index);
            }
        }
        set
        {
            if (index >= 0 && index < ar.Length)
            {
                ar[index] = value;
            }
            else
            {
                throw new Exception("Некорректный индекс! " + index);
            }
        }
    }
}

public class MultArray
{
    private int[,] array;
    public int Rows
    {
        get;
        private set;
    }
    public int Cols
    {
        get;
        private set;
    }
    public MultArray(int rows, int cols)
    {
        Rows = rows;
        Cols = cols;
        array = new int[rows, cols];
    }
    public int this[int r, int c]
    {
        get
        {
            if (r < 0 || r >= array.GetLength(0))
            {
                throw new Exception("Некорректный индекс! " + r);
            }
            else if (c < 0 || c >= array.GetLength(1))
            {
                throw new Exception("Некорректный индекс! " + c);
            }
            else
                return array[r, c];
        }
        set
        {
            if (r < 0 || r >= array.GetLength(0))
            {
                throw new Exception("Некорректный индекс! " + r);
            }
            else if (c < 0 || c >= array.GetLength(1))
            {
                throw new Exception("Некорректный индекс! " + c);
            }
            else
                array[r, c] = value;
        }
    }
}

class UseArray
{
    public static void Main()
    {
        myarray ar = new myarray(10);
        Random rnd = new Random();
        for (int i = 0; i < 20; i++)
        {
            try
            {
                ar[i] = rnd.Next(1, 30);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        for (int i = 0; i < 20; i++)
        {
            try
            {
                Console.WriteLine(ar[i]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        myarray ar2 = new myarray(10, 20, 30, 40);
        Console.WriteLine("\n\n");
        for (int i = 0; i < 10; i++)
        {
            try
            {
                Console.WriteLine(ar2[i]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        MultArray multArray = new MultArray(2, 3);
        for (int i = 0; i < multArray.Rows; i++)
        {
            for (int j = 0; j < multArray.Cols; j++)
            {
                try
                {
                    multArray[i, j] = i + j;
                    Console.WriteLine(multArray[i, j] + " ");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }              
            }
            Console.WriteLine();
        }

    }
}