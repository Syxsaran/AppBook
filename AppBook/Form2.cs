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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            string strAboutUser, strAboutBook;
            strAboutUser = "";
            if (radioButtonBoy.Checked == true)
            {
                strAboutUser = "นาย " + textBoxName.Text;
            }
            if (radioButtonGirl.Checked == true)
            {
                strAboutUser = "นาง/นางสาว" + textBoxName.Text;
            }
            strAboutUser += "\r\n\nวัน/เดือน/ปี : " + comboBoxDay.Text + comboBoxMonth.Text + comboBoxYears.Text;
            if (checkBoxStaff.Checked == true)
            {
                strAboutUser += "\r\n\nคุณเป็น : Staff";
            }
            if (checkBoxTeacher.Checked == true)
            {
                strAboutUser += "\r\n\nคุณเป็น : Teacher";
            }
            if (checkBoxStudent.Checked == true)
            {
                strAboutUser += "\r\n\nคุณเป็น : Student";
            }
            strAboutUser += "\r\n\nอีเมล : " + textBoxMail.Text;
            strAboutUser += "\r\n\nเบอร์ติดต่อ : " + textBoxPhoneNumber.Text;
            textBoxAboutUser.Text = strAboutUser;
            strAboutBook = "หนังสือที่คุณยืมมี\r\n";
            if (checkBoxBook1.Checked = true)
            {
                strAboutBook += "Book1\r\n";
            }
            if (checkBoxBook2.Checked = true)
            {
                strAboutBook += "Book2\r\n";
            }
            if (checkBoxBook3.Checked = true)
            {
                strAboutBook += "Book3\r\n";
            }
            if (checkBoxBook4.Checked = true)
            {
                strAboutBook += "Book4\r\n";
            }
            if (checkBoxBook5.Checked = true)
            {
                strAboutBook += "Book5\r\n";
            }
            if (checkBoxBook6.Checked = true)
            {
                strAboutBook += "Book6\r\n";
            }
            if (checkBoxBook7.Checked = true)
            {
                strAboutBook += "Book7\r\n";
            }
            if (checkBoxBook8.Checked = true)
            {
                strAboutBook += "Book8\r\n";
            }
            if (checkBoxBook9.Checked = true)
            {
                strAboutBook += "Book9\r\n";
            }
            if (checkBoxBook10.Checked = true)
            {
                strAboutBook += "Book10\r\n";
            }
            if (checkBoxBook11.Checked = true)
            {
                strAboutBook += "Book11\r\n";
            }
            if (checkBoxBook12.Checked = true)
            {
                strAboutBook += "Book12\r\n";
            }
            if (checkBoxBook13.Checked = true)
            {
                strAboutBook += "Book13\r\n";
            }
            if (checkBoxBook14.Checked = true)
            {
                strAboutBook += "Book14\r\n";
            }
            if (checkBoxBook15.Checked = true)
            {
                strAboutBook += "Book15\r\n";
            }
            if (checkBoxBook16.Checked = true)
            {
                strAboutBook += "Book16\r\n";
            }
            if (checkBoxBook17.Checked = true)
            {
                strAboutBook += "Book17\r\n";
            }
            if (checkBoxBook18.Checked = true)
            {
                strAboutBook += "Book18\r\n";
            }
            if (checkBoxBook19.Checked = true)
            {
                strAboutBook += "Book19\r\n";
            }
            if (checkBoxBook20.Checked = true)
            {
                strAboutBook += "Book20\r\n";
            }
            textBoxAboutBook.Text = strAboutBook;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ขอบคุณที่ใช้บริการครับ");
            Close();
        }
    }
}
