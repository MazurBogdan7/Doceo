using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace Doceo.DataBase
{
    class DoceoContext:DbContext
    {
        static DoceoContext()
        {
            Database.SetInitializer(new MyContextInitializer());
        }
        public DoceoContext()
            :base("DBConnection")
        { }
        public DbSet<Model.EnterModel.user> Users { get; set; }
        public DbSet<Model.DoceoModel.Curse> Curses { get; set; }
        public DbSet<Model.DoceoModel.Lesson> Lessons { get; set; }
    }
}
