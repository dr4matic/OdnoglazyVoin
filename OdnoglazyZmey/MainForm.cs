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
        public MainForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            var x = pictureBox1.Location.X + (pictureBox1.Width /2);
            var y = pictureBox1.Location.Y + (pictureBox1.Height /2);

            e.Graphics.FillRectangle(new SolidBrush(Color.Red), new Rectangle(x, y, 20, 20));

            
        }
    }
}
