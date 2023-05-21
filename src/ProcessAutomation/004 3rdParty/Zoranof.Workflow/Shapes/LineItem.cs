﻿using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using Zoranof.WorkFlow;

namespace Zoranof.Workflow.Shapes
{
    public class LineItem : WorkflowNode
    {

        private Point startPoint;

        public Point StartPoint
        {
            get { return startPoint; }
            set { startPoint = value; }
        }

        private Point endPoint = new Point(100, 100);

        public Point EndPoint
        {
            get { return endPoint; }
            set { endPoint = value; }
        }

        private Brush lineColor;

        public Brush LineColor
        {
            get { return lineColor; }
            set { lineColor = value; }
        }


        public LineItem(WorkflowNode parent = null) : base()
        {
            Width = 100;
            Height = 100;
            Pos = new Point(0, 0);

            ParentItem = parent;

            LineColor = Brushes.Red;
            BoundingRect = new Rect(Pos.X, Pos.Y, Width, Height);
            base.ApplyDefaultOptions();
        }


        #region Override
        public override void OnRender(DrawingContext drawingContext)
        {
            // 框架绘制
            if (IsSelected)
            {
                drawingContext.DrawRectangle(Brushes.Pink, new Pen(Brushes.Green, 2), BoundingRect);
            }
            //drawingContext.DrawRectangle(IsSelected ? Brushes.Aqua : Brushes.White, new Pen(LineColor, 2), BoundingRect);

            drawingContext.PushTransform(new TranslateTransform(Pos.X, Pos.Y));
            drawingContext.DrawLine(new Pen(lineColor, 2), StartPoint, EndPoint);
            drawingContext.Pop();
            base.OnRender(drawingContext);
        }

        #endregion


        //protected internal override void OnMouseEnter(MouseEventArgs args)
        //{

        //    lineColor = Brushes.Black;
        //    Update();
        //    base.OnMouseEnter(args);
        //}

        //protected internal override void OnMouseExit(MouseEventArgs args)
        //{


        //    lineColor = Brushes.Red;
        //    Update();
        //    base.OnMouseExit(args);
        //}
    }
}
