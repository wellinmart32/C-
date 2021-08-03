using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RoleSoftCom
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void pictureBoxInventary_Click(object sender, EventArgs e)
        {
            new InventaryForm().Show();
            this.Hide();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
