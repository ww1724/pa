using Zoranof.WorkFlow;

namespace Zoranof.Workflow.Common
{
    #region Enums
    public enum ExecOptionType
    {
        From, To, Input, Oupput
    }

    public enum Alignment
    {
        AlignLeft, AlignRight, AlignHCenter, AlignJustify, AlignTop, AlignBottom, AlignVCenter, AlignBaseline
    }

    public enum OptionLocation
    {
        Left, Top, Right, Bottom
    }


    public enum ItemSelectionMode
    {
        ContainsItemShape, IntersectsItemShape, ContainsItemBoundingRect, IntersectsItemBoundingRect,
    }
    #endregion


    public class WorkflowEventArgs : EventArgs
    {
        private WorkflowNode item;

        public WorkflowNode Item
        {
            get { return item; }
            set { item = value; }
        }

        public WorkflowEventArgs(WorkflowNode item) { Item = item; }
    }

}
