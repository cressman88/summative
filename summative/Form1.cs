using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

//Created By: Jacob Cressman
//Date: Sept 2018
//Description: Leo star constelation
namespace summative
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = null;
            Refresh();

            Graphics g = this.CreateGraphics();
            SolidBrush drawBrush = new SolidBrush(Color.White);
            SolidBrush desBrush = new SolidBrush(Color.DarkGreen);
            Font drawFont = new Font("Arial", 10, FontStyle.Bold);
            SoundPlayer player = new SoundPlayer(Properties.Resources.beep);

            g.Clear(Color.Black);
            g.FillEllipse(drawBrush, 184, 38, 7, 7);
            Thread.Sleep(550);
            g.FillEllipse(drawBrush, 199, 50, 10, 10);
            Thread.Sleep(500);
            g.FillEllipse(drawBrush, 150, 63, 10, 10);
            Thread.Sleep(450);
            g.FillEllipse(drawBrush, 157, 87, 10, 10);
            Thread.Sleep(400);
            g.FillEllipse(drawBrush, 181, 101, 8, 8);
            Thread.Sleep(350);
            g.FillEllipse(drawBrush, 187, 129, 9, 9);
            Thread.Sleep(300);
            g.FillEllipse(drawBrush, 85, 132, 6, 6);
            Thread.Sleep(250);
            g.FillEllipse(drawBrush, 34, 135, 7, 7);
            Thread.Sleep(200);
            g.FillEllipse(drawBrush, 80, 101, 10, 10);
            Thread.Sleep(1300);
            g.DrawString("Leo is one of the constellations of the zodiac," +
                "\nlying between cancer, the crab to the west," +
                "\nand virgo the maiden to the east.", drawFont, desBrush, 2, 200);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            SolidBrush titleBrush = new SolidBrush(Color.Red);
            Font titleFont = new Font("Arial", 30, FontStyle.Bold);
            Font nameFont = new Font("Arial", 18, FontStyle.Bold);

            g.DrawString("LEO", titleFont, titleBrush, 100, 65);
            g.DrawString("By: Jacob Cressman", nameFont, titleBrush, 25, 250);
        }
    }
}
