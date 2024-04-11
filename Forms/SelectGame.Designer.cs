namespace RoseTibiaBot
{
    partial class SelectGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectGame));
            label_Select = new Label();
            pictureBox_button = new PictureBox();
            label_title = new Label();
            pictureBox1 = new PictureBox();
            comboBox_select = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox_button).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label_Select
            // 
            label_Select.AutoSize = true;
            label_Select.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Select.Location = new Point(29, 96);
            label_Select.Name = "label_Select";
            label_Select.Size = new Size(238, 22);
            label_Select.TabIndex = 0;
            label_Select.Text = "Select the Game Window";
            // 
            // pictureBox_button
            // 
            pictureBox_button.Cursor = Cursors.Hand;
            pictureBox_button.Image = Properties.Resources.button_start;
            pictureBox_button.Location = new Point(102, 173);
            pictureBox_button.Name = "pictureBox_button";
            pictureBox_button.Size = new Size(92, 44);
            pictureBox_button.TabIndex = 2;
            pictureBox_button.TabStop = false;
            pictureBox_button.Click += pictureBox_button_Click;
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.Font = new Font("Algerian", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_title.Location = new Point(46, 9);
            label_title.Name = "label_title";
            label_title.Size = new Size(203, 26);
            label_title.TabIndex = 3;
            label_title.Text = "Rose Tibia Bot";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(127, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 43);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // comboBox_select
            // 
            comboBox_select.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_select.FormattingEnabled = true;
            comboBox_select.Location = new Point(10, 133);
            comboBox_select.Name = "comboBox_select";
            comboBox_select.Size = new Size(276, 23);
            comboBox_select.TabIndex = 5;
            // 
            // SelectGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(298, 247);
            Controls.Add(comboBox_select);
            Controls.Add(pictureBox1);
            Controls.Add(label_title);
            Controls.Add(pictureBox_button);
            Controls.Add(label_Select);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "SelectGame";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RoseTibiaBot";
            ((System.ComponentModel.ISupportInitialize)pictureBox_button).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Select;
        private PictureBox pictureBox_button;
        private Label label_title;
        private PictureBox pictureBox1;
        private ComboBox comboBox_select;
    }
}