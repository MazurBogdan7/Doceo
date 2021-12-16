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
    public partial class MainDoceoWindow : Window
    {
        ViewModel.MainDoceoVM vm = new ViewModel.MainDoceoVM();
        public MainDoceoWindow(List<Model.EnterModel.user> User)
        {
            InitializeComponent();
            this.DataContext = vm;
        }

        private void GoToCourse(object sender, RoutedEventArgs e)
        {
            List<string> nameLessions = vm.GetLessions();
            StackPanel panelLessons = new StackPanel();
            for (int i = 0; i != 5; i++)
            {
                Button button = new Button();
                button.Content = nameLessions[i];
                panelLessons.Children.Add(button);
            }

            MainFrame.Content = new PageForCours(panelLessons);
        }
    }
}
