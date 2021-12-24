using Doceo.Model;
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

        public EnterModel.user User { get; private set; }

        public MainDoceoWindow(Model.EnterModel.user User)
        {
            InitializeComponent();
            //this.Height = SystemParameters.PrimaryScreenHeight;
            //this.Width = SystemParameters.PrimaryScreenWidth;
            this.DataContext = vm;
            this.User = User;
        }

        private void GoToCourse(object sender, RoutedEventArgs e)
        {

            List<string> nameLessions = vm.GetLessions((string)((Button)sender).Content);
            StackPanel panelLessons = new StackPanel();
            for (int i = 0; i != nameLessions.Count; i++)
            {   
                Button button = new Button();
                button.Content = nameLessions[i];
                button.Name = $"lesson{i + 1}";
                button.Click += GoToLesson;
                button.Background = new SolidColorBrush(Color.FromRgb(255,204,0)); ;
                panelLessons.Children.Add(button);
            }

            MainFrame.Content = new PageForCours(panelLessons);
        }
        private void GoToOffice(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new MainUserOffice(User);
        }
        private void GoToLesson(object sender, RoutedEventArgs e)
        {
            int numbLesson = ((Button)sender).Name[6]-'0';
            byte[] LessionContent = vm.GetLessionContent(numbLesson);
            MainFrame.Content = new PageWithLesson(numbLesson,LessionContent, User);
        }
    }
}
