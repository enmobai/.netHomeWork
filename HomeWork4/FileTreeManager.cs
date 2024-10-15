using System;
using System.IO;
using System.Windows.Forms;

namespace HomeWork4
{
    public class FileTreeManager
    {
        private TreeView _treeView;

        public FileTreeManager(TreeView treeView)
        {
            _treeView = treeView;
            _treeView.BeforeExpand += TreeView_BeforeExpand;
        }

        // 根节点
        public void LoadRootNode()
        {
            TreeNode rootNode = new TreeNode("C 盘");
            rootNode.Tag = "C:\\"; 
            rootNode.Nodes.Add(new TreeNode()); // 占位符
            _treeView.Nodes.Add(rootNode);
        }

        // 加载子目录
        private void TreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node = e.Node;
            if (node.Nodes[0].Text == "")
            {
                node.Nodes.Clear();
                string[] directories;
                try
                {
                    directories = Directory.GetDirectories((string)node.Tag);
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("访问被拒绝: " + node.Tag);
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("发生错误: " + ex.Message);
                    return;
                }

                foreach (string directory in directories)
                {
                    TreeNode dirNode = new TreeNode(Path.GetFileName(directory));
                    dirNode.Tag = directory;
                    dirNode.Nodes.Add(new TreeNode()); // 添加占位符
                    node.Nodes.Add(dirNode);
                }
            }
        }
    }
}
