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

        public ObservableCollection<Software> SoftwareVersions
        {
            get
            {
                var softwareList = new ObservableCollection<Software>();
                softwareList.Add(new Software { Name = "Integra", Version = "10.08.01.00", BuildTime = System.DateTime.Parse("20 Sep 2014"), Protocol = "3.06" });
                softwareList.Add(new Software { Name = "OTF3D", Version = "11.06.01.00", BuildTime = System.DateTime.Parse("20 Sep 2014"), Protocol = "3.06" });
                return softwareList;
            }
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
