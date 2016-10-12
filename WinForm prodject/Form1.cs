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
        WebDataBaseEntities MyEduaction = new WebDataBaseEntities();
        public Form1()
        {
            InitializeComponent();
            foreach (var item in MyEduaction.Educations)
            {
                listBox1.Items.Add(item);
                listBox1.DisplayMember = "HaveStudiedOn";
            }
        }

    }
}
