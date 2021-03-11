using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogHelper;

namespace JsonReaderDemo
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GlobalValue.syslog.AddTrack("button1_Click", "Begin");
            JsonReader jr = new JsonReader(textBox1.Text);
            GlobalValue.syslog.AddTrack("button1_Click", "End");


        }
    }
}
