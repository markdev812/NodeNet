using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NodeNet
{
	public partial class Form1 : Form
	{
        private readonly List<Node> _inputNodes = new List<Node>();
        private Node _nodeOut;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			CreateNet();
		}

		private void CreateNet()
		{
            //create input nodes
            _inputNodes.Add(new Node());
            _inputNodes.Add(new Node());

            //add output node
            _nodeOut = new Node(_inputNodes);

        }

		private void btnLearn_Click(object sender, EventArgs e)
		{

		}

		private void btnEval_Click(object sender, EventArgs e)
		{

            //set input value
            _inputNodes[0].Value = double.Parse(txtInput1.Text);
            _inputNodes[1].Value = double.Parse(txtInput2.Text);

            //eval for result
            _nodeOut.CalcValue();

		    txtOutput.Text = _nodeOut.Value.ToString();
		}
	}
}
