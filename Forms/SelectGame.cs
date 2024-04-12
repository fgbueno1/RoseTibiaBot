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
using Newtonsoft.Json;
using static RoseTibiaBot.Main;
using Newtonsoft.Json.Linq;

namespace RoseTibiaBot
{
    public partial class SelectGame : Form
    {
        public string SelectedWindowName { get; private set; }


        public string json;

        public SelectGame()
        {
            InitializeComponent();
            PopulateWindowList();
        }

        private void PopulateWindowList()
        {
            json = File.ReadAllText("servers.json");
            JObject servers = JObject.Parse(json);
            Process[] processes = Process.GetProcesses();
            List<Process> tibiaProcesses = new List<Process>();
            foreach (var server in servers.Properties()){
                string serverName = server.Name;
                var matchingProcesses = processes.Where(p => p.MainWindowTitle.StartsWith(serverName));
                tibiaProcesses.AddRange(matchingProcesses);
            }
            foreach (Process process in tibiaProcesses)
            {
                comboBox_select.Items.Add(process.MainWindowTitle);
            }
        }

        private void pictureBox_button_Click(object sender, EventArgs e)
        {
            if (comboBox_select.SelectedItem != null)
            {
                JArray offsets = new JArray();
                SelectedWindowName = comboBox_select.SelectedItem.ToString();
                JObject servers = JObject.Parse(json);
                foreach (var server in servers.Properties())
                {
                    if (SelectedWindowName.StartsWith(server.Name))
                    {
                        offsets = (JArray)server.Value;
                    }
                }
                this.Hide();
                Main RoseTibiaBot = new Main(SelectedWindowName, offsets);
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
