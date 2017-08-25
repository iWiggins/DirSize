using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DirSize
{
    public partial class Form1 : Form
    {
        class TreeSorter : System.Collections.IComparer
        {
            decimal ParseSize(string label)
            {
                int begin = label.IndexOf('[') + 1;
                int end = label.IndexOf(']');
                if (begin < 0 || end < 0) return 0;
                string sizeString = label.Substring(begin, end - begin);
                return Convert.ToDecimal(sizeString);
            }

            public int Compare(object x, object y)
            {
                string first = (x as TreeNode).Text;
                string second = (y as TreeNode).Text;

                decimal df = ParseSize(first);
                decimal ds = ParseSize(second);

                if (df > ds) return -1;
                else if (df < ds) return 1;
                else return 0;
            }
        }

        const decimal BYTES_PER_GB = 1000000000;
        string BytesToGBString(long bytes)
        {
            decimal bd = (decimal)bytes;
            bd /= BYTES_PER_GB;
            return bd.ToString();
        }

        Task analyzeTask;

        string Rootpath
        {
            get { return textBoxRoot.Text; }
            set { textBoxRoot.Text = value; }
        }

        void LockControls()
        {
            this.Invoke((Action)(() => {
                buttonBrowse.Enabled = false;
                buttonAnalyze.Enabled = false;
                treeViewMain.Enabled = false;
                treeViewMain.BeginUpdate();
            }));
        }

        void UnlockControls()
        {
            this.Invoke((Action)(() => {
                buttonBrowse.Enabled = true;
                buttonAnalyze.Enabled = true;
                treeViewMain.Enabled = true;
                treeViewMain.EndUpdate();
            }));
        }

        void SortTree()
        {
            this.Invoke((Action)(() => {
                treeViewMain.Sort();
            }));
        }

        Dirtree dirtree;

        public Form1()
        {
            InitializeComponent();
            buttonBrowse.Click += ButtonBrowse_Click;
            buttonAnalyze.Click += ButtonAnalyze_Click;

            treeViewMain.TreeViewNodeSorter = new TreeSorter();

            treeViewMain.Nodes.Add("\\UNASSIGNED");

            dirtree = new Dirtree(
                (o, n, b) => {
                    this.Invoke(
                        (Action)(() => {
                            (o as TreeNode).Text = "[" + BytesToGBString(b) + "]    "+n;
                        }));
                },
                o => {
                    TreeNode ret = null;
                    this.Invoke(
                        (Action)(() => {
                            ret = (o as TreeNode).Nodes.Add("\\UNASSIGNED");
                        }));
                    return ret;
                });
        }

        private void ButtonAnalyze_Click(object sender, EventArgs e)
        {
            var directory = new DirectoryInfo(Rootpath);
            var node = treeViewMain.Nodes[0];

            LockControls();
            analyzeTask = Task.Run(
                () => dirtree.Analyze(node, directory)).ContinueWith(
                    t => {
                        SortTree();
                        UnlockControls();

                    });

        }

        private void ButtonBrowse_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                Rootpath = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
