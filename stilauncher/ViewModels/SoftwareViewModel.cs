using System.Collections.ObjectModel;
using stilauncher.Models;
using stilauncher.Services;
using System.Text.RegularExpressions;

namespace stilauncher.ViewModels
{
    class SoftwareViewModel : ViewModelBase
    {
        Software _software;
        SoftwareInfo _softwareInfo = new SoftwareInfo();

        public Software Software
        {
            set { _software = value; }
        }

        public ObservableCollection<string> ServerFolder
        {
            get { return new ObservableCollection<string>(_softwareInfo.GetIntegraServerFolder()); }
        }

        public string SoftwareVersion
        {
            get { return _software.Version; }
        }

        public bool IsBeta()
        {
            //Regex regex;
            return _software.Version.EndsWith("a");
        }
    }
}
