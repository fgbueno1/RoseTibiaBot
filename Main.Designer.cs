namespace RoseTibiaBot
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            Title = new Label();
            timer_light = new System.Windows.Forms.Timer(components);
            groupBox_Title = new GroupBox();
            pictureBox4 = new PictureBox();
            timer_spell_trainer = new System.Windows.Forms.Timer(components);
            timer_healing = new System.Windows.Forms.Timer(components);
            timer_food = new System.Windows.Forms.Timer(components);
            timer_targeting = new System.Windows.Forms.Timer(components);
            timer_tool1 = new System.Windows.Forms.Timer(components);
            timer_tool2 = new System.Windows.Forms.Timer(components);
            timer_tool3 = new System.Windows.Forms.Timer(components);
            pictureBox3 = new PictureBox();
            groupBox_tool1 = new GroupBox();
            comboBox_tool1 = new ComboBox();
            button_pos_tool1 = new Button();
            label_y_tool1 = new Label();
            label_x_tool1 = new Label();
            checkBox_tool1 = new CheckBox();
            groupBox_tool2 = new GroupBox();
            checkBox_tool2 = new CheckBox();
            comboBox_tool2 = new ComboBox();
            button_pos_tool2 = new Button();
            label_y_tool2 = new Label();
            label_x_tool2 = new Label();
            groupBox_tool3 = new GroupBox();
            checkBox_tool3 = new CheckBox();
            comboBox_tool3 = new ComboBox();
            button_pos_tool3 = new Button();
            label_y_tool3 = new Label();
            label_x_tool3 = new Label();
            groupBox_Tools = new GroupBox();
            comboBox_trainer = new ComboBox();
            checkBox_Spell_Trainer = new CheckBox();
            label_timer_trainer = new Label();
            textBox_timer_trainer = new TextBox();
            checkBox_food_trainer = new CheckBox();
            label_x_food_trainer = new Label();
            label_y_food_trainer = new Label();
            button_pos_food = new Button();
            groupBox_Trainer = new GroupBox();
            tabPage2 = new TabPage();
            groupBox_save_load = new GroupBox();
            button_load = new Button();
            button_save = new Button();
            tabPage1 = new TabPage();
            groupBox_Healing = new GroupBox();
            pictureBox1 = new PictureBox();
            comboBox_healing = new ComboBox();
            checkBox_healing = new CheckBox();
            label_uh_y_healing = new Label();
            label_uh_x_healing = new Label();
            button_pos_healing = new Button();
            label_char_y_healing = new Label();
            label_char_x_healing = new Label();
            groupBox_Targeting = new GroupBox();
            checkBox_targeting = new CheckBox();
            comboBox_targeting = new ComboBox();
            button_targeting = new Button();
            label_y_targeting = new Label();
            label_x_targeting = new Label();
            pictureBox2 = new PictureBox();
            groupBox_light = new GroupBox();
            checkBox_light = new CheckBox();
            tabControl1 = new TabControl();
            groupBox_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox_tool1.SuspendLayout();
            groupBox_tool2.SuspendLayout();
            groupBox_tool3.SuspendLayout();
            groupBox_Tools.SuspendLayout();
            groupBox_Trainer.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox_save_load.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox_Healing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox_Targeting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox_light.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Algerian", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(238, 0);
            Title.Name = "Title";
            Title.Size = new Size(203, 26);
            Title.TabIndex = 0;
            Title.Text = "Rose Tibia Bot";
            // 
            // timer_light
            // 
            timer_light.Enabled = true;
            timer_light.Tick += timer_light_Tick;
            // 
            // groupBox_Title
            // 
            groupBox_Title.BackColor = Color.DarkGray;
            groupBox_Title.Controls.Add(pictureBox4);
            groupBox_Title.Controls.Add(Title);
            groupBox_Title.ForeColor = Color.Black;
            groupBox_Title.Location = new Point(9, 32);
            groupBox_Title.Name = "groupBox_Title";
            groupBox_Title.Size = new Size(671, 76);
            groupBox_Title.TabIndex = 3;
            groupBox_Title.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(317, 28);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(45, 45);
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // timer_spell_trainer
            // 
            timer_spell_trainer.Enabled = true;
            timer_spell_trainer.Tick += timer_spell_trainer_Tick;
            // 
            // timer_healing
            // 
            timer_healing.Enabled = true;
            timer_healing.Tick += timer_healing_Tick;
            // 
            // timer_food
            // 
            timer_food.Enabled = true;
            timer_food.Interval = 10000;
            timer_food.Tick += timer_food_Tick;
            // 
            // timer_targeting
            // 
            timer_targeting.Enabled = true;
            timer_targeting.Tick += timer_targeting_Tick;
            // 
            // timer_tool1
            // 
            timer_tool1.Enabled = true;
            timer_tool1.Tick += timer_tool1_Tick;
            // 
            // timer_tool2
            // 
            timer_tool2.Enabled = true;
            timer_tool2.Tick += timer_tool2_Tick;
            // 
            // timer_tool3
            // 
            timer_tool3.Enabled = true;
            timer_tool3.Tick += timer_tool3_Tick;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Squeezing_Gear_of_Girlpower;
            pictureBox3.Location = new Point(69, -1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 33);
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // groupBox_tool1
            // 
            groupBox_tool1.Controls.Add(comboBox_tool1);
            groupBox_tool1.Controls.Add(button_pos_tool1);
            groupBox_tool1.Controls.Add(label_y_tool1);
            groupBox_tool1.Controls.Add(label_x_tool1);
            groupBox_tool1.Controls.Add(checkBox_tool1);
            groupBox_tool1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox_tool1.Location = new Point(14, 31);
            groupBox_tool1.Name = "groupBox_tool1";
            groupBox_tool1.Size = new Size(169, 117);
            groupBox_tool1.TabIndex = 10;
            groupBox_tool1.TabStop = false;
            groupBox_tool1.Text = "Tool 1";
            // 
            // comboBox_tool1
            // 
            comboBox_tool1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox_tool1.FormattingEnabled = true;
            comboBox_tool1.Items.AddRange(new object[] { "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12", "Insert", "Home", "PageUp", "PageDown", "Delete", "End" });
            comboBox_tool1.Location = new Point(6, 85);
            comboBox_tool1.Name = "comboBox_tool1";
            comboBox_tool1.Size = new Size(74, 23);
            comboBox_tool1.TabIndex = 10;
            comboBox_tool1.Text = "F1";
            // 
            // button_pos_tool1
            // 
            button_pos_tool1.BackColor = Color.Silver;
            button_pos_tool1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_pos_tool1.Location = new Point(38, 54);
            button_pos_tool1.Name = "button_pos_tool1";
            button_pos_tool1.Size = new Size(95, 26);
            button_pos_tool1.TabIndex = 10;
            button_pos_tool1.Text = "Get Pos";
            button_pos_tool1.UseVisualStyleBackColor = false;
            button_pos_tool1.Click += button_pos_tool1_Click;
            // 
            // label_y_tool1
            // 
            label_y_tool1.AutoSize = true;
            label_y_tool1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_y_tool1.Location = new Point(1, 34);
            label_y_tool1.Name = "label_y_tool1";
            label_y_tool1.Size = new Size(51, 15);
            label_y_tool1.TabIndex = 10;
            label_y_tool1.Text = "pos_y: ";
            // 
            // label_x_tool1
            // 
            label_x_tool1.AutoSize = true;
            label_x_tool1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_x_tool1.Location = new Point(1, 19);
            label_x_tool1.Name = "label_x_tool1";
            label_x_tool1.Size = new Size(51, 15);
            label_x_tool1.TabIndex = 10;
            label_x_tool1.Text = "pos_x: ";
            // 
            // checkBox_tool1
            // 
            checkBox_tool1.AutoSize = true;
            checkBox_tool1.Location = new Point(86, 87);
            checkBox_tool1.Name = "checkBox_tool1";
            checkBox_tool1.Size = new Size(71, 19);
            checkBox_tool1.TabIndex = 8;
            checkBox_tool1.Text = "Enable";
            checkBox_tool1.UseVisualStyleBackColor = true;
            // 
            // groupBox_tool2
            // 
            groupBox_tool2.Controls.Add(checkBox_tool2);
            groupBox_tool2.Controls.Add(comboBox_tool2);
            groupBox_tool2.Controls.Add(button_pos_tool2);
            groupBox_tool2.Controls.Add(label_y_tool2);
            groupBox_tool2.Controls.Add(label_x_tool2);
            groupBox_tool2.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox_tool2.Location = new Point(253, 31);
            groupBox_tool2.Name = "groupBox_tool2";
            groupBox_tool2.Size = new Size(169, 117);
            groupBox_tool2.TabIndex = 11;
            groupBox_tool2.TabStop = false;
            groupBox_tool2.Text = "Tool 2";
            // 
            // checkBox_tool2
            // 
            checkBox_tool2.AutoSize = true;
            checkBox_tool2.Location = new Point(86, 87);
            checkBox_tool2.Name = "checkBox_tool2";
            checkBox_tool2.Size = new Size(71, 19);
            checkBox_tool2.TabIndex = 8;
            checkBox_tool2.Text = "Enable";
            checkBox_tool2.UseVisualStyleBackColor = true;
            // 
            // comboBox_tool2
            // 
            comboBox_tool2.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox_tool2.FormattingEnabled = true;
            comboBox_tool2.Items.AddRange(new object[] { "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12", "Insert", "Home", "PageUp", "PageDown", "Delete", "End" });
            comboBox_tool2.Location = new Point(6, 84);
            comboBox_tool2.Name = "comboBox_tool2";
            comboBox_tool2.Size = new Size(74, 23);
            comboBox_tool2.TabIndex = 8;
            comboBox_tool2.Text = "F1";
            // 
            // button_pos_tool2
            // 
            button_pos_tool2.BackColor = Color.Silver;
            button_pos_tool2.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_pos_tool2.Location = new Point(39, 52);
            button_pos_tool2.Name = "button_pos_tool2";
            button_pos_tool2.Size = new Size(95, 26);
            button_pos_tool2.TabIndex = 8;
            button_pos_tool2.Text = "Get Pos";
            button_pos_tool2.UseVisualStyleBackColor = false;
            button_pos_tool2.Click += button_pos_tool2_Click;
            // 
            // label_y_tool2
            // 
            label_y_tool2.AutoSize = true;
            label_y_tool2.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_y_tool2.Location = new Point(1, 34);
            label_y_tool2.Name = "label_y_tool2";
            label_y_tool2.Size = new Size(51, 15);
            label_y_tool2.TabIndex = 9;
            label_y_tool2.Text = "pos_y: ";
            // 
            // label_x_tool2
            // 
            label_x_tool2.AutoSize = true;
            label_x_tool2.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_x_tool2.Location = new Point(1, 19);
            label_x_tool2.Name = "label_x_tool2";
            label_x_tool2.Size = new Size(51, 15);
            label_x_tool2.TabIndex = 9;
            label_x_tool2.Text = "pos_x: ";
            // 
            // groupBox_tool3
            // 
            groupBox_tool3.Controls.Add(checkBox_tool3);
            groupBox_tool3.Controls.Add(comboBox_tool3);
            groupBox_tool3.Controls.Add(button_pos_tool3);
            groupBox_tool3.Controls.Add(label_y_tool3);
            groupBox_tool3.Controls.Add(label_x_tool3);
            groupBox_tool3.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox_tool3.Location = new Point(484, 31);
            groupBox_tool3.Name = "groupBox_tool3";
            groupBox_tool3.Size = new Size(169, 117);
            groupBox_tool3.TabIndex = 12;
            groupBox_tool3.TabStop = false;
            groupBox_tool3.Text = "Tool 3";
            // 
            // checkBox_tool3
            // 
            checkBox_tool3.AutoSize = true;
            checkBox_tool3.Location = new Point(86, 87);
            checkBox_tool3.Name = "checkBox_tool3";
            checkBox_tool3.Size = new Size(71, 19);
            checkBox_tool3.TabIndex = 8;
            checkBox_tool3.Text = "Enable";
            checkBox_tool3.UseVisualStyleBackColor = true;
            // 
            // comboBox_tool3
            // 
            comboBox_tool3.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox_tool3.FormattingEnabled = true;
            comboBox_tool3.Items.AddRange(new object[] { "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12", "Insert", "Home", "PageUp", "PageDown", "Delete", "End" });
            comboBox_tool3.Location = new Point(6, 84);
            comboBox_tool3.Name = "comboBox_tool3";
            comboBox_tool3.Size = new Size(74, 23);
            comboBox_tool3.TabIndex = 8;
            comboBox_tool3.Text = "F1";
            // 
            // button_pos_tool3
            // 
            button_pos_tool3.BackColor = Color.Silver;
            button_pos_tool3.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_pos_tool3.Location = new Point(39, 52);
            button_pos_tool3.Name = "button_pos_tool3";
            button_pos_tool3.Size = new Size(95, 26);
            button_pos_tool3.TabIndex = 8;
            button_pos_tool3.Text = "Get Pos";
            button_pos_tool3.UseVisualStyleBackColor = false;
            button_pos_tool3.Click += button_pos_tool3_Click;
            // 
            // label_y_tool3
            // 
            label_y_tool3.AutoSize = true;
            label_y_tool3.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_y_tool3.Location = new Point(1, 34);
            label_y_tool3.Name = "label_y_tool3";
            label_y_tool3.Size = new Size(51, 15);
            label_y_tool3.TabIndex = 9;
            label_y_tool3.Text = "pos_y: ";
            // 
            // label_x_tool3
            // 
            label_x_tool3.AutoSize = true;
            label_x_tool3.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_x_tool3.Location = new Point(1, 19);
            label_x_tool3.Name = "label_x_tool3";
            label_x_tool3.Size = new Size(51, 15);
            label_x_tool3.TabIndex = 9;
            label_x_tool3.Text = "pos_x: ";
            // 
            // groupBox_Tools
            // 
            groupBox_Tools.BackColor = Color.DarkGray;
            groupBox_Tools.Controls.Add(groupBox_tool3);
            groupBox_Tools.Controls.Add(groupBox_tool2);
            groupBox_Tools.Controls.Add(groupBox_tool1);
            groupBox_Tools.Controls.Add(pictureBox3);
            groupBox_Tools.Font = new Font("Old Antic Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 178);
            groupBox_Tools.ForeColor = Color.Black;
            groupBox_Tools.Location = new Point(9, 409);
            groupBox_Tools.Name = "groupBox_Tools";
            groupBox_Tools.Size = new Size(667, 154);
            groupBox_Tools.TabIndex = 6;
            groupBox_Tools.TabStop = false;
            groupBox_Tools.Text = "Tools";
            // 
            // comboBox_trainer
            // 
            comboBox_trainer.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox_trainer.FormattingEnabled = true;
            comboBox_trainer.Items.AddRange(new object[] { "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12" });
            comboBox_trainer.Location = new Point(95, 44);
            comboBox_trainer.Name = "comboBox_trainer";
            comboBox_trainer.Size = new Size(44, 23);
            comboBox_trainer.TabIndex = 0;
            comboBox_trainer.Tag = "";
            comboBox_trainer.Text = "F1";
            // 
            // checkBox_Spell_Trainer
            // 
            checkBox_Spell_Trainer.AutoSize = true;
            checkBox_Spell_Trainer.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox_Spell_Trainer.Location = new Point(15, 45);
            checkBox_Spell_Trainer.Name = "checkBox_Spell_Trainer";
            checkBox_Spell_Trainer.Size = new Size(66, 22);
            checkBox_Spell_Trainer.TabIndex = 1;
            checkBox_Spell_Trainer.Text = "Spell";
            checkBox_Spell_Trainer.UseVisualStyleBackColor = true;
            // 
            // label_timer_trainer
            // 
            label_timer_trainer.AutoSize = true;
            label_timer_trainer.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_timer_trainer.Location = new Point(28, 80);
            label_timer_trainer.Name = "label_timer_trainer";
            label_timer_trainer.Size = new Size(53, 18);
            label_timer_trainer.TabIndex = 3;
            label_timer_trainer.Text = "Timer";
            // 
            // textBox_timer_trainer
            // 
            textBox_timer_trainer.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_timer_trainer.Location = new Point(95, 80);
            textBox_timer_trainer.Name = "textBox_timer_trainer";
            textBox_timer_trainer.Size = new Size(44, 23);
            textBox_timer_trainer.TabIndex = 4;
            textBox_timer_trainer.Text = "1";
            // 
            // checkBox_food_trainer
            // 
            checkBox_food_trainer.AutoSize = true;
            checkBox_food_trainer.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox_food_trainer.Location = new Point(15, 111);
            checkBox_food_trainer.Name = "checkBox_food_trainer";
            checkBox_food_trainer.Size = new Size(67, 22);
            checkBox_food_trainer.TabIndex = 5;
            checkBox_food_trainer.Text = "Food";
            checkBox_food_trainer.UseVisualStyleBackColor = true;
            // 
            // label_x_food_trainer
            // 
            label_x_food_trainer.AutoSize = true;
            label_x_food_trainer.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_x_food_trainer.Location = new Point(15, 147);
            label_x_food_trainer.Name = "label_x_food_trainer";
            label_x_food_trainer.Size = new Size(86, 15);
            label_x_food_trainer.TabIndex = 7;
            label_x_food_trainer.Text = "food_pos_x: ";
            // 
            // label_y_food_trainer
            // 
            label_y_food_trainer.AutoSize = true;
            label_y_food_trainer.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_y_food_trainer.Location = new Point(15, 162);
            label_y_food_trainer.Name = "label_y_food_trainer";
            label_y_food_trainer.Size = new Size(86, 15);
            label_y_food_trainer.TabIndex = 7;
            label_y_food_trainer.Text = "food_pos_y: ";
            // 
            // button_pos_food
            // 
            button_pos_food.BackColor = Color.Silver;
            button_pos_food.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_pos_food.Location = new Point(24, 195);
            button_pos_food.Name = "button_pos_food";
            button_pos_food.Size = new Size(95, 26);
            button_pos_food.TabIndex = 7;
            button_pos_food.Text = "Get Pos";
            button_pos_food.UseVisualStyleBackColor = false;
            button_pos_food.Click += button_pos_food_Click;
            // 
            // groupBox_Trainer
            // 
            groupBox_Trainer.BackColor = Color.DarkGray;
            groupBox_Trainer.Controls.Add(button_pos_food);
            groupBox_Trainer.Controls.Add(label_y_food_trainer);
            groupBox_Trainer.Controls.Add(label_x_food_trainer);
            groupBox_Trainer.Controls.Add(checkBox_food_trainer);
            groupBox_Trainer.Controls.Add(textBox_timer_trainer);
            groupBox_Trainer.Controls.Add(label_timer_trainer);
            groupBox_Trainer.Controls.Add(checkBox_Spell_Trainer);
            groupBox_Trainer.Controls.Add(comboBox_trainer);
            groupBox_Trainer.Font = new Font("Old Antic Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 178);
            groupBox_Trainer.ForeColor = Color.Black;
            groupBox_Trainer.Location = new Point(269, 159);
            groupBox_Trainer.Name = "groupBox_Trainer";
            groupBox_Trainer.Size = new Size(152, 227);
            groupBox_Trainer.TabIndex = 7;
            groupBox_Trainer.TabStop = false;
            groupBox_Trainer.Text = "Trainer";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.DarkGray;
            tabPage2.Controls.Add(groupBox_save_load);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(690, 576);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Setup";
            // 
            // groupBox_save_load
            // 
            groupBox_save_load.Controls.Add(button_load);
            groupBox_save_load.Controls.Add(button_save);
            groupBox_save_load.Location = new Point(25, 103);
            groupBox_save_load.Name = "groupBox_save_load";
            groupBox_save_load.Size = new Size(643, 68);
            groupBox_save_load.TabIndex = 0;
            groupBox_save_load.TabStop = false;
            groupBox_save_load.Text = "Save and Load";
            // 
            // button_load
            // 
            button_load.BackColor = Color.Silver;
            button_load.Location = new Point(407, 22);
            button_load.Name = "button_load";
            button_load.Size = new Size(90, 31);
            button_load.TabIndex = 1;
            button_load.Text = "Load";
            button_load.UseVisualStyleBackColor = false;
            button_load.Click += button_load_Click;
            // 
            // button_save
            // 
            button_save.BackColor = Color.Silver;
            button_save.Location = new Point(134, 22);
            button_save.Name = "button_save";
            button_save.Size = new Size(90, 31);
            button_save.TabIndex = 0;
            button_save.Text = "Save";
            button_save.UseVisualStyleBackColor = false;
            button_save.Click += button_save_Click;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.DarkGray;
            tabPage1.Controls.Add(groupBox_Tools);
            tabPage1.Controls.Add(groupBox_Trainer);
            tabPage1.Controls.Add(groupBox_Healing);
            tabPage1.Controls.Add(groupBox_Targeting);
            tabPage1.Controls.Add(groupBox_light);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(690, 576);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Bot";
            // 
            // groupBox_Healing
            // 
            groupBox_Healing.BackColor = Color.DarkGray;
            groupBox_Healing.Controls.Add(pictureBox1);
            groupBox_Healing.Controls.Add(comboBox_healing);
            groupBox_Healing.Controls.Add(checkBox_healing);
            groupBox_Healing.Controls.Add(label_uh_y_healing);
            groupBox_Healing.Controls.Add(label_uh_x_healing);
            groupBox_Healing.Controls.Add(button_pos_healing);
            groupBox_Healing.Controls.Add(label_char_y_healing);
            groupBox_Healing.Controls.Add(label_char_x_healing);
            groupBox_Healing.Font = new Font("Old Antic Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 178);
            groupBox_Healing.ForeColor = Color.Black;
            groupBox_Healing.Location = new Point(8, 89);
            groupBox_Healing.Name = "groupBox_Healing";
            groupBox_Healing.Size = new Size(236, 297);
            groupBox_Healing.TabIndex = 4;
            groupBox_Healing.TabStop = false;
            groupBox_Healing.Text = "Healing";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.Silver_Rune_Emblem__Ultimate_Healing_;
            pictureBox1.Location = new Point(84, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 30);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // comboBox_healing
            // 
            comboBox_healing.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox_healing.FormattingEnabled = true;
            comboBox_healing.Items.AddRange(new object[] { "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12", "Insert", "Home", "PageUp", "PageDown", "Delete", "End" });
            comboBox_healing.Location = new Point(7, 156);
            comboBox_healing.Name = "comboBox_healing";
            comboBox_healing.Size = new Size(74, 23);
            comboBox_healing.TabIndex = 6;
            comboBox_healing.Text = "F1";
            // 
            // checkBox_healing
            // 
            checkBox_healing.AutoSize = true;
            checkBox_healing.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox_healing.Location = new Point(87, 158);
            checkBox_healing.Name = "checkBox_healing";
            checkBox_healing.Size = new Size(71, 19);
            checkBox_healing.TabIndex = 5;
            checkBox_healing.Text = "Enable";
            checkBox_healing.UseVisualStyleBackColor = true;
            // 
            // label_uh_y_healing
            // 
            label_uh_y_healing.AutoSize = true;
            label_uh_y_healing.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_uh_y_healing.Location = new Point(7, 78);
            label_uh_y_healing.Name = "label_uh_y_healing";
            label_uh_y_healing.Size = new Size(74, 15);
            label_uh_y_healing.TabIndex = 4;
            label_uh_y_healing.Text = "uh_pos_y: ";
            // 
            // label_uh_x_healing
            // 
            label_uh_x_healing.AutoSize = true;
            label_uh_x_healing.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_uh_x_healing.Location = new Point(7, 63);
            label_uh_x_healing.Name = "label_uh_x_healing";
            label_uh_x_healing.Size = new Size(74, 15);
            label_uh_x_healing.TabIndex = 3;
            label_uh_x_healing.Text = "uh_pos_x: ";
            // 
            // button_pos_healing
            // 
            button_pos_healing.BackColor = Color.Silver;
            button_pos_healing.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_pos_healing.Location = new Point(61, 106);
            button_pos_healing.Name = "button_pos_healing";
            button_pos_healing.Size = new Size(95, 26);
            button_pos_healing.TabIndex = 2;
            button_pos_healing.Text = "Get Pos";
            button_pos_healing.UseVisualStyleBackColor = false;
            button_pos_healing.Click += button_pos_healing_Click;
            // 
            // label_char_y_healing
            // 
            label_char_y_healing.AutoSize = true;
            label_char_y_healing.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_char_y_healing.Location = new Point(7, 48);
            label_char_y_healing.Name = "label_char_y_healing";
            label_char_y_healing.Size = new Size(88, 15);
            label_char_y_healing.TabIndex = 1;
            label_char_y_healing.Text = "char_pos_y: ";
            // 
            // label_char_x_healing
            // 
            label_char_x_healing.AutoSize = true;
            label_char_x_healing.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_char_x_healing.Location = new Point(7, 33);
            label_char_x_healing.Name = "label_char_x_healing";
            label_char_x_healing.Size = new Size(88, 15);
            label_char_x_healing.TabIndex = 0;
            label_char_x_healing.Text = "char_pos_x: ";
            // 
            // groupBox_Targeting
            // 
            groupBox_Targeting.BackColor = Color.DarkGray;
            groupBox_Targeting.Controls.Add(checkBox_targeting);
            groupBox_Targeting.Controls.Add(comboBox_targeting);
            groupBox_Targeting.Controls.Add(button_targeting);
            groupBox_Targeting.Controls.Add(label_y_targeting);
            groupBox_Targeting.Controls.Add(label_x_targeting);
            groupBox_Targeting.Controls.Add(pictureBox2);
            groupBox_Targeting.Font = new Font("Old Antic Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 178);
            groupBox_Targeting.ForeColor = Color.Black;
            groupBox_Targeting.Location = new Point(438, 89);
            groupBox_Targeting.Name = "groupBox_Targeting";
            groupBox_Targeting.Size = new Size(238, 297);
            groupBox_Targeting.TabIndex = 5;
            groupBox_Targeting.TabStop = false;
            groupBox_Targeting.Text = "Targeting";
            // 
            // checkBox_targeting
            // 
            checkBox_targeting.AutoSize = true;
            checkBox_targeting.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox_targeting.Location = new Point(86, 136);
            checkBox_targeting.Name = "checkBox_targeting";
            checkBox_targeting.Size = new Size(71, 19);
            checkBox_targeting.TabIndex = 8;
            checkBox_targeting.Text = "Enable";
            checkBox_targeting.UseVisualStyleBackColor = true;
            // 
            // comboBox_targeting
            // 
            comboBox_targeting.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox_targeting.FormattingEnabled = true;
            comboBox_targeting.Items.AddRange(new object[] { "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12", "Insert", "Home", "PageUp", "PageDown", "Delete", "End" });
            comboBox_targeting.Location = new Point(6, 134);
            comboBox_targeting.Name = "comboBox_targeting";
            comboBox_targeting.Size = new Size(74, 23);
            comboBox_targeting.TabIndex = 8;
            comboBox_targeting.Text = "F1";
            // 
            // button_targeting
            // 
            button_targeting.BackColor = Color.Silver;
            button_targeting.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_targeting.Location = new Point(72, 78);
            button_targeting.Name = "button_targeting";
            button_targeting.Size = new Size(95, 26);
            button_targeting.TabIndex = 8;
            button_targeting.Text = "Get Pos";
            button_targeting.UseVisualStyleBackColor = false;
            button_targeting.Click += button_targeting_Click;
            // 
            // label_y_targeting
            // 
            label_y_targeting.AutoSize = true;
            label_y_targeting.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_y_targeting.Location = new Point(6, 48);
            label_y_targeting.Name = "label_y_targeting";
            label_y_targeting.Size = new Size(51, 15);
            label_y_targeting.TabIndex = 5;
            label_y_targeting.Text = "pos_y: ";
            // 
            // label_x_targeting
            // 
            label_x_targeting.AutoSize = true;
            label_x_targeting.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_x_targeting.Location = new Point(6, 33);
            label_x_targeting.Name = "label_x_targeting";
            label_x_targeting.Size = new Size(51, 15);
            label_x_targeting.TabIndex = 4;
            label_x_targeting.Text = "pos_x: ";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Sudden_Death_Rune;
            pictureBox2.Location = new Point(99, -2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 30);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // groupBox_light
            // 
            groupBox_light.BackColor = Color.DarkGray;
            groupBox_light.Controls.Add(checkBox_light);
            groupBox_light.ForeColor = Color.Black;
            groupBox_light.Location = new Point(290, 92);
            groupBox_light.Name = "groupBox_light";
            groupBox_light.Size = new Size(98, 61);
            groupBox_light.TabIndex = 2;
            groupBox_light.TabStop = false;
            // 
            // checkBox_light
            // 
            checkBox_light.AutoSize = true;
            checkBox_light.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox_light.Location = new Point(15, 23);
            checkBox_light.Name = "checkBox_light";
            checkBox_light.Size = new Size(67, 22);
            checkBox_light.TabIndex = 1;
            checkBox_light.Text = "Light";
            checkBox_light.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(-4, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(698, 604);
            tabControl1.TabIndex = 8;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(688, 601);
            Controls.Add(groupBox_Title);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RoseTibiaBot";
            groupBox_Title.ResumeLayout(false);
            groupBox_Title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox_tool1.ResumeLayout(false);
            groupBox_tool1.PerformLayout();
            groupBox_tool2.ResumeLayout(false);
            groupBox_tool2.PerformLayout();
            groupBox_tool3.ResumeLayout(false);
            groupBox_tool3.PerformLayout();
            groupBox_Tools.ResumeLayout(false);
            groupBox_Trainer.ResumeLayout(false);
            groupBox_Trainer.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBox_save_load.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox_Healing.ResumeLayout(false);
            groupBox_Healing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox_Targeting.ResumeLayout(false);
            groupBox_Targeting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox_light.ResumeLayout(false);
            groupBox_light.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label Title;
        private System.Windows.Forms.Timer timer_light;
        private GroupBox groupBox_Title;
        private System.Windows.Forms.Timer timer_spell_trainer;
        private System.Windows.Forms.Timer timer_healing;
        private System.Windows.Forms.Timer timer_food;
        private System.Windows.Forms.Timer timer_targeting;
        private System.Windows.Forms.Timer timer_tool1;
        private System.Windows.Forms.Timer timer_tool2;
        private System.Windows.Forms.Timer timer_tool3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private GroupBox groupBox_tool1;
        private ComboBox comboBox_tool1;
        private Button button_pos_tool1;
        private Label label_y_tool1;
        private Label label_x_tool1;
        private CheckBox checkBox_tool1;
        private GroupBox groupBox_tool2;
        private CheckBox checkBox_tool2;
        private ComboBox comboBox_tool2;
        private Button button_pos_tool2;
        private Label label_y_tool2;
        private Label label_x_tool2;
        private GroupBox groupBox_tool3;
        private CheckBox checkBox_tool3;
        private ComboBox comboBox_tool3;
        private Button button_pos_tool3;
        private Label label_y_tool3;
        private Label label_x_tool3;
        private GroupBox groupBox_Tools;
        private ComboBox comboBox_trainer;
        private CheckBox checkBox_Spell_Trainer;
        private Label label_timer_trainer;
        private TextBox textBox_timer_trainer;
        private CheckBox checkBox_food_trainer;
        private Label label_x_food_trainer;
        private Label label_y_food_trainer;
        private Button button_pos_food;
        private GroupBox groupBox_Trainer;
        private TabPage tabPage2;
        private GroupBox groupBox_save_load;
        private TabPage tabPage1;
        private GroupBox groupBox_Healing;
        private PictureBox pictureBox1;
        private ComboBox comboBox_healing;
        private CheckBox checkBox_healing;
        private Label label_uh_y_healing;
        private Label label_uh_x_healing;
        private Button button_pos_healing;
        private Label label_char_y_healing;
        private Label label_char_x_healing;
        private GroupBox groupBox_Targeting;
        private CheckBox checkBox_targeting;
        private ComboBox comboBox_targeting;
        private Button button_targeting;
        private Label label_y_targeting;
        private Label label_x_targeting;
        private PictureBox pictureBox2;
        private GroupBox groupBox_light;
        private CheckBox checkBox_light;
        private TabControl tabControl1;
        private Button button_save;
        private Button button_load;
    }
}
