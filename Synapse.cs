namespace NodeNet
{
    public class Synapse
    {
        public double Weight { get; set; }

        public Node InputNode { get; set; }
        public Node OutputNode { get; set; }

        public Synapse(Node inputNode, Node outputNode)
        {
            InputNode = inputNode;
            OutputNode = outputNode;
            Weight = Node.GetRandom();
        }
    }
}
