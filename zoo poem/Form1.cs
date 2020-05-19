using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace zoo_poem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Walking Roung the Zoo\n";
            repeatVerse();
            adaptablePart("parrot", "squawked\nAnd winked");

            repeatVerse();
            adaptablePart("crocodile", "snapped\nIts jaws");
        }
        public void repeatVerse()
        {
            label1.Text += "\nWalking round the zoo";
            label1.Text += "\nWhat did I see?";
        }

        public void adaptablePart(string animal, string actions)
        {
            label1.Text += "\na " + animal + " that " + actions + " at me";
        }
    }
}
