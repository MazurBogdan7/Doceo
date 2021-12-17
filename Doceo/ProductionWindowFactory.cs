using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Doceo
{
    public interface IWindowFactory
    {
        void openMainDoceoWindProgramm(List<Model.EnterModel.user> User);
        void openRegisterWindow();

    }
    public class ProductionWindowFactory : IWindowFactory
    {

        public void openMainDoceoWindProgramm(List<Model.EnterModel.user> User)
        {
           View.MainDoceoWindow window = new View.MainDoceoWindow(User);
           Application.Current.MainWindow.Close();
           window.Show();
        }
        public void openRegisterWindow()
        {
            View.Register window = new View.Register();
            Application.Current.MainWindow.Close();
            window.Show();
        }


    }
}
