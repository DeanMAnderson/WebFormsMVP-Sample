using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFormsMVC.Models;
using WebFormsMvp;

namespace WebFormsMVC.View
{
    public interface IPersonManagementModelArgumentsView : IView<PersonManagementModel>
    {
        event EventHandler<PersonManagementModelArguments> UpdateModel;
    }
}
