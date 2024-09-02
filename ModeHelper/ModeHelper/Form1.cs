using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ModeHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("SU.cmd", "");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("RegAlyzer.cmd", "");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("ProcessHacker.cmd", "");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("RunCommand.cmd", "");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("TotalCmd.cmd", "");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process.Start("AutoRun.bat", "");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Process.Start("Limitation.bat", "");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Process.Start("Debugger.bat", "");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Process.Start("fix-asson.bat", "");
        }


        private void button12_Click(object sender, EventArgs e)
        {
            Process.Start("Process-Monitor.cmd", "");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Process.Start("fix.bat", "");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Process.Start("Process-Explorer.cmd", "");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Process.Start("ColorCmd.cmd", "");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start("Autoruns.cmd", "");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Process.Start("Gpedit.msc", "");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Process.Start("Taskmgr.exe", "");
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            Process.Start("regedit.exe", "");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Process.Start("CMD.exe", "");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Process.Start("dcontrol.cmd", "");
        }
    }
}