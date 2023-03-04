using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdnoglazyZmey
{
    public partial class MainForm : Form
    {
        const int size = 10;

        int XRectangle = 0;
        int YRectangle = 0;
        int t = 100;
        int XStep = 0;
        int YStep = 0;
        public MainForm()
        {
            InitializeComponent();
            KeyDown += MainForm_KeyDown;
            

            XRectangle = pictureBox1.Location.X + (pictureBox1.Width / 2);
            YRectangle = pictureBox1.Location.Y + (pictureBox1.Height / 2);
            Draw();
        }

        private void MainForm_KeyDown(object? sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                    case Keys.Down: YStep = 1; XStep = 0; break;
                    case Keys.Up: YStep = -1; XStep = 0;break;
                    case Keys.Left: XStep = -1;YStep = 0; break;
                    case Keys.Right: XStep = 1; YStep = 0; break;
            }
        }

        private async void Draw()
        {
            while (true)
            {
                t -= 10;
                if (t < 10)
                {
                    t = 10;
                }
                await Task.Delay(t);
                Refresh();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            XRectangle += XStep;
            YRectangle += YStep;
            e.Graphics.FillRectangle(new SolidBrush(Color.Red), new Rectangle(XRectangle, YRectangle, size, size));          
        }
    }
}
