using System;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.DataFormats;

namespace RoseTibiaBot
{
    public partial class SelectGame : Form
    {
        public string SelectedWindowName { get; private set; }

        public SelectGame()
        {
            InitializeComponent();
            PopulateWindowList();
        }

        private void PopulateWindowList()
        {
            Process[] processes = Process.GetProcesses();
            List<Process> tibiaScapeProcesses = processes.Where(p => p.MainWindowTitle.StartsWith("TibiaScape")).ToList();

            foreach (Process process in tibiaScapeProcesses)
            {
                comboBox_select.Items.Add(process.MainWindowTitle);
            }
        }

        private void pictureBox_button_Click(object sender, EventArgs e)
        {
            if (comboBox_select.SelectedItem != null)
            {
                SelectedWindowName = comboBox_select.SelectedItem.ToString();
                this.Hide();
                Main RoseTibiaBot = new Main(SelectedWindowName);
                RoseTibiaBot.Closed += (s, args) => this.Close();
                RoseTibiaBot.Show();
            }
            else
            {
                MessageBox.Show("Please select a window.", Text);
            }

        }
    }
}
