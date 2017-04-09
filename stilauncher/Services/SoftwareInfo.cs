using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace stilauncher.Services
{
    public interface ISoftwareInfo
    {
        List<DirectoryInfo> GetServerFolders(string path, string pattern = "*");
        List<FileInfo> GetServerFiles(string path, string pattern = "*");
    }

    public sealed class SoftwareInfo : ISoftwareInfo
    {
        List<DirectoryInfo> m_ServerFolders;
        List<FileInfo> m_ServerFiles;
        string m_strCurrentDirectory;

        public List<DirectoryInfo> GetServerFolders(string path, string pattern)
        {
            if (m_ServerFolders != null)
                return m_ServerFolders;

            DirectoryInfo rootDirInfo = new DirectoryInfo(path);
            try
            {
                m_ServerFolders = new List<DirectoryInfo>(rootDirInfo.EnumerateDirectories(pattern));
            }

            catch (DirectoryNotFoundException DirNotFound)
            {
                Console.WriteLine("{0}", DirNotFound.Message);
            }
            catch (UnauthorizedAccessException UnAuthDir)
            {
                Console.WriteLine("UnAuthDir: {0}", UnAuthDir.Message);
            }
            catch (PathTooLongException LongPath)
            {
                Console.WriteLine("{0}", LongPath.Message);
            }

            return m_ServerFolders;
        }

        public List<FileInfo> GetServerFiles(string path, string pattern)
        {
            if (m_ServerFiles != null && m_strCurrentDirectory == path)
                return m_ServerFiles;

            DirectoryInfo dirInfo = new DirectoryInfo(path);
            try
            {
                m_ServerFiles = new List<FileInfo>(dirInfo.EnumerateFiles(pattern));
            }

            catch (DirectoryNotFoundException DirNotFound)
            {
                Console.WriteLine("{0}", DirNotFound.Message);
            }
            catch (UnauthorizedAccessException UnAuthDir)
            {
                Console.WriteLine("UnAuthDir: {0}", UnAuthDir.Message);
            }
            catch (PathTooLongException LongPath)
            {
                Console.WriteLine("{0}", LongPath.Message);
            }

            m_strCurrentDirectory = path;
            return m_ServerFiles;
        }
    }
}
