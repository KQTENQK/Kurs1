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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string username = inputUsername.Text;
            string password = inputPassword.Text;

            using (var context = new UserDataContext())
            {
                var users = context.Users.Where(user => user.Username == username && user.Password == password);
                if (users.Count() > 0)
                {
                    var client = users.FirstOrDefault();
                    User currentUser = new User()
                    {
                        Username = client.Username
                    };

                    switch (client.UserType)
                    {
                        case "user":
                            new UserPanel().Show();
                            Hide();
                            break;
                        case "administrator":
                            new AdminPanel(currentUser).Show();
                            Hide();
                            break;
                        case "moderator":
                            new ModeratorPanel().Show();
                            Hide();
                            break;
                        default:
                            new UserDoesNotExitst().ShowDialog();
                            break;
                    }
                }
                else
                {
                    new UserDoesNotExitst().ShowDialog();
                }
            }

        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            new SignUp().ShowDialog();
        }
    }
}
