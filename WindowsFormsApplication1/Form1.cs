using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void createProfileClick(object sender, EventArgs e)
        {
            
        }

        private void exitClick(object sender, EventArgs e)
        {
            Form2 exit = new Form2();
            exit.ShowDialog();
        }
    }
}
