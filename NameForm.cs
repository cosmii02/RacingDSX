using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForzaDSX
{
    public partial class NameForm : Form
    {

        public static string ShowDialog(string name, String title = "Please enter the Name")
        {
            NameForm form = new NameForm(name, title);
            return form.ShowDialog() == DialogResult.OK ? form.NameTextBox.Text : name;
        }

        public NameForm(String name, String title)
        {
            InitializeComponent();
            this.Text = title;
            NameTextBox.Text = name;
            NameTextBox.Focus();

        }

        private void OkButton_Click(object sender, EventArgs e)
        {

        }

        private void NameForm_Load(object sender, EventArgs e)
        {

        }
    }
}
