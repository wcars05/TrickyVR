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
            this.AllowDrop = true;
            
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

                // base the image box max setting based on the form's resolution settigns
                pictureBoxL.MaximumSize = new Size(this.Width / 2, this.Height / 2);
                pictureBoxR.MaximumSize = new Size(this.Width / 2, this.Height / 2);


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

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            // maybe load an image?
            

            Image img = (Image)e.Data.GetData(DataFormats.Bitmap);
            pictureBoxL.Image = img;
            pictureBoxR.Image = img;

            // then set the position information  of where they need to go in the window

            //pictureBoxL.Height;
            //;
            pictureBoxL.Location = new Point(this.Width / 4 - pictureBoxL.Width / 2, this.Height / 2 - pictureBoxL.Height / 2);// = 100;
            pictureBoxR.Location = new Point(this.Width / 4 + this.Width / 2 - pictureBoxL.Width / 2, this.Height / 2 - pictureBoxL.Height / 2);// = 100;
                                                                                                                                                //pictureBoxL.Location.Y = 100;
                                                                                                                                                // might need some red alignment indicators at the top center of the magiceyes

            // base the image box max setting based on the form's resolution settigns
            pictureBoxL.MaximumSize = new Size(this.Width / 2, this.Height / 2);
            pictureBoxR.MaximumSize = new Size(this.Width / 2, this.Height / 2);
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            //DataFormats.Bitmap
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void pictureBoxL_DragDrop(object sender, DragEventArgs e)
        {
            Image img = (Image)e.Data.GetData(DataFormats.Bitmap);
            pictureBoxL.Image = img;
            pictureBoxR.Image = img;

            // then set the position information  of where they need to go in the window

            //pictureBoxL.Height;
            //;
            pictureBoxL.Location = new Point(this.Width / 4 - pictureBoxL.Width / 2, this.Height / 2 - pictureBoxL.Height / 2);// = 100;
            pictureBoxR.Location = new Point(this.Width / 4 + this.Width / 2 - pictureBoxL.Width / 2, this.Height / 2 - pictureBoxL.Height / 2);// = 100;
                                                                                                                                                //pictureBoxL.Location.Y = 100;
                                                                                                                                                // might need some red alignment indicators at the top center of the magiceyes

            // base the image box max setting based on the form's resolution settigns
            pictureBoxL.MaximumSize = new Size(this.Width / 2, this.Height / 2);
            pictureBoxR.MaximumSize = new Size(this.Width / 2, this.Height / 2);
        }

        private void pictureBoxL_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void pictureBoxL_DragEnter(object sender, DragEventArgs e)
        {
            
        }

        private void Form1_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            pictureBoxL.Location = new Point(this.Width / 4 - pictureBoxL.Width / 2, this.Height / 2 - pictureBoxL.Height / 2);// = 100;
            pictureBoxR.Location = new Point(this.Width / 4 + this.Width / 2 - pictureBoxL.Width / 2, this.Height / 2 - pictureBoxL.Height / 2);// = 100;
                                                                                                                                                //pictureBoxL.Location.Y = 100;
                                                                                                                                                // might need some red alignment indicators at the top center of the magiceyes

            // base the image box max setting based on the form's resolution settigns
            pictureBoxL.MaximumSize = new Size(this.Width / 2, this.Height / 2);
            pictureBoxR.MaximumSize = new Size(this.Width / 2, this.Height / 2);
        }
    }
}

