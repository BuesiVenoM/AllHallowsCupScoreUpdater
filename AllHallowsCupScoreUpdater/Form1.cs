using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace AllHallowsCupScoreUpdater
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            string path = ConfigurationManager.AppSettings["path"];
            //string path = "c:\\stream-HalloweenHeroes\\Schedule\\";
            s1n1.Text = System.IO.File.ReadAllText(path + "Series1-Team1.txt");
            s1n2.Text = System.IO.File.ReadAllText(path + "Series1-Team2.txt");
            s2n1.Text = System.IO.File.ReadAllText(path + "Series2-Team1.txt");
            s2n2.Text = System.IO.File.ReadAllText(path + "Series2-Team2.txt");
            s3n1.Text = System.IO.File.ReadAllText(path + "Series3-Team1.txt");
            s3n2.Text = System.IO.File.ReadAllText(path + "Series3-Team2.txt");
            s4n1.Text = System.IO.File.ReadAllText(path + "Series4-Team1.txt");
            s4n2.Text = System.IO.File.ReadAllText(path + "Series4-Team2.txt");
            s1s1.Text = System.IO.File.ReadAllText(path + "S1-T1-Score.txt");
            s1s2.Text = System.IO.File.ReadAllText(path + "S1-T2-Score.txt");
            s2s1.Text = System.IO.File.ReadAllText(path + "S2-T1-Score.txt");
            s2s2.Text = System.IO.File.ReadAllText(path + "S2-T2-Score.txt");
            s3s1.Text = System.IO.File.ReadAllText(path + "S3-T1-Score.txt");
            s3s2.Text = System.IO.File.ReadAllText(path + "S3-T2-Score.txt");
            s4s1.Text = System.IO.File.ReadAllText(path + "S4-T1-Score.txt");
            s4s2.Text = System.IO.File.ReadAllText(path + "S4-T2-Score.txt");

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string path = ConfigurationManager.AppSettings["path"];
            //string path = "c:\\stream-HalloweenHeroes\\Schedule\\";
            System.IO.Directory.CreateDirectory(path);
            System.IO.File.WriteAllText(path + "Series1-Team1.txt", Convert.ToString(s1n1.Text));
            System.IO.File.WriteAllText(path + "Series1-Team2.txt", Convert.ToString(s1n2.Text));
            System.IO.File.WriteAllText(path + "Series2-Team1.txt", Convert.ToString(s2n1.Text));
            System.IO.File.WriteAllText(path + "Series2-Team2.txt", Convert.ToString(s2n2.Text));
            System.IO.File.WriteAllText(path + "Series3-Team1.txt", Convert.ToString(s3n1.Text));
            System.IO.File.WriteAllText(path + "Series3-Team2.txt", Convert.ToString(s3n2.Text));
            System.IO.File.WriteAllText(path + "Series4-Team1.txt", Convert.ToString(s4n1.Text));
            System.IO.File.WriteAllText(path + "Series4-Team2.txt", Convert.ToString(s4n2.Text));
            System.IO.File.WriteAllText(path + "S1-T1-Score.txt", Convert.ToString(s1s1.Text));
            System.IO.File.WriteAllText(path + "S1-T2-Score.txt", Convert.ToString(s1s2.Text));
            System.IO.File.WriteAllText(path + "S2-T1-Score.txt", Convert.ToString(s2s1.Text));
            System.IO.File.WriteAllText(path + "S2-T2-Score.txt", Convert.ToString(s2s2.Text));
            System.IO.File.WriteAllText(path + "S3-T1-Score.txt", Convert.ToString(s3s1.Text));
            System.IO.File.WriteAllText(path + "S3-T2-Score.txt", Convert.ToString(s3s2.Text));
            System.IO.File.WriteAllText(path + "S4-T1-Score.txt", Convert.ToString(s4s1.Text));
            System.IO.File.WriteAllText(path + "S4-T2-Score.txt", Convert.ToString(s4s2.Text));
            MessageBox.Show("The textfiles are updated!");
        }
    }
}
