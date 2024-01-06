using System.ComponentModel;
using System.Windows.Forms;
using UserMaintenance.Entities;

namespace UserMaintenance
{
    public partial class Form1 : Form
    {
        BindingList<User> users = new BindingList<User>();
        public Form1()
        {
            InitializeComponent();

            lblFullName.Text = Resource1.FullName;

            btnAdd.Text = Resource1.Add;
            btnSave.Text = Resource1.Save;
            btnDelete.Text = Resource1.Delete;

            listUsers.DataSource = null;
            listUsers.Items.Clear();
            foreach (var user in users)
            {
                listUsers.Items.Add(users);
            }
            listUsers.ValueMember = "ID";
            listUsers.DisplayMember = "Fullname";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var u = new User()
            {
                FullName = txtFullName.Text
            };
            users.Add(u);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        foreach (var user in users)
                        {
                            sw.WriteLine($"ID: {user.ID}, FullName: {user.FullName}");
                        }
                    }
                    MessageBox.Show("Sikeres mentés!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listUsers.SelectedItem != null)
            {
                listUsers.Items.Remove(listUsers.SelectedItems);
            }
            else
            {
                MessageBox.Show("Nincs kijelölt elem a törléshez.");
            }
        }
    }
}