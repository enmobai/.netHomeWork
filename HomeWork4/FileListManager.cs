using FileExplorer;
using System;
using System.IO;
using System.Windows.Forms;

namespace HomeWork4
{
    public class FileListManager
    {
        private ListView _listView;

        public FileListManager(ListView listView)
        {
            _listView = listView;
        }

        // 加载选中文件夹
        public void LoadFilesAndDirectories(string path)
        {
            _listView.Items.Clear();
            try
            {
                string[] directories = Directory.GetDirectories(path);
                string[] files = Directory.GetFiles(path);

                foreach (string directory in directories)
                {
                    ListViewItem item = new ListViewItem(Path.GetFileName(directory));
                    item.SubItems.Add("Folder");
                    item.Tag = directory;
                    _listView.Items.Add(item);
                }

                foreach (string file in files)
                {
                    ListViewItem item = new ListViewItem(Path.GetFileName(file));
                    item.SubItems.Add(Path.GetExtension(file));
                    item.Tag = file;
                    _listView.Items.Add(item);
                }
            }
            catch
            {
                MessageBox.Show("无法访问文件夹。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 打开选中的文件或文件夹
        public void OpenSelectedItem()
        {
            if (_listView.SelectedItems.Count > 0)
            {
                string selectedItemPath = (string)_listView.SelectedItems[0].Tag;
                if (File.Exists(selectedItemPath))
                {
                    FileOpener.OpenFile(selectedItemPath);
                }
            }
        }
    }
}
