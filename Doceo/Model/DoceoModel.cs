using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
            private ICollection<Lesson> _Lessons;

            
            public Curse()
            {
                Lessons = new List<Lesson>();
            }
            public ICollection<Lesson> Lessons 
            {
                get { return _Lessons; }
                set { _Lessons = value; }
            }
            [Key]
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
            private int? _numberCurse;
            private Curse _Curse;

            [ForeignKey("Curse")]
            public int? numberCurse
            {
                get { return _numberCurse; }
                set { _numberCurse = value; }
            }
            public Curse Curse
            {
                get { return _Curse; }
                set { _Curse = value; }
            }

            [Key]
            public int number
            {
                get { return _number; }
                set { _number = value; }
            }

            public string name
            {
                get { return _name; }
                set { _name = value; }
            }
            
            public string text
            {
                get { return _text; }
                set { _text = value; }
            }
        }

    }
}
