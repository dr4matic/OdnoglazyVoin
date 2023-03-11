using Biblioteka;
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

        private Snake _snake = new(new Biblioteka.Point(10, 10), 3);

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
                    case Keys.Down: YStep = 10; XStep = 0; break;
                    case Keys.Up: YStep = -10; XStep = 0;break;
                    case Keys.Left: XStep = -10;YStep = 0; break;
                    case Keys.Right: XStep = 10; YStep = 0; break;
            }
        }

        private async void Draw()
        {
            while (true)
            {
              
                await Task.Delay(t);
                Refresh();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            XRectangle += XStep;
            YRectangle += YStep;
            _snake.Move(new (XRectangle, YRectangle));
            var snake = _snake.Points().ToList();
            
            snake.ForEach(x => 
            { 
                e.Graphics.FillRectangle(new SolidBrush(Color.Red), new Rectangle(x.X, x.Y, size, size)); 
            });
            
     
        }
       
    }
}
