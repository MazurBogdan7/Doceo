using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doceo.Model
{
    class DoceoModel
    {
        public class Curse
        {
            private int _numberCurse;
            private string _name;
            public int numberCurse
            {
                get { return _numberCurse; }
                set { _numberCurse = value; }
            }
            public string name
            {
                get { return _name; }
                set { _name = value; }
            }
        }
        public class Lesson
        {
            private int _number;
            private string _name;
            private string _text;
            private int _numberCurse;
            public int numberCurse
            {
                get { return _numberCurse; }
                set { _numberCurse = value; }
            }
            public string name
            {
                get { return _name; }
                set { _name = value; }
            }
            public int number
            {
                get { return _number; }
                set { _number = value; }
            }
            public string text
            {
                get { return _text; }
                set { _text = value; }
            }
        }

    }
}
