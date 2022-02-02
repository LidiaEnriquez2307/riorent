using System;
using System.Collections.Generic;
using System.Text;

namespace riorent.ViewModels
{
   public class MainViewModel
    {
        #region

        public LoginViewModel Login
        {
            get;
            set;

        }

        #endregion

        #region
        public MainViewModel()
        {
            this.Login = new LoginViewModel();
        }
        #endregion
    }
}
