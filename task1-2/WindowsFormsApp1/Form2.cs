using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        string mode = "ceasar";

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public string ReturnData()
        {
            return mode;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            mode = "ceasar";

            this.DialogResult = DialogResult.OK;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            mode = "visioner";

            this.DialogResult = DialogResult.OK;

        }
    }
}
