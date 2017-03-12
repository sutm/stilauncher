using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using stilauncher.Models;

namespace stilauncher.ViewModels
{
    class ConfigViewModel : ViewModelBase
    {
        private ObservableCollection<Config> _configList = new ObservableCollection<Config>();
        public ObservableCollection<Config> ConfigList 
        {
            get { return _configList; }
            set { _configList = value; NotifyPropertyChanged("_configList"); }
        }

        public ConfigViewModel()
        {
            _configList = new ObservableCollection<Config>()
            {
                new Config(){ Name="Hexa", IntegraFolder="d:\\Integra_hexa", OTFFolder="d:\\OTF_x64" },
                new Config(){ Name="ISort", IntegraFolder="d:\\Integra_isort", OTFFolder="" }
            };
        }
    }
}
