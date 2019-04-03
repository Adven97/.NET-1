using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zabawki
{
    public partial class Form1 : Form
    {
 
        
        public Form1()
        {
            InitializeComponent();
            deepBox.Enabled = false;
            accBox.Enabled = false;
            riseBox.Enabled = false;

        }

        /// Samoloty - panel
        private void button3_Click(object sender, EventArgs e)    //// decreses height
        {
            if (listOfAdded.SelectedItem is IHeight)
            {
                IHeight high = (IHeight)listOfAdded.SelectedItem;
                heightBox.Text = high.goLower().ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)     ////  increses height
        {
            if (listOfAdded.SelectedItem is IHeight)
            {
                IHeight high = (IHeight)listOfAdded.SelectedItem;
                heightBox.Text = high.goHigher().ToString();
            }
        }

        //  / /// // CAR - panel
        private void button5_Click(object sender, EventArgs e)      /// decreses speed
        {
            if (listOfAdded.SelectedItem is IAccelerate)
            {
                IAccelerate speed = (IAccelerate)listOfAdded.SelectedItem;
                speedBx.Text = speed.goSlower().ToString();
            }

        }

        private void button6_Click(object sender, EventArgs e)       /// increses speed
        {
            if (listOfAdded.SelectedItem is IAccelerate)
            {
                IAccelerate speed = (IAccelerate)listOfAdded.SelectedItem;
                speedBx.Text = speed.goFaster().ToString();
            }
        }

        /// / / / / submarine  -  panel
        private void button1_Click(object sender, EventArgs e)     ///decreses depth 
        {
            if (listOfAdded.SelectedItem is IDepth)
            {
                IDepth dept = (IDepth)listOfAdded.SelectedItem;
                depthBox.Text = dept.Higher().ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)     ///increses depth
        {
            if (listOfAdded.SelectedItem is IDepth)
            {
                IDepth dept = (IDepth)listOfAdded.SelectedItem;
                depthBox.Text = dept.Deeper().ToString();
            }

        }

        private void listOfToys_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddClick(object sender, EventArgs e)
        {
            if (listOfToys.SelectedItem == null)
            {
                return;
            }

            switch (listOfToys.GetItemText(listOfToys.SelectedItem))
            {
                case "Car":
                    listOfAdded.Items.Add(new Car("Car"));
                    break;
                case "Plane":
                    listOfAdded.Items.Add(new Plane("Plane"));
                    break;
                case "Submarine":
                    listOfAdded.Items.Add(new Submarine("Submarine"));
                    break;
                case "Computer":
                    listOfAdded.Items.Add(new Computer("Computer"));
                    break;
            }

        }
    

        private void speedBox_Enter(object sender, EventArgs e)
        {
        }

        private void listOfAdded_SelectedIndexChanged(object sender, EventArgs e)
        {
            riseBox.Enabled = false;
            heightBox.Clear();

            accBox.Enabled = false;
            speedBx.Clear();

            deepBox.Enabled = false;
            depthBox.Clear();

            if (listOfAdded.SelectedItem is IAccelerate)
            {

                accBox.Enabled = true;

                heightBox.Clear();
                depthBox.Clear();

                IAccelerate sped = (IAccelerate)listOfAdded.SelectedItem;
                speedBx.Text = sped.getSpeed().ToString();
            }


            if (listOfAdded.SelectedItem is IDepth)
            {
                deepBox.Enabled = true;

                heightBox.Clear();

                IDepth depf = (IDepth)listOfAdded.SelectedItem;
                depthBox.Text = depf.getDepth().ToString();

            }

            if (listOfAdded.SelectedItem is IHeight)
            {

                riseBox.Enabled = true;

                depthBox.Clear();

                IHeight hajt = (IHeight)listOfAdded.SelectedItem;
                heightBox.Text = hajt.getHeight().ToString();
                
            }

        }


        private void RemoveClick(object sender, EventArgs e)
        {
            listOfAdded.Items.Remove(listOfAdded.SelectedItem);

            deepBox.Enabled = false;
            accBox.Enabled = false;
            riseBox.Enabled = false;

            heightBox.Clear();
            depthBox.Clear();
            speedBx.Clear();
        }

    }
}

