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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Doceo.View
{
    public partial class PageWithLesson : Page
    {
        
        public PageWithLesson(int numbLesson, byte[] LessionContent, Model.EnterModel.user User)
        {
            this.User = User;
            this.numbLesson = numbLesson;
            InitializeComponent();

            //TextLesson.Text = LessionContent;

            TextLessons.Text = Encoding.UTF8.GetString(LessionContent); 
            
        }

        public EnterModel.user User { get; private set; }
        public int numbLesson { get; private set; }

        private void GoToTasks(object sender, RoutedEventArgs e)
        {
            
            PageWithTasks page = new PageWithTasks(numbLesson, User);
            NavigationService.Navigate(page) ;

            
        }
    }
}
