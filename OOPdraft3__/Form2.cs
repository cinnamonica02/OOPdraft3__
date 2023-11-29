using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.MdiParent = this.MdiParent;
            form.Controls["nameLabel2"].Text = nameTextBox1.Text;
            form.Controls["lastNameLabel2"].Text = lastNameTextBox1.Text;
            form.Controls["fatherNameLabel2"].Text = fatherNameTextBox1.Text;
            form.Controls["dobLabel2"].Text = dateofBirthtextBox1.Text;
            form.Controls["joinDateLabel2"].Text = joinDateTextBox1.Text;
            form.Controls["nationalityLabel2"].Text = nationalityTextBox1.Text;


            form.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
