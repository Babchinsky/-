using System;

class Store : IDisposable
{
    private bool disposed = false;
    private string name;
    private string address;
    private string type;

    public Store(string name, string address, string type)
    {
        this.name = name;
        this.address = address;
        this.type = type;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Address
    {
        get { return address; }
        set { address = value; }
    }

    public string Type
    {
        get { return type; }
        set { type = value; }
    }

    public void Greeting()
    {
        Console.WriteLine($"Welcome to {name} store!");
    }

    public void Farewell()
    {
        Console.WriteLine($"Thank you for shopping at {name} store! We hope to see you again!");
    }

    public void Sale(string item)
    {
        Console.WriteLine($"Sold item {item} at {name} store.");
    }

    public void Advertisement()
    {
        Console.WriteLine($"Visit our {type} store {name}, located at {address}!");
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                // Release managed resources
            }

            // Release unmanaged resources
            disposed = true;
        }
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    ~Store()
    {
        Console.WriteLine("Destructor called");
        Dispose(false);
    }
}
