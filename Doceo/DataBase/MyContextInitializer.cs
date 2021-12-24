using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doceo.DataBase
{
    class MyContextInitializer : DropCreateDatabaseIfModelChanges<DoceoContext>
    {
        protected override void Seed(DoceoContext db)
        {
            Model.EnterModel.user User = new Model.EnterModel.user { number = 1, login = "MazurB2777@yandex.ru", password = "111" };
            db.Users.Add(User);
            Model.DoceoModel.Curse curse = new Model.DoceoModel.Curse { numberCurse = 1, name = "C++" };
            db.Curses.Add(curse);
            Model.DoceoModel.Lesson lesson = new Model.DoceoModel.Lesson { number = 1, numberCurse = 1, name ="Введение в программирование", text = System.IO.File.ReadAllBytes("C:\\Users\\Bogdan\\source\\repos\\Doceo\\Doceo\\Resourses\\Lesson№1.txt") };
            db.Lessons.Add(lesson);
            Model.DoceoModel.Lesson lesson2 = new Model.DoceoModel.Lesson { number = 2 ,numberCurse = 1, name = "Введение в языки программирования C и С++", text = System.IO.File.ReadAllBytes("C:\\Users\\Bogdan\\source\\repos\\Doceo\\Doceo\\Resourses\\Lesson№2.txt") };
            db.Lessons.Add(lesson2);
            db.SaveChanges();
        }
    }
}
