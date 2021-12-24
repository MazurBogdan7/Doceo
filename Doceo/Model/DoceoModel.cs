using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doceo.Model
{
    public class DoceoModel
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
            private byte[] _text;
            private int? _numberCurse;
            private Curse _Curse;
            private ICollection<Tasks> _Tasks;

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
            public int numberLesson
            {
                get { return _number; }
                set { _number = value; }
            }

            public string name
            {
                get { return _name; }
                set { _name = value; }
            }
            
            public byte[] text
            {
                get { return _text; }
                set { _text = value; }
            }
            public Lesson()
            {
                Task = new List<Tasks>();
            }
            public ICollection<Tasks> Task
            {
                get { return _Tasks; }
                set { _Tasks = value; }
            }
        }
        public class Tasks
        {
            private int _number;
            private string _name;
            private byte[] _text;
            private int _numberLesson;
            private Lesson _Lesson;

            [ForeignKey("Lesson")]
            public int numberLesson
            {
                get { return _numberLesson; }
                set { _numberLesson = value; }
            }
            public Lesson Lesson
            {
                get { return _Lesson; }
                set { _Lesson = value; }

            }
            public string name
            {
                get { return _name; }
                set { _name = value; }
            }

            public byte[] text
            {
                get { return _text; }
                set { _text = value; }
            }

            [Key]
            public int numberTask
            {
                get { return _number; }
                set { _number = value; }
            }
            public ICollection<EnterModel.user> Users { get; set; }
            public Tasks()
            {
                Users = new List<EnterModel.user>();
            }

        }
       
        public List<string> GetLessonsFromDB(string nameCurse)
        {
            using (DataBase.DoceoContext db = new DataBase.DoceoContext())
            {
                List<string> LessonsName = db.Lessons.Where(L => L.Curse.name == nameCurse).Select(L => L.name).ToList();

                return LessonsName;
            }
        }
        public byte[] GetLessonsString(int numberLesson)
        {
            using (DataBase.DoceoContext db = new DataBase.DoceoContext())
            {
                var LessonText = db.Lessons.Where(L => L.numberLesson == numberLesson).Select(L => L.text).ToList();

                return LessonText.Count != 0 ? LessonText[0] : null;
            }
        }
       public byte[] GetTaskText(int numbLession)
        {
            using (DataBase.DoceoContext db = new DataBase.DoceoContext())
            {
                var TaskText = db.Tasks.Where(L => L.numberLesson == numbLession).Select(L => L.text).ToList();

                return TaskText.Count != 0 ? TaskText[0] : null;
            }
        }


    }
}
