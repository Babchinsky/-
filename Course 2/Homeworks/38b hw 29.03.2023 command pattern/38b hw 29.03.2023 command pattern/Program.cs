using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    /*
	*  Паттерн Команда обеспечивает обработку команды в виде объекта, что позволяет сохранять её,
	* передавать в качестве параметра методам,
	*  а также возвращать её в виде результата, как и любой другой объект.
	   Удобство заключается в том, что вызывающему коду не нужно ничего знать о самой команде,
	* мы просто передаём её в параметрах.
	*  Такую команду даже можно передавать из одного процесса в другой.
	* Можно ставить разные команды в очередь выполнения.
	*  Часто паттерн Команда применяется для организации работы пользовательского меню,
	* а в качестве конкретных команд выступают такие команды, как Copy, Paste, Undo, Redo
	*/

namespace _38b_hw_29._03._2023_command_pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TV tv = new TV(); // Receiver – конечный получатель команды
            ICommand command = new TVOnCommand(tv); // конкретная команда
            Invoker(command, true);

            Microwave microwave = new Microwave(); // Receiver – конечный получатель команды
            command = new MicrovaweCommand(microwave, 5000); // конкретная команда
            Invoker(command, false);
        }

        // Invoker – это инициатор выполнения команды
        static void Invoker(ICommand command, bool Undo)
        {
            Controller controller = new Controller();
            controller.SetCommand(command);
            controller.PresButton();

            if (Undo)
                controller.PressUndo();
            /*
	        * Таким образом, инициатор, отправляющий запрос, ничего не знает о получателе,
	        * который и будет выполнять команду.
	        * Кроме того, если нам потребуется применить какие-то новые команды,
	        * мы можем просто унаследовать классы от абстрактного класса ICommand и
	        * реализовать его методы Execute и Undo.
	        */
        }
    }
}
