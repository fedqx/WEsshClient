using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WEsshClient
{
    public partial class Form1 : Form
    {
        String ProfileDir;
        public Form1()
        {
            InitializeComponent();
            ProfileDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Profiles";
            InitProfiles();
        }

        private void SaveProfile()
        {
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter(ProfileDir + "\\" + profilenamebox.Text + ".prf");
                //Write a line of text
                sw.WriteLine(ipbox.Text);
                sw.WriteLine(usernamebox.Text);
                sw.WriteLine(portbox.Text);
                sw.WriteLine(sshkeylabel.Text);
                sw.WriteLine(portcheckbox.Checked);
                foreach (string item in portforwardbox.Items)
                {
                    sw.WriteLine(item);
                }
                //Close the file
                sw.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception: " + e.Message);
                //Console.WriteLine("Exception: " + e.Message);
            }

        }

        private void LoadProfile()
        {
            String line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(ProfileDir + "\\" + profilebox.SelectedItem.ToString());
                //Read the first line of text
                ipbox.Text = sr.ReadLine();
                usernamebox.Text = sr.ReadLine();
                portbox.Text = sr.ReadLine();
                sshkeylabel.Text = sr.ReadLine();
                if (sr.ReadLine() == "True")
                {
                    portcheckbox.Checked = true;
                }
                
                line = sr.ReadLine();
                
                while(line != null)
                {
                    portforwardbox.Items.Add(line);
                    line = sr.ReadLine();

                }
                //close the file
                sr.Close();
 
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception: " + e.Message);
            }

        }

        private void InitProfiles()
        {
            profilebox.Items.Clear();

            Directory.CreateDirectory(ProfileDir);

            string[] files = Directory.GetFiles(ProfileDir);
            foreach (string file in files)
            {

                profilebox.Items.Add(Path.GetFileName(file));

            }



        }

        private void connectbutton_Click(object sender, EventArgs e)
        {
            String command; //= new string();
            Process process = new Process();
            command ="ssh " + usernamebox.Text + "@" + ipbox.Text;
            command += " -p " + portbox.Text;
            if (sshkeylabel.Text != "")
            {
                command += " -i " + sshkeylabel.Text;
            }

            if (portcheckbox.Checked)
            {
                foreach (string item in portforwardbox.Items)
                {
                    command += " -L " + item;
                }

            }

            process.StartInfo.FileName = "C:\\Windows\\system32\\cmd.exe";
            process.StartInfo.Arguments = " /C title Wessh && " + command + " & pause";
            process.Start();


        }

        private void saveprofilebox_Click(object sender, EventArgs e)
        {
            SaveProfile();
            InitProfiles();
        }

        private void loadprofilebutton_Click(object sender, EventArgs e)
        {
            LoadProfile();
            InitProfiles();
        }

        private void portforwardaddbutton_Click(object sender, EventArgs e)
        {
            portforwardbox.Items.Add(portforwardtextbox.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    sshkeylabel.Text = openFileDialog1.FileName;
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }
    }
}
