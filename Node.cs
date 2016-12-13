using System;
using System.Collections.Generic;


namespace NodeNet
{
	public class Node
	{
		//public Action<Node, int> OutputListener;
		private int _value;
		public int Value
		{
			get { return _value; }
			set { _value = value; }
		}

		private Dictionary<int, int> _ioMap = new Dictionary<int, int>();
		private List<Node> _inputs = new List<Node>();
		

		public void AddInput(Node node)
		{
			_inputs.Add(node);
			//node.OutputListener += InputChanged;
		}

		//void InputChanged(Node inputNode, int val)
		//{
		//	if (_inputs.ContainsKey(inputNode))
		//		_inputs[inputNode] = val;
		//}

		public void Eval()
		{
			//calc new lookup value based on inputs
			int key = _inputs.Count;
			for (int i = 0; i < _inputs.Count; i++)
			{
				key = unchecked(key * 32 + _inputs[i].Value);
			}
			//  get value for key in ioMap
			if (_ioMap.ContainsKey(key))
				Value = _ioMap[key];
			else //	set value to 0 if not found
				Value = 0;
			//notify upstream listener
			//OutputListener?.Invoke(this, Value);
		}

		public void Learn(int val)
		{
			//calc key based on current inputs
			int key = _inputs.Count;
			for (int i = 0; i<_inputs.Count; i++)
			{
				key = unchecked(key * 32 + _inputs[i].Value);
			}
			//set ioMap value for key to val
			_ioMap[key] = val;
		}
	}
}
