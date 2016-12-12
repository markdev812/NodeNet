using System;
using System.Collections.Generic;


namespace NodeNet
{
	public class Node
	{
		public Action<Node, int> OutputListener;

		public int Value { get; set; }
		private Dictionary<int, int> _ioMap = new Dictionary<int, int>();
		private Dictionary<Node, int> _inputs = new Dictionary<Node, int>();

		public void AddInput(Node node)
		{
			if (!_inputs.ContainsKey(node))
				_inputs.Add(node, 0);
			node.OutputListener += InputChanged;
		}

		void InputChanged(Node inputNode, int val)
		{
			if (_inputs.ContainsKey(inputNode))
				_inputs[inputNode] = val;
		}

		public void Eval()
		{
			//calc new lookup value based on inputs
			//	AND together all inputs to get lookup key
			int result = 0;
			foreach (var n in _inputs)
			{
				result &= n.Value;
			}
			//  get value for key in ioMap
			if (_ioMap.ContainsKey(result))
				Value = _ioMap[result];
			else //	set value to 0 if not found
				Value = 0;
			//notify upstream listener
			OutputListener?.Invoke(this, Value);
		}

		public void Learn(int val)
		{
			//calc key based on current inputs
			int result = 0;
			foreach (var n in _inputs)
			{
				result &= n.Value;
			}
			//set ioMap value for key to val
			_ioMap[result] = val;
		}
	}
}
