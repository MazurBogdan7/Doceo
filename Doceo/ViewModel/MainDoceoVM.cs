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
        Model.DoceoModel Model = new Model.DoceoModel();
        public List<string> GetLessions(string nameCurse)
        {
            List<string> namesLessions = new List<string>();
            namesLessions = Model.GetLessonsFromDB(nameCurse);
            return namesLessions;
        }

        public string GetLessionContent(int numbLession)
        {
            string lession = Model.GetLessonsString(numbLession);

            return lession;
        }
    }
}
