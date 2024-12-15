using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIgitalDictionary
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            AddPanel.Hide();
            UpdatePanel.Hide();
            DeletePanel.Hide();
        }

        private void WelcomeLabel_Click(object sender, EventArgs e)
        {
            MainPanel.Show();
            AddPanel.Hide();
            UpdatePanel.Hide();
            DeletePanel.Hide();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            MainPanel.Hide();
            AddPanel.Show();
            UpdatePanel.Hide();
            DeletePanel.Hide();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            MainPanel.Hide();
            AddPanel.Hide();
            UpdatePanel.Show();
            DeletePanel.Hide();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            MainPanel.Hide();
            AddPanel.Hide();
            UpdatePanel.Hide();
            DeletePanel.Show();
        }

        private void AddSubmit_Click(object sender, EventArgs e)
        {

        }

        private void SaveToJSON_Click(object sender, EventArgs e)
        {

        }

        private void SaveToDatabase_Click(object sender, EventArgs e)
        {

        }
    }
}
