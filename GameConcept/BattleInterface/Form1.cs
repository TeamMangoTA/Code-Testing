using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleInterface
{
    public partial class Form1 : Form
    {
        public int Result = -1;
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(string stats1,string stats2, string[] options, string filepath)
        {
            InitializeComponent();

            this.pictureBox1.Load(filepath);
            this.label1.Text = stats1+"\n"+stats2;

            foreach (var item in options)
            {
                this.comboBox1.Items.Add(item);
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Result = this.comboBox1.SelectedIndex;
            this.Close();
        }
    }
}
