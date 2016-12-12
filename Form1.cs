using System;
using System.Windows.Forms;

namespace NodeNet
{
	public partial class Form1 : Form
	{
        private Node node_in_1;
        private Node node_in_2;
        private Node node_out;
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
            //add input nodes
            node_in_1 = new Node();
            node_in_2 = new Node();

            //add output node
            node_out = new Node();

			//connect nodes
			node_out.AddInput(node_in_1);
            node_out.AddInput(node_in_2);
        }

		private void btnLearn_Click(object sender, EventArgs e)
		{
            //set input values
            node_in_1.Value = int.Parse(txtInput1.Text);
            node_in_2.Value = int.Parse(txtInput2.Text);

            //teach output node the correct result
            node_out.Learn(int.Parse(txtOutput.Text));
		}

		private void btnEval_Click(object sender, EventArgs e)
		{

            //set input value
            node_in_1.Value = int.Parse(txtInput1.Text);
            node_in_2.Value = int.Parse(txtInput2.Text);

            //eval for result
            node_out.Eval();

		    txtOutput.Text = node_out.Value.ToString();
		}
	}
}
