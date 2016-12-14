using System;
using System.Collections.Generic;


namespace NodeNet
{
    public class Node
    {
        //public Action<Node, int> OutputListener;
        private static readonly Random Random = new Random();

        public double Value { get; set; }

        public List<Synapse> Synapses { get; set; }

        public Node()
        {
            Synapses = new List<Synapse>();
        }

        public Node(IEnumerable<Node> inputNodes) : this()

        {
            foreach (var node in inputNodes)
            {
                var synapse = new Synapse(node, this);
                Synapses.Add(synapse);
            }
        }

        public void CalcValue()
        {
            //calc new value based on inputs

            //Value = Synapses.Sum(s => s.InputNode.Value / 2 + s.Value / 2) / Synapses.Count;
            double v = 0.0;
            foreach (var synapse in Synapses)
            {
                double w = synapse.InputNode.Value * synapse.Weight;
                v += w;

            }
            Value = v / Synapses.Count;

        }

        public void Learn(int val)
        {

        }

        public static double GetRandom()
        {

            return Random.NextDouble();
        }
    }
}
