using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Background_Web_View
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();

            // Align to the right of the screen
            Rectangle rect = Screen.FromControl(this).Bounds;
            this.Location = new Point(rect.Width - 1280 - 400, 200);

            Timer timer = new Timer();
            timer.Tick += Timer_Tick;
            timer.Interval = 3000;
            timer.Enabled = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Close();
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Splash_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
