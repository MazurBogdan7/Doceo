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
        



    }
    public class ProductionWindowFactory : IWindowFactory
    {

        public void openMainDoceoWindProgramm(List<Model.EnterModel.user> User)
        {
           // MainWindProgramm window = new MainWindProgramm(login);
            Application.Current.MainWindow.Close();
           // window.Show();
        }
       


    }
}
