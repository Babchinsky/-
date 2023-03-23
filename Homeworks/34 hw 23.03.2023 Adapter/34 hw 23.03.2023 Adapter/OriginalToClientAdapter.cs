namespace _34_hw_23._03._2023_Adapter
{
    // Адаптер, реализующий интерфейс ITarget и адаптирующий класс Original
    class OriginalToClientAdapter : ITarget
    {
        private readonly Original original;

        public OriginalToClientAdapter(Original original)
        {
            this.original = original;
        }

        public void ClientDouble(double d)
        {
            original.OriginalDouble(d);
        }

        public void ClientInt(int i)
        {
            original.OriginalInt(i);
        }

        public void ClientChar(char c)
        {
            original.OriginalChar(c);
        }
    }
}
