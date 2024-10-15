using System;
using System.Diagnostics;
using System.IO;

namespace FileExplorer
{
    public static class FileOpener
    {
        // 根据文件类型执行打开操作
        public static void OpenFile(string filePath)
        {
            string extension = Path.GetExtension(filePath).ToLower();
            if (extension == ".exe")
            {
                Process.Start(filePath);
            }
            else if (extension == ".txt")
            {
                Process.Start("notepad.exe", filePath);
            }
        }
    }
}
