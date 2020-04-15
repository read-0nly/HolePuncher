using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolePuncher
{
    public partial class Form1 : Form
    {
        ConnectionManager cm = new ConnectionManager();
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = cm.Endpoint.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cm.sendString("Follow the white rabbit", textBox2.Text.Trim());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = Encoding.ASCII.GetString(cm.receiveBytes());
        }

        private void button3_Click(object sender, EventArgs e){        
            cm.sendString("Follow the white rabbit", textBox1.Text.Trim());
            textBox3.Text = Encoding.ASCII.GetString(cm.receiveBytes());
        }
    }
}
