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
        

        //Varibels with "S_" befroe it are string. this is so not to confuse simmarly named varibles.
        private void BtnAddEducation_Click(object sender, EventArgs e)
        {
            string S_Education = tbxEducation.Text;

            Info MyNewInfo = new Info() { HaveStudiedOn = S_Education };

            MyInfo.Infoes.Add(MyNewInfo);

            MyInfo.SaveChanges();
        }

        private void btnAddExperience_Click(object sender, EventArgs e)
        {
            string S_Experisence = tbxExperience.Text;

            Info MyNewInfo = new Info() { Expirience = S_Experisence };

            MyInfo.Infoes.Add(MyNewInfo);

            MyInfo.SaveChanges();
        }

        private void BtnAddKnowlege_Click(object sender, EventArgs e)
        {
            string S_Knowlege = tbxKnowlege.Text;

            Info MyNewInfo = new Info() { Knowlege = S_Knowlege };

            MyInfo.Infoes.Add(MyNewInfo);

            MyInfo.SaveChanges();
        }
    }
}
