using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CC_WinFromsIntro_Lesson16
{
    public partial class RegistrationForm : Form
    {
        public static int Counter { get; set; }
        public static User[] Users { get; set; }

        static RegistrationForm()
        {
            Users = new User[20];
        }
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("hey again from 'click' method");
            User newUser = new User();
            newUser.Email = txbMail.Text;
            newUser.Password = txbPsw.Text;//"*****"
            newUser.BirthDate = dtpBrthDay.Value;
            newUser.IsVeg = chxIsVeg.Checked;
            string genderValue = "";
            foreach (RadioButton rdb in pnlRdbGender.Controls)
            {
                if (rdb.Checked)
                    genderValue = rdb.Text;
            }
            GenderTypes gndrTyps = (GenderTypes)Enum.Parse(typeof(GenderTypes), genderValue, false);
            newUser.Gender = gndrTyps;

            Users[Counter] = newUser;//0
            Counter++;//1
            MessageBox.Show("המשתמש נוסף בהצלחה!");

            txbMail.Text = "";
            txbPsw.Text = "";
            chxIsVeg.Checked = false;
            dtpBrthDay.Value = DateTime.Now;
            RdbNotSet.Checked = true;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //im here but im free
            // tell t to do the work
            Thread t = new Thread(() =>
            {
                btn1.BackColor = Color.Black;//send to ui-thread
                Thread.Sleep(500);
                btn2.BackColor = Color.Red;
                Thread.Sleep(1000);
                btn3.BackColor = Color.Green;
                Thread.Sleep(1500);
                btn4.BackColor = Color.Blue;
                Thread.Sleep(2000);
            });

            t.Start();
        }
    }
}
