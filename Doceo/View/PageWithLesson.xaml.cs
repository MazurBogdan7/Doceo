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
        public PageWithLesson(string LessionContent)
        {
            InitializeComponent();
            TextLesson.Text = LessionContent;
        }
    }
}
