using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CubeConnection;

namespace CubeGui
{
    public partial class Form1 : Form
    {
        LedCube led_cube;

        public Form1()
        {
            InitializeComponent();
            led_cube = new LedCube();
            if (!led_cube.open())
            {
                textBox1.Text ="Open Cube: FAILED";
                pnlConnectedStatus.BackColor = Color.Black;
            }
            else
            {
                textBox1.Text = "Open Cube: OK";
                pnlConnectedStatus.BackColor = Color.Blue;
            }
           
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Up)
            {
                if (led_cube.blue >= 255)
                    return true;
                led_cube.blue = led_cube.blue + 1;
                led_cube.all_colour(led_cube.red, led_cube.green, led_cube.blue);
                lblColorInfo.Text = led_cube.ToString();
                return true;
            }

            if (keyData == Keys.Down)
            {
                if (led_cube.blue<= 0)
                    return true;
                led_cube.blue = led_cube.blue - 1;
                led_cube.all_colour(led_cube.red, led_cube.green, led_cube.blue);
                lblColorInfo.Text = led_cube.ToString();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}
