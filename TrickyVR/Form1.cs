using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrickyVR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            // show a file select dialog to load from
            OpenFileDialog imageSelector = new OpenFileDialog();
            ;
            if(imageSelector.ShowDialog() == DialogResult.OK) {
                // load the vr image to show

                // need to then get the image dim and stretch it to a size for viewing and position the two view ports
                Image img = Image.FromFile(imageSelector.FileName);
                pictureBoxL.Image = img;
                pictureBoxR.Image = img;

                // then set the position information  of where they need to go in the window
                 
                //pictureBoxL.Height;
                //;
                pictureBoxL.Location = new Point(this.Width/4 - pictureBoxL.Width/2, this.Height/2 - pictureBoxL.Height/2);// = 100;
                pictureBoxR.Location = new Point(this.Width / 4 + this.Width / 2 - pictureBoxL.Width / 2, this.Height / 2 - pictureBoxL.Height / 2);// = 100;
                //pictureBoxL.Location.Y = 100;
                // might need some red alignment indicators at the top center of the magiceyes


            }
            
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // use this to move the right picture left and right depending on the key
            //Console.WriteLine(e.KeyChar.ToString());
        }

        private void buttonleft_Click(object sender, EventArgs e)
        {
            pictureBoxR.Location = new Point(pictureBoxR.Location.X-1, pictureBoxR.Location.Y);
        }

        private void buttonright_Click(object sender, EventArgs e)
        {
            pictureBoxR.Location = new Point(pictureBoxR.Location.X + 1, pictureBoxR.Location.Y);
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a tool inteneded for use with VR head sets that can duplicate a desktop for display\nIt is tuned to run at 1920x1080.Load a magic eye image. Enjoy!", "TrickyVR");
        }
    }
}

