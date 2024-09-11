using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SaveKeyy
{
    public partial class Form1 : Form
    {
        public const string fileName = "C:\\\\NoMoreLife.js";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("C:\\\\NoMoreLife.js"))
            {
                this.textBox1.Text = File.ReadAllText("C:\\\\NoMoreLife.js");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextWriter textWriter = new StreamWriter("C:\\\\NoMoreLife.js");
            textWriter.Write(this.textBox1.Text);
            textWriter.Close();
        }
    }
}
