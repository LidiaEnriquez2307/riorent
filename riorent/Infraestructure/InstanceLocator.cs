﻿using System;
using System.Collections.Generic;
using System.Text;

namespace riorent.Infraestructure
{
    using ViewModels;

    
    public class InstanceLocator
    {
        #region
        public MainViewModel Main { get; set; }
        #endregion

        #region
        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
        #endregion

    }
}
