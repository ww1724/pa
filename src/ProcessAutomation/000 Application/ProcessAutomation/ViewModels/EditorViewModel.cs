using PA.Share;
using PA.Share.Mvvm;
using ReactiveUI;
using System.Collections.Generic;
using System;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Linq;
using Zoranof.WorkFlow;
using Zoranof.Workflow.Common;
using Zoranof.Workflow;
using PA.Share.Stores;
using Splat;

namespace PA.ViewModels
{
    public class EditorViewModel : ReactiveObject, IViewModel, IRoutableViewModel
    {
        public TestingStore TestingStore
            => Locator.Current.GetService<TestingStore>();

        private ObservableCollection<NodeItemMeta> nodeItemMetas;

        public string UrlPathSegment => Constants.EditorView;

        public IScreen HostScreen { get; }

        public ObservableCollection<NodeItemMeta> NodeItemMetas { get => nodeItemMetas; set => this.RaiseAndSetIfChanged(ref nodeItemMetas, value);  }

        public EditorViewModel()
        {
            var t = new ObservableCollection<NodeItemMeta>();
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            foreach (var assembly in assemblies)
            {
                var nodeTypes = assembly.GetTypes().Where(x => x.IsSubclassOf(typeof(WorkflowNode))).ToList();
                foreach (var x in nodeTypes)
                {
                    var attr = x.GetCustomAttribute<NodeAttribute>();
                    if (attr == null || attr.Group == "Template") continue;
                    var itemMeta = new NodeItemMeta();
                    itemMeta.Type = x;
                    itemMeta.Guid = x.GUID.ToString();
                    itemMeta.Title = attr != null ? attr.Title : x.Name;
                    itemMeta.Group = attr != null ? attr.Group : "Base";
                    itemMeta.Attrs = x.GetCustomAttributes(true).ToDictionary(x => x.GetType().Name, x => x);
                    t.Add(itemMeta);
                }
            }

            NodeItemMetas = new ObservableCollection<NodeItemMeta>(t);
        }
    }
}
