﻿using System;
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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.Autostart(true);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Program.Autostart(false);
        }
    }
}