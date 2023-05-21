


using System.Windows.Media;
using Zoranof.WorkFlow;

namespace Zoranof.Workflow.Shapes
{
    public class RectangleItem : WorkflowNode
    {
        public RectangleItem()
        {
            Width = 150;
            Height = 50;
            LineColor = Brushes.Black;
        }

        public Brush LineColor { get; set; }

        public double LineWidth { get; set; }

        public override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);

            drawingContext.DrawRectangle(Background, new Pen(LineColor, LineWidth), new System.Windows.Rect(Pos.X, Pos.Y, Width, Height));
        }
    }
}
