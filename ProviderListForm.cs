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
    public partial class ProviderListForm : Form
    {
        public ProviderListForm()
        {
            InitializeComponent();
        }

        private void buttonAddProvider_Click(object sender, EventArgs e)
        {
            new AddProviderForm().Show();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonEditProvider_Click(object sender, EventArgs e)
        {
            new EditProviderForm().Show();
        }

        private void buttonDeleteProvider_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Вы действительно хотите удалить данного поставщика?", "Удаление поставщика", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                MessageBox.Show("Поставщик удален");
            }
        }
    }
}
