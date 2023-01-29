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
    public partial class mainForm : Form
    {
        Gallery gallery = new Gallery();
        public mainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = gallery.addCurator(textBox3.Text,textBox1.Text,textBox2.Text);
            MessageBox.Show(message);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string allCurator = gallery.getAllCuratorInfo();
            richTextBox1.AppendText(allCurator);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string message = gallery.addArtist(textBox4.Text,textBox6.Text,textBox5.Text);
            MessageBox.Show(message);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string allArtist = gallery.getAllArtistInfo();
            richTextBox1.AppendText(allArtist);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string msg = gallery.saveCuratorIntoFile();
            MessageBox.Show(msg);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string msg = gallery.saveArtisitIntoFile();
            MessageBox.Show (msg);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string message = gallery.addartPiece(textBox9.Text, textBox12.Text, textBox11.Text,
                textBox8.Text, int.Parse(textBox7.Text), double.Parse(textBox10.Text));
            MessageBox.Show(message);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string allPiece = gallery.getAllArtPieceInfo();
            richTextBox1.AppendText(allPiece);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string message = gallery.saveArtPieceIntoFile();
            MessageBox.Show(message);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form sellForm = new sellForm();
            //sellForm.Visible = true;
            //sellForm.Activate();
            sellForm.ShowDialog();
        }
    }
}
