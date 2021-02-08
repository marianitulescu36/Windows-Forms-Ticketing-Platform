using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProiectPAW
{
    public partial class DragDrop : Form
    {
        public DragDrop()
        {
            InitializeComponent();
        }

        private void panel_DragDrop(object sender, DragEventArgs e)
        {
            string[] filePaths = e.Data.GetData(DataFormats.FileDrop, false) as string[];

            foreach(String path in filePaths)
            {
                string[] content = File.ReadAllLines(path);
                List<string> Servlist = new List<string>();
                List<string> Tiplist = new List<string>();

                TreeNode root = new TreeNode("Servicii");
                treeView.Nodes.Add(root);

                foreach(String line in content)
                {
                    string[] tokens = line.Split('\t');

                    Servlist.Add(tokens[0]);
                    Tiplist.Add(tokens[1]);

                }

                Servlist.Add(" ");
                Tiplist.Add(" ");

                for(int i=0; i<Servlist.Count-1;i++)
                {
                    TreeNode child = new TreeNode(Servlist[i]);
                    root.Nodes.Add(child);

                    TreeNode grandchild = new TreeNode(Tiplist[i]);
                    child.Nodes.Add(grandchild);

                    while(Servlist[i]== Servlist[i + 1])
                    {
                        TreeNode newgrandchild = new TreeNode(Tiplist[i+1]);
                        child.Nodes.Add(newgrandchild);
                        i++;
                    }
                }

                treeView.ExpandAll();
            }
        }

        private void panel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
    }
}
