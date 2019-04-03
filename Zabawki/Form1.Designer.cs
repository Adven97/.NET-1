namespace Zabawki
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
            this.components = new System.ComponentModel.Container();
            this.listOfToys = new System.Windows.Forms.ListBox();
            this.Add = new System.Windows.Forms.Button();
            this.listOfAdded = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.deepBox = new System.Windows.Forms.GroupBox();
            this.depthBox = new System.Windows.Forms.TextBox();
            this.incrDepth = new System.Windows.Forms.Button();
            this.decrDepth = new System.Windows.Forms.Button();
            this.accBox = new System.Windows.Forms.GroupBox();
            this.speedBx = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.riseBox = new System.Windows.Forms.GroupBox();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.deepBox.SuspendLayout();
            this.accBox.SuspendLayout();
            this.riseBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // listOfToys
            // 
            this.listOfToys.FormattingEnabled = true;
            this.listOfToys.Items.AddRange(new object[] {
            "Car",
            "Plane",
            "Submarine",
            "Computer"});
            this.listOfToys.Location = new System.Drawing.Point(43, 53);
            this.listOfToys.Name = "listOfToys";
            this.listOfToys.Size = new System.Drawing.Size(127, 251);
            this.listOfToys.TabIndex = 0;
            this.listOfToys.SelectedIndexChanged += new System.EventHandler(this.listOfToys_SelectedIndexChanged);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(188, 109);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(71, 34);
            this.Add.TabIndex = 1;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.AddClick);
            // 
            // listOfAdded
            // 
            this.listOfAdded.FormattingEnabled = true;
            this.listOfAdded.Location = new System.Drawing.Point(269, 53);
            this.listOfAdded.Name = "listOfAdded";
            this.listOfAdded.Size = new System.Drawing.Size(124, 251);
            this.listOfAdded.TabIndex = 2;
            this.listOfAdded.SelectedIndexChanged += new System.EventHandler(this.listOfAdded_SelectedIndexChanged);
            // 
            // deepBox
            // 
            this.deepBox.Controls.Add(this.depthBox);
            this.deepBox.Controls.Add(this.incrDepth);
            this.deepBox.Controls.Add(this.decrDepth);
            this.deepBox.Location = new System.Drawing.Point(459, 251);
            this.deepBox.Name = "deepBox";
            this.deepBox.Size = new System.Drawing.Size(323, 65);
            this.deepBox.TabIndex = 3;
            this.deepBox.TabStop = false;
            this.deepBox.Text = "Depth";
            this.deepBox.Enter += new System.EventHandler(this.speedBox_Enter);
            // 
            // depthBox
            // 
            this.depthBox.Location = new System.Drawing.Point(114, 25);
            this.depthBox.Name = "depthBox";
            this.depthBox.ReadOnly = true;
            this.depthBox.Size = new System.Drawing.Size(88, 20);
            this.depthBox.TabIndex = 2;
            this.depthBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // incrDepth
            // 
            this.incrDepth.Location = new System.Drawing.Point(220, 19);
            this.incrDepth.Name = "incrDepth";
            this.incrDepth.Size = new System.Drawing.Size(64, 31);
            this.incrDepth.TabIndex = 1;
            this.incrDepth.Text = "+";
            this.incrDepth.UseVisualStyleBackColor = true;
            this.incrDepth.Click += new System.EventHandler(this.button2_Click);
            // 
            // decrDepth
            // 
            this.decrDepth.Location = new System.Drawing.Point(32, 19);
            this.decrDepth.Name = "decrDepth";
            this.decrDepth.Size = new System.Drawing.Size(61, 31);
            this.decrDepth.TabIndex = 0;
            this.decrDepth.Text = "-";
            this.decrDepth.UseVisualStyleBackColor = true;
            this.decrDepth.Click += new System.EventHandler(this.button1_Click);
            // 
            // accBox
            // 
            this.accBox.Controls.Add(this.speedBx);
            this.accBox.Controls.Add(this.button6);
            this.accBox.Controls.Add(this.button5);
            this.accBox.Location = new System.Drawing.Point(459, 147);
            this.accBox.Name = "accBox";
            this.accBox.Size = new System.Drawing.Size(323, 71);
            this.accBox.TabIndex = 4;
            this.accBox.TabStop = false;
            this.accBox.Text = "Acceleration";
            // 
            // speedBx
            // 
            this.speedBx.Location = new System.Drawing.Point(114, 27);
            this.speedBx.Name = "speedBx";
            this.speedBx.ReadOnly = true;
            this.speedBx.Size = new System.Drawing.Size(88, 20);
            this.speedBx.TabIndex = 2;
            this.speedBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(220, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(64, 34);
            this.button6.TabIndex = 1;
            this.button6.Text = "+";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(32, 19);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(61, 34);
            this.button5.TabIndex = 0;
            this.button5.Text = "-";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // riseBox
            // 
            this.riseBox.Controls.Add(this.heightBox);
            this.riseBox.Controls.Add(this.button4);
            this.riseBox.Controls.Add(this.button3);
            this.riseBox.Location = new System.Drawing.Point(459, 53);
            this.riseBox.Name = "riseBox";
            this.riseBox.Size = new System.Drawing.Size(323, 68);
            this.riseBox.TabIndex = 5;
            this.riseBox.TabStop = false;
            this.riseBox.Text = "Height";
            // 
            // heightBox
            // 
            this.heightBox.Location = new System.Drawing.Point(114, 27);
            this.heightBox.Name = "heightBox";
            this.heightBox.ReadOnly = true;
            this.heightBox.Size = new System.Drawing.Size(88, 20);
            this.heightBox.TabIndex = 2;
            this.heightBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(220, 20);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(64, 32);
            this.button4.TabIndex = 1;
            this.button4.Text = "+";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(32, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 32);
            this.button3.TabIndex = 0;
            this.button3.Text = "-";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(188, 184);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(75, 34);
            this.Remove.TabIndex = 6;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.RemoveClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 392);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.riseBox);
            this.Controls.Add(this.accBox);
            this.Controls.Add(this.deepBox);
            this.Controls.Add(this.listOfAdded);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.listOfToys);
            this.Name = "Form1";
            this.Text = "Form1";
            this.deepBox.ResumeLayout(false);
            this.deepBox.PerformLayout();
            this.accBox.ResumeLayout(false);
            this.accBox.PerformLayout();
            this.riseBox.ResumeLayout(false);
            this.riseBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listOfToys;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.ListBox listOfAdded;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox deepBox;
        private System.Windows.Forms.Button incrDepth;
        private System.Windows.Forms.Button decrDepth;
        private System.Windows.Forms.TextBox depthBox;
        private System.Windows.Forms.GroupBox accBox;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox riseBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox speedBx;
        private System.Windows.Forms.TextBox heightBox;
        private System.Windows.Forms.Button Remove;
    }
}

