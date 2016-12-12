namespace NodeNet
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.txtInput1 = new System.Windows.Forms.TextBox();
            this.btnEval = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnLearn = new System.Windows.Forms.Button();
            this.txtInput2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtInput1
            // 
            this.txtInput1.Location = new System.Drawing.Point(16, 23);
            this.txtInput1.Name = "txtInput1";
            this.txtInput1.Size = new System.Drawing.Size(83, 20);
            this.txtInput1.TabIndex = 0;
            this.txtInput1.Text = "0";
            // 
            // btnEval
            // 
            this.btnEval.Location = new System.Drawing.Point(154, 62);
            this.btnEval.Name = "btnEval";
            this.btnEval.Size = new System.Drawing.Size(75, 23);
            this.btnEval.TabIndex = 1;
            this.btnEval.Text = "Eval";
            this.btnEval.UseVisualStyleBackColor = true;
            this.btnEval.Click += new System.EventHandler(this.btnEval_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(281, 23);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(100, 20);
            this.txtOutput.TabIndex = 2;
            this.txtOutput.Text = "0";
            // 
            // btnLearn
            // 
            this.btnLearn.Location = new System.Drawing.Point(154, 23);
            this.btnLearn.Name = "btnLearn";
            this.btnLearn.Size = new System.Drawing.Size(75, 23);
            this.btnLearn.TabIndex = 1;
            this.btnLearn.Text = "Learn";
            this.btnLearn.UseVisualStyleBackColor = true;
            this.btnLearn.Click += new System.EventHandler(this.btnLearn_Click);
            // 
            // txtInput2
            // 
            this.txtInput2.Location = new System.Drawing.Point(16, 62);
            this.txtInput2.Name = "txtInput2";
            this.txtInput2.Size = new System.Drawing.Size(83, 20);
            this.txtInput2.TabIndex = 3;
            this.txtInput2.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 193);
            this.Controls.Add(this.txtInput2);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnLearn);
            this.Controls.Add(this.btnEval);
            this.Controls.Add(this.txtInput1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtInput1;
		private System.Windows.Forms.Button btnEval;
		private System.Windows.Forms.TextBox txtOutput;
		private System.Windows.Forms.Button btnLearn;
        private System.Windows.Forms.TextBox txtInput2;
    }
}

