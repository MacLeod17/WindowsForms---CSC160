namespace WinForms1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonWelcome = new System.Windows.Forms.Button();
            this.checkBoxDebug = new System.Windows.Forms.CheckBox();
            this.comboBoxWeapons = new System.Windows.Forms.ComboBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.difficulty = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.picCrew = new System.Windows.Forms.PictureBox();
            this.timerAnim = new System.Windows.Forms.Timer(this.components);
            this.difficulty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCrew)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonWelcome
            // 
            this.buttonWelcome.Location = new System.Drawing.Point(304, 351);
            this.buttonWelcome.Name = "buttonWelcome";
            this.buttonWelcome.Size = new System.Drawing.Size(186, 42);
            this.buttonWelcome.TabIndex = 0;
            this.buttonWelcome.Text = "Welcome";
            this.toolTip.SetToolTip(this.buttonWelcome, "This is the Welcome button\r\n");
            this.buttonWelcome.UseVisualStyleBackColor = true;
            this.buttonWelcome.Click += new System.EventHandler(this.buttonWelcome_Click);
            // 
            // checkBoxDebug
            // 
            this.checkBoxDebug.AutoSize = true;
            this.checkBoxDebug.Location = new System.Drawing.Point(304, 308);
            this.checkBoxDebug.Name = "checkBoxDebug";
            this.checkBoxDebug.Size = new System.Drawing.Size(72, 21);
            this.checkBoxDebug.TabIndex = 1;
            this.checkBoxDebug.Text = "Debug";
            this.checkBoxDebug.UseVisualStyleBackColor = true;
            this.checkBoxDebug.CheckedChanged += new System.EventHandler(this.checkBoxDebug_CheckedChanged);
            // 
            // comboBoxWeapons
            // 
            this.comboBoxWeapons.FormattingEnabled = true;
            this.comboBoxWeapons.Items.AddRange(new object[] {
            "Sword",
            "Wand",
            "Grenade",
            "Staff"});
            this.comboBoxWeapons.Location = new System.Drawing.Point(304, 214);
            this.comboBoxWeapons.Name = "comboBoxWeapons";
            this.comboBoxWeapons.Size = new System.Drawing.Size(121, 24);
            this.comboBoxWeapons.TabIndex = 2;
            this.comboBoxWeapons.SelectedIndexChanged += new System.EventHandler(this.comboBoxWeapons_SelectedIndexChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(60, 21);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Easy";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            this.radioButton1.Enter += new System.EventHandler(this.rbDifficulty_CheckChanged);
            // 
            // difficulty
            // 
            this.difficulty.Controls.Add(this.radioButton3);
            this.difficulty.Controls.Add(this.radioButton2);
            this.difficulty.Controls.Add(this.radioButton1);
            this.difficulty.Location = new System.Drawing.Point(527, 99);
            this.difficulty.Name = "difficulty";
            this.difficulty.Size = new System.Drawing.Size(200, 100);
            this.difficulty.TabIndex = 4;
            this.difficulty.TabStop = false;
            this.difficulty.Text = "Difficulty";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 46);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(78, 21);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Medium";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Enter += new System.EventHandler(this.rbDifficulty_CheckChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 73);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(94, 21);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Nightmare";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Enter += new System.EventHandler(this.rbDifficulty_CheckChanged);
            // 
            // picCrew
            // 
            this.picCrew.Image = global::WinForms1.Properties.Resources.green;
            this.picCrew.Location = new System.Drawing.Point(36, 27);
            this.picCrew.Name = "picCrew";
            this.picCrew.Size = new System.Drawing.Size(203, 211);
            this.picCrew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCrew.TabIndex = 5;
            this.picCrew.TabStop = false;
            this.picCrew.Click += new System.EventHandler(this.picCrew_Click);
            // 
            // timerAnim
            // 
            this.timerAnim.Enabled = true;
            this.timerAnim.Interval = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picCrew);
            this.Controls.Add(this.difficulty);
            this.Controls.Add(this.comboBoxWeapons);
            this.Controls.Add(this.checkBoxDebug);
            this.Controls.Add(this.buttonWelcome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.difficulty.ResumeLayout(false);
            this.difficulty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCrew)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonWelcome;
        private System.Windows.Forms.CheckBox checkBoxDebug;
        private System.Windows.Forms.ComboBox comboBoxWeapons;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox difficulty;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.PictureBox picCrew;
        private System.Windows.Forms.Timer timerAnim;
    }
}

