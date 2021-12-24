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
    
    public partial class PageWithTasks : Page
    {
        ViewModel.MainDoceoVM vm = new ViewModel.MainDoceoVM(); 
        public PageWithTasks(int numbLesson, Model.EnterModel.user User)
        {
            InitializeComponent();
            TextBlock t = new TextBlock
            {
                Text = "Теста на этот урок пока нету. Ждите обновлений ;) "
            };
            int numbQuestion = 0;
            List<string> AnswerQuestions = new List<string>();
            byte[] Content = vm.GetTaskContent(numbLesson);

            if (Content != null) 
            {
                String TaskLesson = Encoding.UTF8.GetString(Content);
                
                string[] Taskf = TaskLesson.Split('\r');
                numbQuestion = Taskf.Length;
                for (int i = 0; i != Taskf.Length; i++)
                {
                    if (Taskf[i][0] == '\\')
                    {
                        Taskf[i].Remove(0, 2);
                    }

                    var Question = Taskf[i].Split('~');
                    AnswerQuestions.Add(Question[2]);

                    TextBlock text = new TextBlock { Text = Question[0] };
                    MainTask.Children.Add(text);
                    TextBlock text2 = new TextBlock { Text = Question[1] };
                    MainTask.Children.Add(text2);
                    TextBox TB = new TextBox { Name = $"Question{i+1}" };
                    MainTask.Children.Add(TB);
                }

            }
            else MainTask.Children.Add(t);
        }
        private void EndMyTask(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
