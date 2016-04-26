using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Buildings
{
    public partial class AddProviderForm : Form
    {
        public AddProviderForm()
        {
            InitializeComponent();
        }

        private void buttonAddAdd_Click(object sender, EventArgs e)
        {
            if (textBoxAddProvName.Text != "" && textBoxAddProvINN.Text != "" && textBoxAddProvLis.Text != "")
            {
            }
            else
                MessageBox.Show("Заполнены не все поля или введены некорректные данные.");
        }

        private void buttonAddCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
