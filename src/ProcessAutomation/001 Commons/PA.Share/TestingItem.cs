namespace PA.Share
{
    public class TestingItem
    {
        public int Id { get;set; }

        public string Title { get; set; }

        public string NodesString { get; set; }

        public string ExecJson { get; set; }

        public Dictionary<string, TestingParameterItem> Parameters { get; set; }

        public Type NodeType { get; set; }
    }
}
