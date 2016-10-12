using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_prodject
{
    public partial class Form1 : Form
    {
        WebDataBaseEntities4 MyInfo = new WebDataBaseEntities4();
        public Form1()
        {
            InitializeComponent();
            foreach (var item in MyInfo.Infoes)
            {
                listBox1.Items.Add(item);
            }
            listBox1.DisplayMember = "HaveStudiedOn";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var item in MyInfo.Infoes)
            {
                listBox1.Items.Add(item);
            }
            listBox1.DisplayMember = "HaveStudiedOn";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var item in MyInfo.Infoes)
            {
                listBox1.Items.Add(item);
            }
            listBox1.DisplayMember = "Expirience";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var item in MyInfo.Infoes)
            {
                listBox1.Items.Add(item);
            }
            listBox1.DisplayMember = "Knowlege";
        }
    }
}
