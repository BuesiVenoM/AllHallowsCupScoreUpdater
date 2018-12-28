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
using System.IO;

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
            string pathSchedule = ConfigurationManager.AppSettings["pathSchedule"];
            string pathBrackets = ConfigurationManager.AppSettings["pathBrackets"];
            //string path = "c:\\stream-HalloweenHeroes\\Schedule\\";
            //Score scene
            s1n1.Text = System.IO.File.ReadAllText(pathSchedule + "Series1-Team1.txt");
            s1n2.Text = System.IO.File.ReadAllText(pathSchedule + "Series1-Team2.txt");
            s2n1.Text = System.IO.File.ReadAllText(pathSchedule + "Series2-Team1.txt");
            s2n2.Text = System.IO.File.ReadAllText(pathSchedule + "Series2-Team2.txt");
            s3n1.Text = System.IO.File.ReadAllText(pathSchedule + "Series3-Team1.txt");
            s3n2.Text = System.IO.File.ReadAllText(pathSchedule + "Series3-Team2.txt");
            s4n1.Text = System.IO.File.ReadAllText(pathSchedule + "Series4-Team1.txt");
            s4n2.Text = System.IO.File.ReadAllText(pathSchedule + "Series4-Team2.txt");
            s1s1.Text = System.IO.File.ReadAllText(pathSchedule + "S1-T1-Score.txt");
            s1s2.Text = System.IO.File.ReadAllText(pathSchedule + "S1-T2-Score.txt");
            s2s1.Text = System.IO.File.ReadAllText(pathSchedule + "S2-T1-Score.txt");
            s2s2.Text = System.IO.File.ReadAllText(pathSchedule + "S2-T2-Score.txt");
            s3s1.Text = System.IO.File.ReadAllText(pathSchedule + "S3-T1-Score.txt");
            s3s2.Text = System.IO.File.ReadAllText(pathSchedule + "S3-T2-Score.txt");
            s4s1.Text = System.IO.File.ReadAllText(pathSchedule + "S4-T1-Score.txt");
            s4s2.Text = System.IO.File.ReadAllText(pathSchedule + "S4-T2-Score.txt");

            //Brackets scene
            bs1n1.Text = System.IO.File.ReadAllText(pathBrackets + "Series1-Team1.txt");
            bs1n2.Text = System.IO.File.ReadAllText(pathBrackets + "Series1-Team2.txt");
            bs2n1.Text = System.IO.File.ReadAllText(pathBrackets + "Series2-Team1.txt");
            bs2n2.Text = System.IO.File.ReadAllText(pathBrackets + "Series2-Team2.txt");
            bs3n1.Text = System.IO.File.ReadAllText(pathBrackets + "Series3-Team1.txt");
            bs3n2.Text = System.IO.File.ReadAllText(pathBrackets + "Series3-Team2.txt");
            bs4n1.Text = System.IO.File.ReadAllText(pathBrackets + "Series4-Team1.txt");
            bs4n2.Text = System.IO.File.ReadAllText(pathBrackets + "Series4-Team2.txt");
            bs5n1.Text = System.IO.File.ReadAllText(pathBrackets + "Series5-Team1.txt");
            bs5n2.Text = System.IO.File.ReadAllText(pathBrackets + "Series5-Team2.txt");
            bs6n1.Text = System.IO.File.ReadAllText(pathBrackets + "Series6-Team1.txt");
            bs6n2.Text = System.IO.File.ReadAllText(pathBrackets + "Series6-Team2.txt");
            bs7n1.Text = System.IO.File.ReadAllText(pathBrackets + "Series7-Team1.txt");
            bs7n2.Text = System.IO.File.ReadAllText(pathBrackets + "Series7-Team2.txt");
            bs8n1.Text = System.IO.File.ReadAllText(pathBrackets + "Series8-Team1.txt");
            bs8n2.Text = System.IO.File.ReadAllText(pathBrackets + "Series8-Team2.txt");
            bWinner.Text = System.IO.File.ReadAllText(pathBrackets + "Winner.txt");
            //Message
            MessageBox.Show("The textfiles are leaded!");
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string pathSchedule = ConfigurationManager.AppSettings["pathSchedule"];
            string pathBrackets = ConfigurationManager.AppSettings["pathBrackets"];
            string pathTeamLogosScheduleImport = ConfigurationManager.AppSettings["pathTeamLogosScheduleImport"];
            string pathTeamLogosBracketsImport = ConfigurationManager.AppSettings["pathTeamLogosBracketsImport"];
            string pathTeamLogosExportSchedule = ConfigurationManager.AppSettings["pathTeamLogosExportSchedule"];
            string pathTeamLogosExportBrackets = ConfigurationManager.AppSettings["pathTeamLogosExportBrackets"];

            
            //Score scene - Schedule
            System.IO.Directory.CreateDirectory(pathSchedule);
            System.IO.File.WriteAllText(pathSchedule + "Series1-Team1.txt", Convert.ToString(s1n1.Text));
            System.IO.File.WriteAllText(pathSchedule + "Series1-Team2.txt", Convert.ToString(s1n2.Text));
            System.IO.File.WriteAllText(pathSchedule + "Series2-Team1.txt", Convert.ToString(s2n1.Text));
            System.IO.File.WriteAllText(pathSchedule + "Series2-Team2.txt", Convert.ToString(s2n2.Text));
            System.IO.File.WriteAllText(pathSchedule + "Series3-Team1.txt", Convert.ToString(s3n1.Text));
            System.IO.File.WriteAllText(pathSchedule + "Series3-Team2.txt", Convert.ToString(s3n2.Text));
            System.IO.File.WriteAllText(pathSchedule + "Series4-Team1.txt", Convert.ToString(s4n1.Text));
            System.IO.File.WriteAllText(pathSchedule + "Series4-Team2.txt", Convert.ToString(s4n2.Text));
            System.IO.File.WriteAllText(pathSchedule + "S1-T1-Score.txt", Convert.ToString(s1s1.Text));
            System.IO.File.WriteAllText(pathSchedule + "S1-T2-Score.txt", Convert.ToString(s1s2.Text));
            System.IO.File.WriteAllText(pathSchedule + "S2-T1-Score.txt", Convert.ToString(s2s1.Text));
            System.IO.File.WriteAllText(pathSchedule + "S2-T2-Score.txt", Convert.ToString(s2s2.Text));
            System.IO.File.WriteAllText(pathSchedule + "S3-T1-Score.txt", Convert.ToString(s3s1.Text));
            System.IO.File.WriteAllText(pathSchedule + "S3-T2-Score.txt", Convert.ToString(s3s2.Text));
            System.IO.File.WriteAllText(pathSchedule + "S4-T1-Score.txt", Convert.ToString(s4s1.Text));
            System.IO.File.WriteAllText(pathSchedule + "S4-T2-Score.txt", Convert.ToString(s4s2.Text));

            //Delete schedule-logos if exist
            System.IO.DirectoryInfo dis = new DirectoryInfo(pathTeamLogosExportSchedule);
            foreach (FileInfo file in dis.GetFiles())
            {
                file.Delete();
            }

            //Generate new logos from names
            try
            {
                System.IO.File.Copy(System.IO.Directory.GetFiles(pathTeamLogosScheduleImport, s1n1.Text + ".*").First(), pathTeamLogosExportSchedule + "s1n1" + Path.GetExtension(System.IO.Directory.GetFiles(pathTeamLogosScheduleImport, s1n1.Text + ".*").First()));
                System.IO.File.Copy(System.IO.Directory.GetFiles(pathTeamLogosScheduleImport, s1n2.Text + ".*").First(), pathTeamLogosExportSchedule + "s1n2" + Path.GetExtension(System.IO.Directory.GetFiles(pathTeamLogosScheduleImport, s1n2.Text + ".*").First()));
                System.IO.File.Copy(System.IO.Directory.GetFiles(pathTeamLogosScheduleImport, s2n1.Text + ".*").First(), pathTeamLogosExportSchedule + "s2n1" + Path.GetExtension(System.IO.Directory.GetFiles(pathTeamLogosScheduleImport, s2n1.Text + ".*").First()));
                System.IO.File.Copy(System.IO.Directory.GetFiles(pathTeamLogosScheduleImport, s2n2.Text + ".*").First(), pathTeamLogosExportSchedule + "s2n2" + Path.GetExtension(System.IO.Directory.GetFiles(pathTeamLogosScheduleImport, s2n2.Text + ".*").First()));
                System.IO.File.Copy(System.IO.Directory.GetFiles(pathTeamLogosScheduleImport, s3n1.Text + ".*").First(), pathTeamLogosExportSchedule + "s3n1" + Path.GetExtension(System.IO.Directory.GetFiles(pathTeamLogosScheduleImport, s3n1.Text + ".*").First()));
                System.IO.File.Copy(System.IO.Directory.GetFiles(pathTeamLogosScheduleImport, s3n2.Text + ".*").First(), pathTeamLogosExportSchedule + "s3n2" + Path.GetExtension(System.IO.Directory.GetFiles(pathTeamLogosScheduleImport, s3n2.Text + ".*").First()));
                System.IO.File.Copy(System.IO.Directory.GetFiles(pathTeamLogosScheduleImport, s4n1.Text + ".*").First(), pathTeamLogosExportSchedule + "s4n1" + Path.GetExtension(System.IO.Directory.GetFiles(pathTeamLogosScheduleImport, s4n1.Text + ".*").First()));
                System.IO.File.Copy(System.IO.Directory.GetFiles(pathTeamLogosScheduleImport, s4n2.Text + ".*").First(), pathTeamLogosExportSchedule + "s4n2" + Path.GetExtension(System.IO.Directory.GetFiles(pathTeamLogosScheduleImport, s4n2.Text + ".*").First()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Brackets scene
            System.IO.Directory.CreateDirectory(pathBrackets);
            System.IO.File.WriteAllText(pathBrackets + "Series1-Team1.txt", Convert.ToString(bs1n1.Text));
            System.IO.File.WriteAllText(pathBrackets + "Series1-Team2.txt", Convert.ToString(bs1n2.Text));
            System.IO.File.WriteAllText(pathBrackets + "Series2-Team1.txt", Convert.ToString(bs2n1.Text));
            System.IO.File.WriteAllText(pathBrackets + "Series2-Team2.txt", Convert.ToString(bs2n2.Text));
            System.IO.File.WriteAllText(pathBrackets + "Series3-Team1.txt", Convert.ToString(bs3n1.Text));
            System.IO.File.WriteAllText(pathBrackets + "Series3-Team2.txt", Convert.ToString(bs3n2.Text));
            System.IO.File.WriteAllText(pathBrackets + "Series4-Team1.txt", Convert.ToString(bs4n1.Text));
            System.IO.File.WriteAllText(pathBrackets + "Series4-Team2.txt", Convert.ToString(bs4n2.Text));
            System.IO.File.WriteAllText(pathBrackets + "Series5-Team1.txt", Convert.ToString(bs5n1.Text));
            System.IO.File.WriteAllText(pathBrackets + "Series5-Team2.txt", Convert.ToString(bs5n2.Text));
            System.IO.File.WriteAllText(pathBrackets + "Series6-Team1.txt", Convert.ToString(bs6n1.Text));
            System.IO.File.WriteAllText(pathBrackets + "Series6-Team2.txt", Convert.ToString(bs6n2.Text));
            System.IO.File.WriteAllText(pathBrackets + "Series7-Team1.txt", Convert.ToString(bs7n1.Text));
            System.IO.File.WriteAllText(pathBrackets + "Series7-Team2.txt", Convert.ToString(bs7n2.Text));
            System.IO.File.WriteAllText(pathBrackets + "Series8-Team1.txt", Convert.ToString(bs8n1.Text));
            System.IO.File.WriteAllText(pathBrackets + "Series8-Team2.txt", Convert.ToString(bs8n2.Text));
            System.IO.File.WriteAllText(pathBrackets + "Winner.txt", Convert.ToString(bWinner.Text));
            //Message
            MessageBox.Show("The textfiles are updated!");

            //Delete brackets-logos if exist
            System.IO.DirectoryInfo dib = new DirectoryInfo(pathTeamLogosExportBrackets);
            foreach (FileInfo file in dib.GetFiles())
            {
                file.Delete();
            }

            //Generate new logos from names
            try
            {
                System.IO.File.Copy(System.IO.Directory.GetFiles(pathTeamLogosBracketsImport, bs1n1.Text + ".*").First(), pathTeamLogosExportBrackets + "bs1n1" + Path.GetExtension(System.IO.Directory.GetFiles(pathTeamLogosBracketsImport, bs1n1.Text + ".*").First()));
                System.IO.File.Copy(System.IO.Directory.GetFiles(pathTeamLogosBracketsImport, bs1n2.Text + ".*").First(), pathTeamLogosExportBrackets + "bs1n2" + Path.GetExtension(System.IO.Directory.GetFiles(pathTeamLogosBracketsImport, bs1n2.Text + ".*").First()));
                System.IO.File.Copy(System.IO.Directory.GetFiles(pathTeamLogosBracketsImport, bs2n1.Text + ".*").First(), pathTeamLogosExportBrackets + "bs2n1" + Path.GetExtension(System.IO.Directory.GetFiles(pathTeamLogosBracketsImport, bs2n1.Text + ".*").First()));
                System.IO.File.Copy(System.IO.Directory.GetFiles(pathTeamLogosBracketsImport, bs2n2.Text + ".*").First(), pathTeamLogosExportBrackets + "bs2n2" + Path.GetExtension(System.IO.Directory.GetFiles(pathTeamLogosBracketsImport, bs2n2.Text + ".*").First()));
                System.IO.File.Copy(System.IO.Directory.GetFiles(pathTeamLogosBracketsImport, bs3n1.Text + ".*").First(), pathTeamLogosExportBrackets + "bs3n1" + Path.GetExtension(System.IO.Directory.GetFiles(pathTeamLogosBracketsImport, bs3n1.Text + ".*").First()));
                System.IO.File.Copy(System.IO.Directory.GetFiles(pathTeamLogosBracketsImport, bs3n2.Text + ".*").First(), pathTeamLogosExportBrackets + "bs3n2" + Path.GetExtension(System.IO.Directory.GetFiles(pathTeamLogosBracketsImport, bs3n2.Text + ".*").First()));
                System.IO.File.Copy(System.IO.Directory.GetFiles(pathTeamLogosBracketsImport, bs4n1.Text + ".*").First(), pathTeamLogosExportBrackets + "bs4n1" + Path.GetExtension(System.IO.Directory.GetFiles(pathTeamLogosBracketsImport, bs4n1.Text + ".*").First()));
                System.IO.File.Copy(System.IO.Directory.GetFiles(pathTeamLogosBracketsImport, bs4n2.Text + ".*").First(), pathTeamLogosExportBrackets + "bs4n2" + Path.GetExtension(System.IO.Directory.GetFiles(pathTeamLogosBracketsImport, bs4n2.Text + ".*").First()));
                System.IO.File.Copy(System.IO.Directory.GetFiles(pathTeamLogosBracketsImport, bs5n1.Text + ".*").First(), pathTeamLogosExportBrackets + "bs5n1" + Path.GetExtension(System.IO.Directory.GetFiles(pathTeamLogosBracketsImport, bs5n1.Text + ".*").First()));
                System.IO.File.Copy(System.IO.Directory.GetFiles(pathTeamLogosBracketsImport, bs5n2.Text + ".*").First(), pathTeamLogosExportBrackets + "bs5n2" + Path.GetExtension(System.IO.Directory.GetFiles(pathTeamLogosBracketsImport, bs5n2.Text + ".*").First()));
                System.IO.File.Copy(System.IO.Directory.GetFiles(pathTeamLogosBracketsImport, bs6n1.Text + ".*").First(), pathTeamLogosExportBrackets + "bs6n1" + Path.GetExtension(System.IO.Directory.GetFiles(pathTeamLogosBracketsImport, bs6n1.Text + ".*").First()));
                System.IO.File.Copy(System.IO.Directory.GetFiles(pathTeamLogosBracketsImport, bs6n2.Text + ".*").First(), pathTeamLogosExportBrackets + "bs6n2" + Path.GetExtension(System.IO.Directory.GetFiles(pathTeamLogosBracketsImport, bs6n2.Text + ".*").First()));
                System.IO.File.Copy(System.IO.Directory.GetFiles(pathTeamLogosBracketsImport, bs7n1.Text + ".*").First(), pathTeamLogosExportBrackets + "bs7n1" + Path.GetExtension(System.IO.Directory.GetFiles(pathTeamLogosBracketsImport, bs7n1.Text + ".*").First()));
                System.IO.File.Copy(System.IO.Directory.GetFiles(pathTeamLogosBracketsImport, bs7n2.Text + ".*").First(), pathTeamLogosExportBrackets + "bs7n2" + Path.GetExtension(System.IO.Directory.GetFiles(pathTeamLogosBracketsImport, bs7n2.Text + ".*").First()));
                System.IO.File.Copy(System.IO.Directory.GetFiles(pathTeamLogosBracketsImport, bs8n1.Text + ".*").First(), pathTeamLogosExportBrackets + "bs8n1" + Path.GetExtension(System.IO.Directory.GetFiles(pathTeamLogosBracketsImport, bs8n1.Text + ".*").First()));
                System.IO.File.Copy(System.IO.Directory.GetFiles(pathTeamLogosBracketsImport, bs8n2.Text + ".*").First(), pathTeamLogosExportBrackets + "bs8n2" + Path.GetExtension(System.IO.Directory.GetFiles(pathTeamLogosBracketsImport, bs8n2.Text + ".*").First()));
                System.IO.File.Copy(System.IO.Directory.GetFiles(pathTeamLogosBracketsImport, bWinner.Text + ".*").First(), pathTeamLogosExportBrackets + "bWinner" + Path.GetExtension(System.IO.Directory.GetFiles(pathTeamLogosBracketsImport, bWinner.Text + ".*").First()));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
