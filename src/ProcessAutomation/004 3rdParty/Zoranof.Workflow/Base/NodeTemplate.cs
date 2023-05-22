using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Effects;
using Zoranof.WorkFlow;

namespace Zoranof.Workflow.Base
{
    public class NodeTemplate : WorkflowNode
    {
        public NodeTemplate() : base(false)
        {
            Pos = new Point(0, 0);
            BoundingRect = new Rect(Pos.X, Pos.Y, Width, Height);
        }

        [Obsolete]
        public override void OnDrawFramework(DrawingContext drawingContext)
        {
            base.OnDrawFramework(drawingContext);
            Brush bg = (IsSelected || IsActive) ? Brushes.White : Brushes.White;
            Pen borderPen = (IsSelected || IsActive) ?
                new Pen(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#4153FE")), 2)
                : new Pen(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#999")), 2);
            DropShadowBitmapEffect shadow = new DropShadowBitmapEffect();
            if (IsSelected || IsActive)
            {
                shadow = new DropShadowBitmapEffect() { Noise = 1, ShadowDepth = -4, Color = Colors.Black, Opacity = 0.2 };
            }
            drawingContext.PushEffect(shadow, null);
            drawingContext.DrawRoundedRectangle(bg, borderPen, SelfRect, 10, 10);
            drawingContext.Pop();
        }


        public override void OnDrawTitle(DrawingContext drawingContext)
        {
            for (int i = 0; i < 6; i++)
            {
                drawingContext.DrawEllipse(
                    new SolidColorBrush((Color)ColorConverter.ConvertFromString("#c2c2c2")),
                    new Pen(Brushes.Transparent, 0),
                    new Point((20 + (i % 2) * 10), ((i / 2) - 1) * 10 + Height / 2) , 2, 2);
            }
            FormattedText ft = new FormattedText(Title ?? "默认节点", CultureInfo.CurrentCulture,
                FlowDirection.LeftToRight,
                new Typeface("LXGW WenKai"),
                16,
                Brushes.Black, 100);
            drawingContext.DrawText(ft, new Point(50, 20));
        }
    }
}
