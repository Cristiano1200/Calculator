namespace Calculator
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textin = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textout = new System.Windows.Forms.TextBox();
            this.Run = new System.Windows.Forms.Button();
            this.Log = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textin);
            this.groupBox1.Location = new System.Drawing.Point(34, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 47);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operation";
            // 
            // textin
            // 
            this.textin.Location = new System.Drawing.Point(6, 19);
            this.textin.Name = "textin";
            this.textin.Size = new System.Drawing.Size(172, 20);
            this.textin.TabIndex = 0;
            this.textin.Text = "-5+4-4/2*3";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textout);
            this.groupBox2.Location = new System.Drawing.Point(224, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 47);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Result";
            // 
            // textout
            // 
            this.textout.Location = new System.Drawing.Point(6, 19);
            this.textout.Name = "textout";
            this.textout.Size = new System.Drawing.Size(172, 20);
            this.textout.TabIndex = 0;
            // 
            // Run
            // 
            this.Run.Location = new System.Drawing.Point(414, 28);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(75, 47);
            this.Run.TabIndex = 2;
            this.Run.Text = "Calculate";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // Log
            // 
            this.Log.Location = new System.Drawing.Point(40, 81);
            this.Log.Multiline = true;
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(362, 95);
            this.Log.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 188);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textout;
        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.TextBox Log;
    }
}

