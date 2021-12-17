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
            Model.EnterModel.user User = new Model.EnterModel.user { number = 1, login = "Bog", password = "1234" };
            db.Users.Add(User);
            db.SaveChanges();
        }
    }
}
