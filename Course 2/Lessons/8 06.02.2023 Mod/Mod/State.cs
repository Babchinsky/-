using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod
{
   //Так как класс State не имеет явного модификатора, по умолчанию он имеет модификатор internal, поэтому он будет доступен из любого места данного проекта, однако не будет доступен из других программ и сборок.

    class State
    {
        // все равно, что private string defaultVar;
        string defaultVar = "default";
        // поле доступно только из текущего класса
        private string privateVar = "private";
        // доступно из текущего класса и производных классов, которые определены в этом же проекте
        protected private string protectedPrivateVar = "protected private";
        // доступно из текущего класса и производных классов
        protected string protectedVar = "protected";
        // доступно в любом месте текущего проекта
        internal string internalVar = "internal";
        // доступно в любом месте текущего проекта и из классов-наследников в других проектах
        protected internal string protectedInternalVar = "protected internal";
        // доступно в любом месте программы, а также для других программ и сборок
        public string publicVar = "public";

        // по умолчанию имеет модификатор private
        void Print() => Console.WriteLine(defaultVar);

        // метод доступен только из текущего класса
        private void PrintPrivate() => Console.WriteLine(privateVar);

        // доступен из текущего класса и производных классов, которые определены в этом же проекте
        protected private void PrintProtectedPrivate() => Console.WriteLine(protectedPrivateVar);

        // доступен из текущего класса и производных классов
        protected void PrintProtected() => Console.WriteLine(protectedVar);

        // доступен в любом месте текущего проекта
        internal void PrintInternal() => Console.WriteLine(internalVar);

        // доступен в любом месте текущего проекта и из классов-наследников в других проектах
        protected internal void PrintProtectedInternal() => Console.WriteLine(protectedInternalVar);

        // доступен в любом месте программы, а также для других программ и сборок
        public void PrintPublic() => Console.WriteLine(publicVar);
    }
}
