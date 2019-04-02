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
            speedBox.Enabled = false;
            accBox.Enabled = false;
            riseBox.Enabled = false;

        }

        /// / / / / submarine  -  panel
        private void button1_Click(object sender, EventArgs e)
        {
            if (listOfAdded.SelectedItem is IDepth)
            {
                Submarine sub = (Submarine)listOfAdded.SelectedItem;
                depthBox.Text = sub.Higher().ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listOfAdded.SelectedItem is IDepth)
            {
                Submarine sub = (Submarine)listOfAdded.SelectedItem;
                depthBox.Text = sub.Deeper().ToString();
            }

        }

        //  / /// // CAR - panel
        private void button5_Click(object sender, EventArgs e)
        {
            if (listOfAdded.SelectedItem is IAccelerate)
            {
                Car car = (Car)listOfAdded.SelectedItem;
                speedBx.Text = car.goSlower().ToString();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listOfAdded.SelectedItem is IAccelerate)
            {
                Car car = (Car)listOfAdded.SelectedItem;
                speedBx.Text = car.goFaster().ToString();
            }
        }

        /// Samoloty - panel
        private void button3_Click(object sender, EventArgs e)
        {
            if (listOfAdded.SelectedItem is IHeight)
            { 
                Plane plane = (Plane)listOfAdded.SelectedItem;
                heightBox.Text = plane.goLower().ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listOfAdded.SelectedItem is IHeight)
            {
                Plane plane = (Plane)listOfAdded.SelectedItem;
                heightBox.Text = plane.goHigher().ToString();
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

            if (listOfAdded.SelectedItem as Computer != null)
            {
                speedBox.Enabled = false;
                accBox.Enabled = false;
                riseBox.Enabled = false;

                heightBox.Clear();
                depthBox.Clear();
                speedBx.Clear();

            }

            if (listOfAdded.SelectedItem is IAccelerate)
            {
                speedBox.Enabled = false;
                accBox.Enabled = true;
                riseBox.Enabled = false;

                heightBox.Clear();
                depthBox.Clear();

                Car car = (Car)listOfAdded.SelectedItem;
                speedBx.Text = car.getSpeed().ToString();
            }

            if (listOfAdded.SelectedItem is IDepth)
            {
                speedBox.Enabled = true;
                accBox.Enabled = false;
                riseBox.Enabled = false;

                speedBx.Clear();
                heightBox.Clear();

                Submarine sub = (Submarine)listOfAdded.SelectedItem;
                depthBox.Text = sub.getDepth().ToString();

            }

            if (listOfAdded.SelectedItem is IHeight)
            {
                speedBox.Enabled = false;
                accBox.Enabled = false;
                riseBox.Enabled = true;

                speedBx.Clear();
                depthBox.Clear();

                Plane plane = (Plane)listOfAdded.SelectedItem;
                heightBox.Text = plane.getHeight().ToString();

            }

        }


        private void RemoveClick(object sender, EventArgs e)
        {
            listOfAdded.Items.Remove(listOfAdded.SelectedItem);

            speedBox.Enabled = false;
            accBox.Enabled = false;
            riseBox.Enabled = false;

            heightBox.Clear();
            depthBox.Clear();
            speedBx.Clear();
        }

    }
}

