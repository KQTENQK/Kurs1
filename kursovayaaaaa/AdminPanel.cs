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
    public partial class AdminPanel : Form
    {
        private User _currentUser;

        public AdminPanel(User user)
        {
            InitializeComponent();
            _currentUser = user;
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            List<int> addedUsersIds = new List<int>();

            Task.Run(async () =>
            {
                while (true)
                {
                    await Task.Run(() =>
                    {
                        using (var context = new UserDataContext())
                        {
                            var users = context.Users.Where(user => user.Username != _currentUser.Username);
                            foreach (var user in users)
                            {
                                if (!addedUsersIds.Contains(user.Id))
                                {
                                    string dataToAdd = $"User: {user.Username}   Type: {user.UserType}   Id: {user.Id}";
                                    listBoxUsers?.Invoke(new Action(() => listBoxUsers.Items.Add(dataToAdd)));
                                    listBoxUsers?.Invoke(new Action(() => listBoxUsers.Update()));
                                    addedUsersIds.Add(user.Id);
                                }
                            }
                        }
                    });
                }

            });
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            new AdminAdditionPanel().ShowDialog();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listBoxUsers.SelectedItem != null)
            {
                using (var context = new UserDataContext())
                {
                    int idIndex = listBoxUsers.SelectedItem.ToString().IndexOf("Id: ");
                    int removingUser = int.Parse(listBoxUsers.SelectedItem.ToString().Substring(idIndex).Replace("Id: ", ""));
                    var user = context.Users.Where(removingClient => removingClient.Id == removingUser).FirstOrDefault();

                    if (user != null)
                    {
                        context.Users.Remove(user);
                        context.SaveChanges();
                        listBoxUsers.Items.RemoveAt(listBoxUsers.SelectedIndex);
                        new RemovedSuccessfully().ShowDialog();
                    }
                    else
                    {
                        new SomethingWentWrong().ShowDialog();
                    }
                }
            }
        }

        private void AdminPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Close();
            Application.Exit();
        }
    }
}
