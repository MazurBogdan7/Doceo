using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Doceo.Model
{
    public class EnterModel
    {
        [Table("Users")]
        public class user 
        {
            
            private int _number;
            private string _login;
            private string _password;
            
            public string login
            {
                get { return _login; }
                set { _login = value; }
            }
            public string password
            {
                get { return _password; }
                set { _password = value; }
            }
            [Key]
            public int number
            {
                get { return _number; }
                set { _number = value; }
            }
        }

        internal user CheckUser(string log, string password)
        {
            using (DataBase.DoceoContext db = new DataBase.DoceoContext())
            {
                IQueryable<user> check = db.Users.Where(p => p.login == log && p.password == password);
                List<user> U = check.Select(L => L).ToList();
                return U[0];
                

            }
        }
        
        internal void RegisterUs(string log, string password)
        {
            using (DataBase.DoceoContext db = new DataBase.DoceoContext())
            {
                
                user User = new user {login = log ,password = password};
                db.Users.Add(User);
                db.SaveChanges();
            }
        }
    }
}
