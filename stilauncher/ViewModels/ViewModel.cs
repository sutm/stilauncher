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
    class ViewModel : ViewModelBase
    {
        private Platform platform;
        private ConfigViewModel configViewModel;

        public ViewModel()
        {
            this.platform = new Platform();
            this.configViewModel = new ConfigViewModel();
        }

        public ObservableCollection<Config> ConfigList
        {
            get
            {
                return configViewModel.ConfigList;
            }
        }

        public ObservableCollection<Software> SoftwareVersions
        {
            get {
                var softwareList = new ObservableCollection<Software>();
                softwareList.Add(new Software { Name = "Integra", Version = "10.08.01.00", BuildTime = DateTime.Parse("20 Sep 2014"), Protocol = "3.06"});
                softwareList.Add(new Software { Name = "OTF3D", Version = "11.06.01.00", BuildTime = DateTime.Parse("20 Sep 2014"), Protocol = "3.06" });
                return softwareList;
            }
        }
    }
}
