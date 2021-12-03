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
using System.Windows.Shapes;

namespace Doceo.View
{
    
    public partial class Register : Window
    {
        ViewModel.RegisterVM vm = new ViewModel.RegisterVM();
        public Register()
        {
            InitializeComponent();
            DataContext = vm;
        }
        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            vm.password = pasw.Password;
        }
    }
}
