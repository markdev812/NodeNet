using System;
using System.Collections.Generic;


namespace NodeNet
{
	public class Node
	{
		public Action<Node, byte> OutputListener;

		private byte _value;
		private Dictionary<byte, byte> _ioMap = new Dictionary<byte, byte>();
		private Dictionary<Node, byte> _inputs = new Dictionary<Node, byte>();

		void AddInput(Node node)
		{
			if (!_inputs.ContainsKey(node))
				_inputs.Add(node, 0);
			node.OutputListener += InputChanged;
		}

		void InputChanged(Node inputNode, byte val)
		{
			if (_inputs.ContainsKey(inputNode))
				_inputs[inputNode] = val;
		}

		void Update()
		{
			//calc new lookup value based on inputs
			//	AND together all inputs to get lookup key
			//  get value for key in ioMap
			//	set value to 0 if not found

			//notify upstream listener
			OutputListener?.Invoke(this, _value);
		}

		void Learn(byte val)
		{
			//calc key based on current inputs
			//set ioMap value for key to val
		}
	}
}
