using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebFormsMVC.Models;
using WebFormsMVC.View;
using WebFormsMvp;
using WebFormsMvp.Binder;

namespace WebFormsMVC.Presenter
{
    public class PresenterFactory : IPresenterFactory
    {
        public IPresenter Create(Type presenterType, Type viewType, IView viewInstance)
        {
            if(presenterType == typeof(PersonPresenter))
            {
                return new PersonPresenter((IPersonManagementModelArgumentsView)viewInstance, new PersonRepository());
            }

            //IoC containers
            //Unity
            //Ninject
            return null;
        }

        public void Release(IPresenter presenter)
        {
        }
    }
}