public interface ILog
{
    public void Print(string message);
}

public class ConsoleLog: ILog
{
    public void Print(string message) 
    { 
        Console.WriteLine(message);
    }
}

public class FileLog : ILog
{
    public void Print(string message)
    {
        File.AppendAllText("../../../../log.txt", "| " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " |\n");
        File.AppendAllText("../../../../log.txt", message);
    }
}
