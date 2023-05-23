using PA.Share;
using PA.Share.Mvvm;
using ReactiveUI;
using System.Collections.Generic;
using System;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Linq;
using Zoranof.WorkFlow;

namespace PA.ViewModels
{
    public class EditorViewModel : ReactiveObject, IViewModel, IRoutableViewModel
    {
        private ObservableCollection<NodeItemMeta> nodeItemMetas;

        public class NodeItemMeta
        {
            public string Title { get; set; }

            public string Guid { get; set; }

            public Dictionary<string, object> Attrs { get; set; }

            public Type Type { get; set; }

        }

        public string UrlPathSegment => Constants.EditorView;

        public IScreen HostScreen { get; }

        public ObservableCollection<NodeItemMeta> NodeItemMetas { get => nodeItemMetas; set => this.RaiseAndSetIfChanged(ref nodeItemMetas, value);  }

        public EditorViewModel()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var types = assembly.GetTypes();
            var nodeTypes = types.Where(x => x.IsSubclassOf(typeof(WorkflowNode))).ToList();
            var t = new ObservableCollection<NodeItemMeta>();
            foreach (var x in nodeTypes)
            {
                t.Add(
                    new NodeItemMeta
                    {
                        Title = x.Name,
                        Guid = x.GUID.ToString(),
                        Attrs = x.GetCustomAttributes(true).ToDictionary(x => x.GetType().Name, x => x),
                        Type = x
                    });
            }
            NodeItemMetas = new ObservableCollection<NodeItemMeta>(t);
        }
    }
}
