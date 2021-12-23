using Doceo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Doceo.ViewModel
{
    public class RegisterVM :EnterVM
    {
        public override void DoOpenMainDoceoWindow(EnterModel.user User)
        {
            base.DoOpenMainDoceoWindow(User);
        }
        public Model.EnterModel model = new Model.EnterModel();
        public void Registered(object parametr)
        {
            
            if (login != "" && password != null)
            {
                User = model.CheckUser(login, password);
            }

            if (User != null)
            {

                DoOpenMainDoceoWindow(User);

            }
            else
            {
                if (checkPusw(password) && checklogin(login))
                {
                    Model.RegisterUs(login,password);
                    DoOpenMainDoceoWindow(User);
                }
                else messeg = "Данные введены не коректно";
            }

        }
        private ICommand _RegisterUser;
        public ICommand RegisterUser => _RegisterUser ?? (_RegisterUser = new RelayCommand(Registered));
    }
}
