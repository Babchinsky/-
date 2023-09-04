namespace _34_hw_23._03._2023_Adapter
{
    // Класс Client, который принимает ITarget в конструкторе
    public class Client
    {
        private readonly ITarget target;

        public Client(ITarget target)
        {
            this.target = target;
        }

        public void ClientDouble(double d)
        {
            target.ClientDouble(d);
        }

        public void ClientInt(int i)
        {
            target.ClientInt(i);
        }

        public void ClientChar(char c)
        {
            target.ClientChar(c);
        }
    }
}
