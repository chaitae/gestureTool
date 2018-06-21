using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        bool isPaused = true;
        int counter = 1;
        FolderBrowserDialog fbd = new FolderBrowserDialog();
        bool playing = false;
        int duration = 30;
        string[] images;
        int index = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            timer.Text = counter/10+" seconds";
            if(counter >= duration)
            {
                index++;
            }
            pictureBox2.Image = Image.FromFile(images[0]);

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Play_Click(object sender, EventArgs e)
        {

        }
        
        

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        

        private void thirtySeconds_Click(object sender, EventArgs e)
        {

        }

        private void fourtySeconds_Click(object sender, EventArgs e)
        {
            duration = 40;
        }

        private void sixtySeconds_Click(object sender, EventArgs e)
        {
            duration = 60;
        }

        private void fiveMinutes_Click(object sender, EventArgs e)
        {
            duration = 60 * 5;
        }

        private void thirtyMinutes_Click(object sender, EventArgs e)
        {
            duration = 60 * 30;

        }

        private void fifteenMinutes_Click(object sender, EventArgs e)
        {
            duration = 60 * 15;
        }

        private void chooseFolder_Click_1(object sender, EventArgs e)
        {
            DialogResult result = fbd.ShowDialog();

            if (fbd.SelectedPath.Length > 0)
            {
                images = Directory.GetFiles(fbd.SelectedPath, "*.*");
                folderName.Text = fbd.SelectedPath.ToString();
            }
        }

        private void startToggle_Click(object sender, EventArgs e)
        {
            isPaused = !isPaused;
            timer1.Enabled = isPaused;

        }

        private void start_Click(object sender, EventArgs e)
        {
            isPaused = false;
            timer1.Enabled = true;
            tabControl.SelectedTab = page2;
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = page1;
        }
    }
}
