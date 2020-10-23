using Shell32;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Linq;
using System.IO;

namespace WindowsTTF
{
    class TotalTimeFinder
    {
        public static string GetMediaDuration(string path, bool subdirectories)
        {

            double result;
            if (subdirectories)
            {
                result = GetDirectoryAndSubsMediaDurationInSecond(path);
            }
            else
            {
                result = GetDirectoryMediaDurationInSecond(path);
            }
            return TimeSpan.FromSeconds(result).ToString();
        }

        private static double GetDirectoryAndSubsMediaDurationInSecond(string path)
        {
            var subDirs = Directory.GetDirectories(path);
            double second = GetDirectoryMediaDurationInSecond(path);

            foreach (var subDir in subDirs)
                second += GetDirectoryAndSubsMediaDurationInSecond(subDir);

            return second;
        }

        private static double GetDirectoryMediaDurationInSecond(string path)
        {
            var shell = new Shell();
            var folder = shell.NameSpace(path);
            double result = 0;

            foreach (FolderItem2 item in folder.Items())
                if (item.Type.Contains("Video") || item.Type.Contains("Audio"))
                    result += (ulong)item.ExtendedProperty("System.Media.Duration") / 10_000_000;
                
            Marshal.ReleaseComObject(folder);
            Marshal.ReleaseComObject(shell);
            return result;
        }
    }
}
