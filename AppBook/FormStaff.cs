using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBook
{
    public partial class FormStaff : Form
    {
        public FormStaff()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            label5.Text = "เพิ่มสมาชิกเรียบร้อย";
            label6.Text = textBoxAddUser.Text;
            label7.Text = textBoxAddUser.Text;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Visible = false;
            Form2 form2 = new Form2();
            form2.Visible = true;
        }
    }
}
