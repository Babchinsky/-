using System.Reflection;
using System.Windows.Forms;

namespace TicTacToe
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IModel model = new Model();
            IView view = new Form1();
            Presenter presenter = new Presenter(view, model);
            
            //ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}