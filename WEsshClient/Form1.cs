using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WEsshClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void connectbutton_Click(object sender, EventArgs e)
        {
            Process process = new Process();

            process.StartInfo.FileName = "C:\\Windows\\System32\\cmd.exe";
            process.StartInfo.Arguments = "/K C:\\Users\\f3dqx\\server.bat";
            
            process.Start();

        }
    }
}
