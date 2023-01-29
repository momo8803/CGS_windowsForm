using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GCS_ClassLibrary;

namespace CGS_windows
{

    public partial class sellForm : Form
    {
        Gallery gallery = new Gallery();
        public sellForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = gallery.Sellpiece(textBox1.Text,double.Parse(textBox2.Text));
            MessageBox.Show(message);
        }
    }
}
