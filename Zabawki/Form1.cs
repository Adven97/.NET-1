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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listOfCreated_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listOfToys_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddClicked(object sender, EventArgs e)
        {
           if( listOfToys.SelectedItem == null)
            {
                return;
            }

           if(listOfToys.GetItemText() == "Car")
            {
                listOfCreated.Items.Insert(new Car("Car"));
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
