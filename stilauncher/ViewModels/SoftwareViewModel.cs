using System.IO;
using System.Collections.ObjectModel;
using stilauncher.Models;
using stilauncher.Services;
using System.Text.RegularExpressions;

namespace stilauncher.ViewModels
{
    class SoftwareViewModel : ViewModelBase
    {
        public string Rootpath { set; get; }
        public Software Software { set; private get; }
        public ISoftwareInfo Service { set; private get; }
        
        public ObservableCollection<DirectoryInfo> ServerFolders
        {
            get { return new ObservableCollection<DirectoryInfo>(Service.GetServerFolders(Rootpath)); }
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
            get { return Software.Version; }
        }

        public bool IsBeta()
        {
            //Regex regex;
            return Software.Version.EndsWith("a");
        }
    }
}
