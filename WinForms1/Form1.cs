using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms1.Properties;

namespace WinForms1
{
    public partial class Form1 : Form
    {
        private bool debug = false;
        private Button buttonBeep = new Button();

        public Form1()
        {
            InitializeComponent();

            buttonBeep.Location = new Point(30, 300);
            buttonBeep.Name = "buttonBeep";
            buttonBeep.Size = new Size(100, 30);
            buttonBeep.Text = "Beep!";
            buttonBeep.Click += buttonBeep_Click;

            Controls.Add(buttonBeep);

            comboBoxWeapons.SelectedItem = "Sword";
            comboBoxWeapons.Items.Add("Mace");

            timerAnim.Tick += TimerTick;
        }

        private void TimerTick(object sender, EventArgs e)
        {
            Image[] images = new Image[] { Resources.blue, Resources.green,
                                            Resources.pink, Resources.red };

            picCrew.Image = images[new Random().Next(images.Length)];
        }

        private void buttonBeep_Click(object sender, EventArgs e)
        {
            Console.Beep(400, 100);
        }

        private void buttonWelcome_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, World!");
        }

        private void checkBoxDebug_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.Checked)
            {
                debug = true;
                Console.WriteLine("Checked");
            }
            else
            {
                debug = false;
            }
        }

        private void comboBoxWeapons_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxWeapons.SelectedIndex;
            object selected = comboBoxWeapons.SelectedItem;

            if (debug)
            {
                Console.WriteLine($"{index} - {selected.ToString()}");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Console.WriteLine(sender.ToString());
        }

        private void rbDifficulty_CheckChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked) Console.WriteLine(rb.Text);
        }

        private void picCrew_Click(object sender, EventArgs e)
        {
            Image[] images = new Image[] { Resources.blue, Resources.green, 
                                            Resources.pink, Resources.red };
            
            PictureBox pic = sender as PictureBox;
            pic.Image = images[new Random().Next(images.Length)];
        }
    }
}
