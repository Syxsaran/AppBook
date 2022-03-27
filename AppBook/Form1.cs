namespace AppBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            /// staff
            if (textBoxUser.Text == "Staff" && textBoxPassword.Text == "1234")
            {
                Visible = false;
                FormStaff formstaff = new FormStaff();
                formstaff.Visible = true;
            }
            else if (textBoxUser.Text != "Staff" && textBoxPassword.Text != "1234")
            {
                this.label4.Text = "กรุณากรอกใหม่";
                textBoxPassword.Text = "";
                textBoxUser.Text = "";
            }
            /// teacher
            if (textBoxUser.Text == "Teacher" && textBoxPassword.Text == "1234")
            {
                Visible = false;
                Form2 form2 = new Form2();
                form2.Visible = true;
            }
            else if (textBoxUser.Text != "Teacher" && textBoxPassword.Text != "1234")
            {
                this.label4.Text = "กรุณากรอกใหม่";
                textBoxPassword.Text = "";
                textBoxUser.Text = "";
            }
            /// student
            if (textBoxUser.Text == "Student" && textBoxPassword.Text == "1234")
            {
                Visible = false;
                Form2 form2 = new Form2();
                form2.Visible = true;
            }
            else if (textBoxUser.Text != "Student" && textBoxPassword.Text != "1234")
            {
                this.label4.Text = "กรุณากรอกใหม่";
                textBoxPassword.Text = "";
                textBoxUser.Text = "";
            }

        }

        private void buttonlogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ขอบคุณที่ใช้บริการครับ");
            Close();
        }
    }
}