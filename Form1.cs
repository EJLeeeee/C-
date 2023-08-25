using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01BASIC
{
    public partial class winform : Form
    {

        
        public winform()
        {
            InitializeComponent();
        }

        private void PortNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;         
        }

        private void conn_btn_Click(object sender, EventArgs e)
        {
            Console.WriteLine(this.PortNumber.Items[this.PortNumber.SelectedIndex].ToString()+" CONN");
            label2.Text = this.PortNumber.Items[this.PortNumber.SelectedIndex].ToString() + " CONN";
        }



        private void winform_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("LED_01 ON CLICKED");
            label2.Text = "LED_01 ON SUCCESS";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("LED_01 OFF CLICKED");
            label2.Text = "LED_01 OFF SUCCESS";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Console.WriteLine("LED_02 ON CLICKED");
            label2.Text = "LED_02 ON SUCCESS";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Console.WriteLine("LED_02 OFF CLICKED");
            label2.Text = "LED_02 OFF SUCCESS";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
