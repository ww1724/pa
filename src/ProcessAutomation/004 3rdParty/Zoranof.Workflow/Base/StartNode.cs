using System.Windows.Media;
using Zoranof.WorkFlow;

namespace Zoranof.Workflow.Base
{
    [NodeAttribute(title:"StartNode", group:"workflow")]
    public class StartNode : NodeTemplate
    {
        public StartNode()
        {
            Width = 150;
            Height = 50;
        }

        public override void OnDrawFramework(DrawingContext drawingContext)
        {
            base.OnDrawFramework(drawingContext);


        }
    }
}
