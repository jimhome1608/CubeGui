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
    public partial class frmCubeGui : Form
    {
        LedCube led_cube;

        public frmCubeGui()
        {
            InitializeComponent();
            led_cube = new LedCube();
            if (!led_cube.open())
            {
                lblConnectionStatus.Text ="Open Cube: FAILED";
                pnlConnectedStatus.BackColor = Color.Black;
            }
            else
            {
                lblConnectionStatus.Text = "Open Cube: OK";
                pnlConnectedStatus.BackColor = Color.Blue;
            }
           
        }

        private void nudRed_ValueChanged(object sender, EventArgs e)
        {
           
            led_cube.red = (int) nudRed.Value;           
            lblColorInfo.Text = led_cube.ToString();
            if (led_cube.connected)
               led_cube.all_colour(led_cube.red, led_cube.green, led_cube.blue);
        }

        private void nudGreen_valuechanged(object sender, EventArgs e)
        {
            led_cube.green = (int)nudGreen.Value;
            lblColorInfo.Text = led_cube.ToString();
            if (led_cube.connected)
                led_cube.all_colour(led_cube.red, led_cube.green, led_cube.blue);
        }

        private void nudBlue_ValueChanged(object sender, EventArgs e)
        {
            led_cube.blue = (int)nudBlue.Value;
            lblColorInfo.Text = led_cube.ToString();
            if (led_cube.connected)
                led_cube.all_colour(led_cube.red, led_cube.green, led_cube.blue);

        }

        
        private void frmCubeGui_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (led_cube.connected)
                led_cube.close();
        }
    }
}
