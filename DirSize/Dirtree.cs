using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DirSize
{
    class Dirtree
    {
        public delegate void NodeSet(object node, string name, long bytes);
        public delegate object NodeAdvance(object node);

        private NodeSet nodeSet;
        private NodeAdvance nodeAdvance;

        public Dirtree(
            NodeSet nodeSet,
            NodeAdvance nodeAdvance)
        {
            this.nodeSet = nodeSet;
            this.nodeAdvance = nodeAdvance;
        }

        private long AnalyzeRecurse(object node,DirectoryInfo dir)
        {
            try
            {
                long size = 0;
                foreach (var file in dir.EnumerateFiles())
                {
                    size += file.Length;
                }

                foreach (var directory in dir.EnumerateDirectories())
                {
                    var child = nodeAdvance(node);
                    size += AnalyzeRecurse(child, directory);
                }

                nodeSet(node, dir.Name, size);

                return size;
            }
            catch(UnauthorizedAccessException)
            {
                return 0;
            }
        }

        public void Analyze(object rootNode,DirectoryInfo directory)
        {
            AnalyzeRecurse(rootNode, directory);
        }
    }
}
