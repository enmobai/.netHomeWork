using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork4
{
    public partial class Form1 : Form
    {
        private FileTreeManager _fileTreeManager;
        private FileListManager _fileListManager;

        public Form1()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }


        private void InitializeCustomComponents()
        {
            _fileTreeManager = new FileTreeManager(treeView1);
            _fileListManager = new FileListManager(listView1);

            // 树形视图选择节点展开文件夹
            treeView1.AfterSelect += (s, e) =>
            {
                string selectedPath = (string)treeView1.SelectedNode.Tag;
                _fileListManager.LoadFilesAndDirectories(selectedPath);
            };

            // 双击文件事件
            listView1.ItemActivate += (s, e) =>
            {
                _fileListManager.OpenSelectedItem();
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _fileTreeManager.LoadRootNode();
        }
    }
}
