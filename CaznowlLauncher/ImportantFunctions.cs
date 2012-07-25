using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Microsoft.Win32;

namespace CaznowlLauncher
{
    class ImportantFunctions
    {
        internal static string GetJavaPath()
        {
            string ret = GetJavaInstallationPath();
            if (ret == null)
            {
                ret = LocateJavaPath();
            }
            if (ret == null)
            {
                ret = LocateJavaFromPath();
            }
            if (ret == null)
            {
                ret = LocateJavaFromProgramFiles();
            }

            return Path.Combine(Path.Combine(ret, "bin"), "java.exe");
        }
        private static string GetJavaInstallationPath()
        {
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\JavaSoft\Java Runtime Environment"))
            {
                if (key != null)
                {
                    string name = key.GetValue("CurrentVersion").ToString();
                    using (RegistryKey key2 = key.OpenSubKey(name))
                    {
                        if (key2 != null)
                        {
                            return key2.GetValue("JavaHome").ToString();
                        }
                    }
                }
            }
            return null;
        }

        private static string LocateJavaFromPath()
        {
            string environmentVariable = Environment.GetEnvironmentVariable("PATH");
            if (environmentVariable != null)
            {
                foreach (string str2 in environmentVariable.Split(new char[] { ';' }))
                {
                    if (!str2.ToLowerInvariant().Contains("system32") && File.Exists(Path.Combine(str2, "java.exe")))
                    {
                        return str2;
                    }
                }
            }
            return null;
        }

        private static string LocateJavaFromProgramFiles()
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "Java");
            if (!Directory.Exists(path))
            {
                if (!path.Contains("(x86)"))
                {
                    return null;
                }
                path = path.Replace(" (x86)", "");
                if (!Directory.Exists(path))
                {
                    return null;
                }
            }
            List<string> list = new List<string>(Directory.GetDirectories(path));
            if (list.Count <= 0)
            {
                path = path.Replace("Program Files", "Program Files (x86)");
                if (!Directory.Exists(path))
                {
                    return null;
                }
                list.AddRange(Directory.GetDirectories(path));
            }
            list.Reverse();
            foreach (string str3 in list)
            {
                if (File.Exists(Path.Combine(Path.Combine(str3, "bin"), "java.exe")))
                {
                    return str3;
                }
            }
            return null;
        }

        private static string LocateJavaPath()
        {
            string environmentVariable = Environment.GetEnvironmentVariable("JAVA_HOME");
            if (environmentVariable != null)
            {
                foreach (string str2 in environmentVariable.Split(new char[] { ';' }))
                {
                    if (File.Exists(Path.Combine(Path.Combine(str2, "bin"), "java.exe")))
                    {
                        return str2;
                    }
                }
            }
            return null;
        }

    }
}
