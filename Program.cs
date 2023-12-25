using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_FISU
{
    static class Program
    {
        /// Главная точка входа для приложения.
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles(); //Создание визуального стиля приложения
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AccountChooseWindow()); //запуск приложения и обработка сообщений
        }
    }
}
