using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    // класс доступен из других сборок
    public class PublicState
    {
        internal void PrintInternal() => Console.WriteLine("internal");
        protected internal void PrintProtectedInternal() => Console.WriteLine("protected internal");
        public void PrintPublic() => Console.WriteLine("public");

    }

    // класс доступен только в текущей сборке - по умолчанию internal
    class DefaultlState { }
    // класс доступен только в текущей сборке
    internal class InternalState { }
}
