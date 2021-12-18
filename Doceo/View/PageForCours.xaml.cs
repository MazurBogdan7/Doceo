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
    /// Логика взаимодействия для PageForCours.xaml
    /// </summary>
    public partial class PageForCours : Page
    {
        ViewModel.PagesVM vm = new ViewModel.PagesVM();
        public PageForCours(StackPanel sp)
        {
            InitializeComponent();
            this.DataContext = vm;
            List<Button> buttonsLessons = new List<Button>();
            for (int i = 0; i < sp.Children.Count; i++) {
                Button button = (Button)sp.Children[i];
                buttonsLessons.Add(button);
            }
            sp.Children.Clear();
            for (int i = 0; i < buttonsLessons.Count; i++)
            {
                Lessons.Children.Add(buttonsLessons[i]);
            }
        }
    }
}
