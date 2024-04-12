using Microsoft.VisualBasic.Devices;
using System;
using System.Diagnostics;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.DataFormats;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RoseTibiaBot
{
    public partial class Main : Form
    {

        const int PROCESS_ALL_ACCESS = 0x1F0FFF;

        private static readonly string[] keys = {
        "F1", "F2", "F3", "F4", "F5", "F6",
        "F7", "F8", "F9", "F10", "F11", "F12",
        "Insert", "Home", "PageUp", "PageDown", "Delete", "End"
    };

        private static int[] virtualKeys = {
        0x70, 0x71, 0x72, 0x73, 0x74, 0x75, 0x76, 0x77, 0x78, 0x79, 0x7A, 0x7B, 0x2D, 0x24, 0x21, 0x22, 0x2E, 0x23
    };

        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int dwSize, out int lpNumberOfBytesRead);

        [DllImport("kernel32.dll")]
        public static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int dwSize, out int lpNumberOfBytesWritten);

        [DllImport("kernel32.dll")]
        public static extern bool CloseHandle(IntPtr hObject);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern short GetKeyState(int nVirtKey);


        private IntPtr processHandle;
        private IntPtr finalAddress;
        private IntPtr hwnd;

        public class Positions{
            public Point uhPos;
            public Point charPos;
            public Point foodPos;
            public Point targetingPos;
            public Point tool1Pos;
            public Point tool2Pos;
            public Point tool3Pos;
        }
        public Positions positions = new Positions();

        public Main(string winName, JArray offsets)
        {
            InitializeComponent();
            string[] name = winName.Split('-');
            Text = Text + " -" + name[1];
            hwnd = FindWindow(null, winName);
            int processId = GetProcessIdByWindowName(winName);
            if (processId == 0)
            {
                MessageBox.Show("Failed to find process with window name: " + winName);
                this.Close();
            }
            long baseAddress = (long)GetBaseAddress(processId);
            long pointerAddress = baseAddress + (long)offsets[0];

            processHandle = OpenProcess(PROCESS_ALL_ACCESS, false, processId);
            if (processHandle == IntPtr.Zero)
            {
                //MessageBox.Show("Failed to open process. Error code: " + Marshal.GetLastWin32Error());
                this.Close();
            }
            byte[] pointerBuffer = new byte[IntPtr.Size]; // Pointer size
            int bytesRead;
            ReadProcessMemory(processHandle, (IntPtr)pointerAddress, pointerBuffer, pointerBuffer.Length, out bytesRead);

            if (bytesRead != IntPtr.Size)
            {
                //MessageBox.Show("Failed to read pointer value. Error code: " + Marshal.GetLastWin32Error());
                CloseHandle(processHandle);
                return;
            }

            finalAddress = (IntPtr)BitConverter.ToInt64(pointerBuffer, 0) + (IntPtr)offsets[1];
        }

        private int GetProcessIdByWindowName(string windowName)
        {
            foreach (Process process in Process.GetProcesses())
            {
                if (process.MainWindowTitle.Contains(windowName))
                {
                    return process.Id;
                }
            }
            return 0;
        }

        static IntPtr GetBaseAddress(int processId)
        {
            try
            {
                Process process = Process.GetProcessById(processId);
                if (process == null)
                {
                    return IntPtr.Zero;
                }

                foreach (ProcessModule module in process.Modules)
                {
                    if (module.FileName.Equals(process.MainModule.FileName, StringComparison.OrdinalIgnoreCase))
                    {
                        return module.BaseAddress;
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Failed to get base address: " + ex.Message);
            }

            return IntPtr.Zero;
        }

        private void timer_light_Tick(object sender, EventArgs e)
        {
            if (checkBox_light.Checked)
            {

                byte[] buffer = new byte[1]; // Writing a single byte
                buffer[0] = 0x0F; // Value to write (for example, 255)

                int bytesWritten;

                WriteProcessMemory(processHandle, finalAddress, buffer, buffer.Length, out bytesWritten);

                if (bytesWritten == 0)
                {
                    return;
                }
            }
        }

        private void timer_spell_trainer_Tick(object sender, EventArgs e)
        {
            if (checkBox_Spell_Trainer.Checked)
            {
                if (int.TryParse(textBox_timer_trainer.Text, out int interval))
                {
                    timer_spell_trainer.Interval = interval * 1000;
                }
                else
                {
                    timer_spell_trainer.Interval = 2000;
                    MessageBox.Show("Invalid interval value", Text);
                }
                var key = comboBox_trainer.SelectedItem.ToString();
                if (key is not null)
                {
                    Events _events = new Events(hwnd);
                    _events.Keystroke(key);
                }
            }
        }

        private void button_pos_healing_Click(object sender, EventArgs e)
        {
            MessageBox.Show("put your mouse in your character for the next 5 seconds", Text);
            Thread.Sleep(4000);
            positions.charPos = Cursor.Position;
            MessageBox.Show("put your mouse in the uh for the next 5 seconds", Text);
            Thread.Sleep(4000);
            positions.uhPos = Cursor.Position;
            MessageBox.Show("positions done", Text);
            label_char_x_healing.Text = "char_pos_x: " + positions.charPos.X.ToString();
            label_char_y_healing.Text = "char_pos_y: " + positions.charPos.Y.ToString();
            label_uh_x_healing.Text = "uh_pos_x: " + positions.uhPos.X.ToString();
            label_uh_y_healing.Text = "uh_pos_y: " + positions.uhPos.Y.ToString();
        }

        private void timer_healing_Tick(object sender, EventArgs e)
        {
            if (checkBox_healing.Checked)
            {
                var key = comboBox_healing.SelectedItem.ToString();
                int index = Array.IndexOf(keys, key);
                if (index >= 0)
                {
                    int virtualKey = virtualKeys[index];
                    if (GetKeyState(virtualKey) < 0)
                    {
                        Events _events = new Events(hwnd);
                        _events.Mouse_Right_Click(positions.uhPos);
                        _events.Mouse_Left_Click(positions.charPos);
                    }
                }
            }
        }

        private void button_pos_food_Click(object sender, EventArgs e)
        {
            MessageBox.Show("put your mouse in the food for the next 5 seconds", Text);
            Thread.Sleep(4000);
            positions.foodPos = Cursor.Position;
            MessageBox.Show("positions done", Text);
            label_x_food_trainer.Text = "food_pos_x: " + positions.foodPos.X.ToString();
            label_y_food_trainer.Text = "food_pos_y: " + positions.foodPos.Y.ToString();
        }

        private void timer_food_Tick(object sender, EventArgs e)
        {
            if (checkBox_food_trainer.Checked)
            {
                Events _events = new Events(hwnd);
                _events.Mouse_Right_Click(positions.foodPos);
            }
        }

        private void button_targeting_Click(object sender, EventArgs e)
        {
            MessageBox.Show("put your mouse in the rune for the next 5 seconds", Text);
            Thread.Sleep(4000);
            positions.targetingPos = Cursor.Position;
            MessageBox.Show("positions done", Text);
            label_x_targeting.Text = "pos_x: " + positions.targetingPos.X.ToString();
            label_y_targeting.Text = "pos_y: " + positions.targetingPos.Y.ToString();
        }

        private void timer_targeting_Tick(object sender, EventArgs e)
        {
            if (checkBox_targeting.Checked)
            {
                var key = comboBox_targeting.SelectedItem.ToString();
                int index = Array.IndexOf(keys, key);
                if (index >= 0)
                {
                    int virtualKey = virtualKeys[index];
                    if (GetKeyState(virtualKey) < 0)
                    {
                        Point targetPos = Cursor.Position;
                        Events _events = new Events(hwnd);
                        _events.Mouse_Right_Click(positions.targetingPos);
                        _events.Mouse_Left_Click(targetPos);
                    }
                }
            }
        }

        private void button_pos_tool1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("put your mouse in the tool for the next 5 seconds", Text);
            Thread.Sleep(4000);
            positions.tool1Pos = Cursor.Position;
            MessageBox.Show("positions done", Text);
            label_x_tool1.Text = "pos_x: " + positions.tool1Pos.X.ToString();
            label_y_tool1.Text = "pos_y: " + positions.tool1Pos.Y.ToString();
        }

        private void button_pos_tool2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("put your mouse in the tool for the next 5 seconds", Text);
            Thread.Sleep(4000);
            positions.tool2Pos = Cursor.Position;
            MessageBox.Show("positions done", Text);
            label_x_tool2.Text = "pos_x: " + positions.tool2Pos.X.ToString();
            label_y_tool2.Text = "pos_y: " + positions.tool2Pos.Y.ToString();
        }

        private void button_pos_tool3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("put your mouse in the tool for the next 5 seconds", Text);
            Thread.Sleep(4000);
            positions.tool3Pos = Cursor.Position;
            MessageBox.Show("positions done", Text);
            label_x_tool3.Text = "pos_x: " + positions.tool3Pos.X.ToString();
            label_y_tool3.Text = "pos_y: " + positions.tool3Pos.Y.ToString();
        }

        private void timer_tool1_Tick(object sender, EventArgs e)
        {
            if (checkBox_tool1.Checked)
            {
                var key = comboBox_tool1.SelectedItem.ToString();
                int index = Array.IndexOf(keys, key);
                if (index >= 0)
                {
                    int virtualKey = virtualKeys[index];
                    if (GetKeyState(virtualKey) < 0)
                    {
                        Point targetPos = Cursor.Position;
                        Events _events = new Events(hwnd);
                        _events.Mouse_Right_Click(positions.tool1Pos);
                        _events.Mouse_Left_Click(targetPos);
                    }
                }
            }
        }

        private void timer_tool2_Tick(object sender, EventArgs e)
        {
            if (checkBox_tool2.Checked)
            {
                var key = comboBox_tool2.SelectedItem.ToString();
                int index = Array.IndexOf(keys, key);
                if (index >= 0)
                {
                    int virtualKey = virtualKeys[index];
                    if (GetKeyState(virtualKey) < 0)
                    {
                        Point targetPos = Cursor.Position;
                        Events _events = new Events(hwnd);
                        _events.Mouse_Right_Click(positions.tool2Pos);
                        _events.Mouse_Left_Click(targetPos);
                    }
                }
            }
        }

        private void timer_tool3_Tick(object sender, EventArgs e)
        {
            if (checkBox_tool3.Checked)
            {
                var key = comboBox_tool3.SelectedItem.ToString();
                int index = Array.IndexOf(keys, key);
                if (index >= 0)
                {
                    int virtualKey = virtualKeys[index];
                    if (GetKeyState(virtualKey) < 0)
                    {
                        Point targetPos = Cursor.Position;
                        Events _events = new Events(hwnd);
                        _events.Mouse_Right_Click(positions.tool3Pos);
                        _events.Mouse_Left_Click(targetPos);
                    }
                }
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            string json = JsonConvert.SerializeObject(positions);

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.DefaultExt = "json";
            saveFileDialog1.Filter = "Json files|*.json";
            saveFileDialog1.Title = "Save File";
            saveFileDialog1.CheckPathExists = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, json);
                MessageBox.Show("Positions Saved", Text);
            }
        }

        private void button_load_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.DefaultExt = "json";
            openFileDialog.Filter = "Json files|*.json";
            openFileDialog.Title = "Save File";
            openFileDialog.CheckPathExists = true;
            openFileDialog.CheckFileExists = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string json = File.ReadAllText(openFileDialog.FileName);
                positions = JsonConvert.DeserializeObject<Positions>(json);

                label_char_x_healing.Text = "char_pos_x: " + positions.charPos.X.ToString();
                label_char_y_healing.Text = "char_pos_y: " + positions.charPos.Y.ToString();
                label_uh_x_healing.Text = "uh_pos_x: " + positions.uhPos.X.ToString();
                label_uh_y_healing.Text = "uh_pos_y: " + positions.uhPos.Y.ToString();
                label_x_food_trainer.Text = "food_pos_x: " + positions.foodPos.X.ToString();
                label_y_food_trainer.Text = "food_pos_y: " + positions.foodPos.Y.ToString();
                label_x_targeting.Text = "pos_x: " + positions.targetingPos.X.ToString();
                label_y_targeting.Text = "pos_y: " + positions.targetingPos.Y.ToString();
                label_x_tool1.Text = "pos_x: " + positions.tool1Pos.X.ToString();
                label_y_tool1.Text = "pos_y: " + positions.tool1Pos.Y.ToString();
                label_x_tool2.Text = "pos_x: " + positions.tool2Pos.X.ToString();
                label_y_tool2.Text = "pos_y: " + positions.tool2Pos.Y.ToString();
                label_x_tool3.Text = "pos_x: " + positions.tool3Pos.X.ToString();
                label_y_tool3.Text = "pos_y: " + positions.tool3Pos.Y.ToString();

                MessageBox.Show("Positions Loaded", Text);
            }
        }
    }
}
