using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Doceo.View
{
    /// <summary>
    /// Логика взаимодействия для PageWithTasks.xaml
    /// </summary>
    public partial class PageWithTasks : Page
    {
        ViewModel.MainDoceoVM vm = new ViewModel.MainDoceoVM(); 
        public PageWithTasks(int numbLesson, Model.EnterModel.user User)
        {
            InitializeComponent();
            byte[] Content = vm.GetTaskContent(numbLesson);
            Task.Text = Encoding.UTF8.GetString(Content); 
        }
    }
}
