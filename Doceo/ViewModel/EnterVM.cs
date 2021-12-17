using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Doceo.ViewModel
{
    public class EnterVM : PropertyChangedFactory
    {
        
        public Model.EnterModel Model = new Model.EnterModel();
        ProductionWindowFactory Opwind = new ProductionWindowFactory();
        public List<Model.EnterModel.user> User;
        public string login { get; set; }
        public string password { get; set; }
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

        public virtual void DoOpenMainDoceoWindow(List<Model.EnterModel.user> User)
        {
            IWindowFactory windowFactory = Opwind;
            windowFactory.openMainDoceoWindProgramm(User);

        }
        public virtual void DoOpenRegisterWindow()
        {
            IWindowFactory windowFactory = Opwind;
            windowFactory.openRegisterWindow();
        }
        
        public bool checkPusw(string chPasw)
        {
            bool check = true;
            if (chPasw.IndexOf(' ') >= 0) check = false;
            if (chPasw.IndexOf('-') >= 0) check = false;
            if (chPasw.IndexOf('.') >= 0) check = false;
            if (chPasw.IndexOf('#') >= 0) check = false;
            if (chPasw.IndexOf('@') >= 0) check = false;
            if (chPasw.IndexOf('&') >= 0) check = false;
            if (chPasw.IndexOf('*') >= 0) check = false;
            if (chPasw.IndexOf('^') >= 0) check = false;
            return check;
        }
        public bool checklogin(string chMail)
        {
            string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
            if (Regex.IsMatch(chMail, pattern, RegexOptions.IgnoreCase))
            {

                return true;
            }
            else
            {
                return false;
            }


        }
        public void EnterUser(object parametr)
        {
            
            bool rez = false;
            if (login != "" && password != null)
            {
                rez = Model.CheckUser(login, password);
            }

            if (rez)
            {

                DoOpenMainDoceoWindow(User);
               
            }
            else
            {
                messeg = "Неверный логин или пароль." + Environment.NewLine +
                    "Логин должен быть вввиде почты, а пароль не должен содержать спец символы"+ Environment.NewLine +
                    "либо попробуйте зарегестрироваться";
            }

        }
        private ICommand _EntrUs;
        public ICommand EntrUs => _EntrUs ?? (_EntrUs = new RelayCommand(EnterUser));

        public void RegisterUs(object parametr)
        {
            bool rez = false;
            if (login != "" && password != null)
            {
                rez = Model.CheckUser(login, password);
            }

            if (rez)
            {

                messeg = "Вы уже зарегестрированны";

            }
            else
            {
                DoOpenRegisterWindow();
            }

        }
        private ICommand _RegisterUs;
        public ICommand Register => _RegisterUs ?? (_RegisterUs = new RelayCommand(RegisterUs));
    }
}
