using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;

namespace NFiR {
    public static class TextDialog {

        private static System.Windows.Forms.PictureBox pictureBox1 = new System.Windows.Forms.PictureBox();


        public static void ShowDialog(string text, string title) {
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pictureBox1.Image = global::NFiR.Properties.Resources.VirtualBuildsHD2;
            pictureBox1.Location = new System.Drawing.Point(3, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(119, 78);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;

            LinkLabel vb = new LinkLabel();
            vb.Text = "virtualbuilds.com";
            vb.Location = new Point(22, 83);
            vb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel_Clicked);
            Console.WriteLine(vb.Text);

            Form dialog = new Form();
            dialog.ShowIcon = false;
            dialog.Width = 360;
            dialog.Height = 160;
            dialog.Text = title;
            dialog.AutoSize = true;

            Panel panel = new Panel();
            panel.SetBounds(0, 0, 360, 160);
            panel.SendToBack();

            Label textLabel = new Label() { Left = 120, Top = 30, Text = text };
            textLabel.AutoSize = true;

            //Image image = Image.FromFile(@"\NFR3.jpg");
            //PictureBox picBox = new PictureBox();
            //picBox.Image = image;
            //picBox.ImageLocation = "appfiles/NFR3.jpg";
            pictureBox1.Location = new Point(30, 30);
            pictureBox1.Size = new Size(70, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            dialog.Controls.Add(vb);
            dialog.Controls.Add(textLabel);
            dialog.Controls.Add(pictureBox1);
            dialog.ShowDialog();
        }

        private static void linkLabel_Clicked(object sender, LinkLabelLinkClickedEventArgs e) {

            Process.Start("https://www.virtualbuilds.com/");
        }

    }
}
