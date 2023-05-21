using PA.Common.Mvvm;
using ReactiveUI;

namespace PA.Common.Stores
{
    public class TestingStore : ReactiveObject, IViewModel
    {
        private Dictionary<string, string> codeMaps;
        private string workflowCode;
        private string flowChartCode;

        public TestingStore() { }

        public string CurrentTestingCode { get; set; }

        public Dictionary<string, string> OpeningCodeMaps { get => codeMaps; set => this.RaiseAndSetIfChanged(ref codeMaps, value); }

        public string WorkflowCode { get => workflowCode; set => workflowCode = value; }

        public string FlowChartCode { get => flowChartCode; set => flowChartCode = value; }

        #region Actions
        public void InitAssembly()
        {

        }

        public void LoadTestingCode()
        {

        }

        public void SwitchTestingCode(string id)
        {
            CurrentTestingCode = OpeningCodeMaps[id];
        }
        #endregion

    }
}
