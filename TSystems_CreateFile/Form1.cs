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

namespace TSystems_CreateFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = @"F:\Test";

            if (Directory.Exists(path))
            {
                MessageBox.Show("folder is already exixts");
            }
            else
            {
                Directory.CreateDirectory(path);
                MessageBox.Show("Created");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            string path = @"F:\Test\Testfile.txt";

            if (File.Exists(path))
            {
                MessageBox.Show("Already exists");
            }
            else
            {
                File.Create(path);
                MessageBox.Show("Created");
            }
        }
    }
}
