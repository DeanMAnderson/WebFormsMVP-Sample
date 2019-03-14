using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormsMVC.Models;
using WebFormsMVC.Presenter;
using WebFormsMVC.View;
using WebFormsMvp;

namespace WebFormsMVC
{
    [PresenterBinding(typeof(PersonPresenter))]
    public partial class Form : WebFormsMvp.Web.MvpPage<Models.PersonManagementModel>, IPersonManagementModelArgumentsView
    {
        private event EventHandler<View.PersonManagementModelArguments> updateModel;
        event EventHandler<View.PersonManagementModelArguments> IPersonManagementModelArgumentsView.UpdateModel
        {
            add
            {
                updateModel += value;
            }

            remove
            {
                updateModel -= value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void View_UpdateModel(object sender, EventArgs e)
        {
            if (updateModel == null) return;
            updateModel(this, new View.PersonManagementModelArguments());
        }
    }
}