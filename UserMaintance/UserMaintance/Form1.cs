using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserMaintance.Entities;

namespace UserMaintance
{
    public partial class Form1 : Form
    {
        BindingList<User> users = new BindingList<User>();

        public Form1()
        {
            InitializeComponent();

            label1.Text = Resource1.lastName;
            label2.Text = Resource1.firstName;
            button1.Text = Resource1.add;

            listBox1.DataSource = users;
            listBox1.ValueMember = "ID";
            listBox1.DisplayMember = "fullName";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User u = new User()
            {
                lastName = textBox1.Text,
                firstName = textBox2.Text
            };
            users.Add(u);
        }
    }
}
