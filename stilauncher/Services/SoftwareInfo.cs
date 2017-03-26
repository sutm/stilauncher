using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace stilauncher.Services
{
    public class SoftwareInfo
    {
        List<string> m_IntegraServerFolder;
        List<string> m_OTFServerFolder;

        public List<string> GetIntegraServerFolder()
        {
            if (m_IntegraServerFolder == null)
            {
                m_IntegraServerFolder = new List<string>(Directory.EnumerateDirectories(@"C:\Users\sutm\Projects")); // TODO: configurable
            }
            return m_IntegraServerFolder;
        }

        public List<string> GetOTFServerFolder()
        {
            if (m_OTFServerFolder == null)
            {
                m_OTFServerFolder = new List<string>(Directory.EnumerateDirectories(@"C:\Users\sutm\Projects"));
            }
            return m_OTFServerFolder;
        }
    }
}
