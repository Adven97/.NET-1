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
            this.listOfToys = new System.Windows.Forms.ListBox();
            this.Add = new System.Windows.Forms.Button();
            this.listOfCreated = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listOfToys
            // 
            this.listOfToys.AccessibleName = "ListOfToys";
            this.listOfToys.FormattingEnabled = true;
            this.listOfToys.Items.AddRange(new object[] {
            "Car",
            "Plane",
            "Submarine ",
            "Computer"});
            this.listOfToys.Location = new System.Drawing.Point(33, 23);
            this.listOfToys.Name = "listOfToys";
            this.listOfToys.Size = new System.Drawing.Size(120, 95);
            this.listOfToys.TabIndex = 0;
            this.listOfToys.SelectedIndexChanged += new System.EventHandler(this.listOfToys_SelectedIndexChanged);
            // 
            // Add
            // 
            this.Add.AccessibleName = "Add";
            this.Add.Location = new System.Drawing.Point(184, 57);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 1;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.AddClicked);
            // 
            // listOfCreated
            // 
            this.listOfCreated.FormattingEnabled = true;
            this.listOfCreated.Location = new System.Drawing.Point(283, 23);
            this.listOfCreated.Name = "listOfCreated";
            this.listOfCreated.Size = new System.Drawing.Size(120, 95);
            this.listOfCreated.TabIndex = 2;
            this.listOfCreated.SelectedIndexChanged += new System.EventHandler(this.listOfCreated_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(157, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(502, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(190, 100);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(56, 37);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(81, 20);
            this.textBox2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 200);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.listOfCreated);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.listOfToys);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listOfToys;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.ListBox listOfCreated;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox2;
    }
}

