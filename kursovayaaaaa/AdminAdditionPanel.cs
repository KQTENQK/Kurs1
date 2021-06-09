using System;
using System.Windows.Forms;

namespace kursovayaaaaa
{
    public partial class AdminAdditionPanel : Form
    {
        public AdminAdditionPanel()
        {
            InitializeComponent();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            string username = inputUsername.Text;
            string password = inputPassword.Text;
            string userType = inputUserType.Text;

            if (username != null && password != null && userType != null)
            {
                if (userType == "administrator" || userType == "moderator" || userType == "user")
                {
                    using (var context = new UserDataContext())
                    {
                        var user = new User()
                        {
                            Username = username,
                            Password = password,
                            UserType = userType
                        };

                        context.Users.Add(user);

                        context.SaveChanges();
                    }

                    new SuccessfullyAdded().ShowDialog();
                }
            }
        }
    }
}
