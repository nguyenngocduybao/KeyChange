using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Key
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            lb1.Text = "Ban da nhan " + e.KeyCode.ToString();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            lb1.Text = e.KeyChar.ToString();
        }        
    }

}
