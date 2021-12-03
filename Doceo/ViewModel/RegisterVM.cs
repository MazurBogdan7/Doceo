using Doceo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doceo.ViewModel
{
    public class RegisterVM :EnterVM
    {
        public override void DoOpenMainDoceoWindow(List<EnterModel.user> User)
        {
            base.DoOpenMainDoceoWindow(User);
        }
    }
}
