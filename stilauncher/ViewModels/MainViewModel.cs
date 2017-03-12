using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using stilauncher.Models;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

namespace stilauncher.ViewModels
{
    class MainViewModel : ViewModelBase
    {
        //private Platform platform;
        private ConfigViewModel _configViewModel;
        private SoftwareViewModel _softwareViewModel;

        public MainViewModel()
        {
            //this.platform = new Platform();
            this._configViewModel = new ConfigViewModel();
            this._softwareViewModel = new SoftwareViewModel();
        }

        public ConfigViewModel ConfigViewModel
        {
            get
            {
                return _configViewModel;
            }
        }

        public SoftwareViewModel SoftwareViewModel
        {
            get
            {
                return _softwareViewModel;
            }
        }

    }
}
