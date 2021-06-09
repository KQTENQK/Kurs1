using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursovayaaaaa
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            string username = inputUsername.Text;
            string userpassword = inputPassword.Text;
            string userType = "user";
            if (username != null && userpassword != null)
            {
                using (var context = new UserDataContext())
                {
                    var existingUsers = context.Users.Where(existingUser => existingUser.Username == username);
                    if (existingUsers.Count() > 0)
                    {
                        new UserAlreadyExists().ShowDialog();
                    }
                    else
                    {
                        var user = new User()
                        {
                            Username = username,
                            Password = userpassword,
                            UserType = userType
                        };

                        context.Users.Add(user);
                        context.SaveChanges();

                        new SuccessfullSignUp().ShowDialog();
                        Close();
                    }
                }
            }
            else
            {
                new InvalidSignUpData().ShowDialog();
            }
        }
    }
}
