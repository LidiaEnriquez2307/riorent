

namespace riorent.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Windows.Input;
    public class LoginViewModel
    {
        #region Properties
        public string Email
        {
            set;
            get;
        }
        public string Password
        {
            set;
            get;
        }
        public bool IsRunning
        {
            set;
            get;
        }
        public bool IsRemember
        {
            set;
            get;
        }

        #endregion
        #region Command
        public ICommand LoginCommand
        {
            get;
            set;

        }
        #endregion
        #region Constructors
        public LoginViewModel()
        {
            this.IsRemember = true;

        }
        #endregion
    }

}
