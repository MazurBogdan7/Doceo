using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
namespace Doceo.ViewModel
{
    class MainDoceoVM : PropertyChangedFactory
    {
        private string _messeg;
        public string messeg
        {
            get => _messeg;
            set
            {

                _messeg = value;
                OnPropertyChanged(nameof(messeg));
            }
        }

        private Model.DoceoModel Model = new Model.DoceoModel();

        public List<string> GetLessions(string nameCurse)
        {
            List<string> namesLessions = new List<string>();
            namesLessions = Model.GetLessonsFromDB(nameCurse);
            return namesLessions;
        }

        public byte[] GetLessionContent(int numbLession)
        {
            byte[] lession = Model.GetLessonsString(numbLession);

            return lession;
        }
        public byte[] GetTaskContent(int numbLession)
        {
            byte[] task = Model.GetTaskText(numbLession);

            return task;
        }
    }
}
