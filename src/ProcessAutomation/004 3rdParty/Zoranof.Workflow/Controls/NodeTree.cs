using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Zoranof.Workflow.Controls
{
    public class NodeTree : ListView
    {
        static NodeTree()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(NodeTree), new FrameworkPropertyMetadata(typeof(NodeTree)));
        }

        private List<string> m_loadedAssemblyFiles { get; set; }


        // public slots
        public void LoadAssembly(string assemblyFile) {
            m_loadedAssemblyFiles.Add(assemblyFile);
        }
    }
}
