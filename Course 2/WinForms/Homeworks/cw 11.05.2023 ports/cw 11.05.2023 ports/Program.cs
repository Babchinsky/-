using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cw_11._05._2023_ports
{
    static class Program
    {
        static Mutex mutex = new Mutex(true, "{UniqueIdentifier}");

        [STAThread]
        static void Main()
        {
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                // Создаем сигнал для взаимодействия между экземплярами приложения
                EventWaitHandle eventWaitHandle = new EventWaitHandle(false, EventResetMode.AutoReset, "4E8CA89C-66FC-438D-B9B1-800F2F723B80");

                // Обработка события сигнала
                ThreadPool.RegisterWaitForSingleObject(eventWaitHandle, OnSignalReceived, null, Timeout.Infinite, false);

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmSettings());

                // Освобождаем ресурсы после закрытия главной формы
                eventWaitHandle.Close();
                mutex.ReleaseMutex();
            }
            else
            {
                // Отправляем сигнал другому экземпляру приложения
                EventWaitHandle eventWaitHandle = EventWaitHandle.OpenExisting("4E8CA89C-66FC-438D-B9B1-800F2F723B80");
                eventWaitHandle.Set();
            }
        }

        static void OnSignalReceived(object state, bool timedOut)
        {
            // Здесь можно выполнить нужные действия при получении сигнала
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmSettings());
        }
    }
}
