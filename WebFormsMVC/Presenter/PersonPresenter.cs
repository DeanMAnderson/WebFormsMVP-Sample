using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using WebFormsMVC.Models;
using WebFormsMVC.View;
using WebFormsMvp;

namespace WebFormsMVC.Presenter
{
    public class PersonPresenter : Presenter<IPersonManagementModelArgumentsView>
    {
        private readonly IPersonRepository personRepository;
        public PersonPresenter(IPersonManagementModelArgumentsView view, IPersonRepository carRepository) : base(view)
        {
            personRepository = carRepository;
            View.Load += View_Load;
            View.UpdateModel += View_UpdateModel;
        }
        public override void ReleaseView()
        {
            View.Load -= View_Load;
            View.UpdateModel -= View_UpdateModel;
        }
        void View_Load(object sender, EventArgs e)
        {            
            View.Model.PageHeading = "WebForms MVP Test";
            View.Model.PersonList = personRepository.GetPeople();
        }

        private void View_UpdateModel(object sender, View.PersonManagementModelArguments e)
        {
            //Modify model
        }
    }
}