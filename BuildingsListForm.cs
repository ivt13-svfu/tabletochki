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
	public partial class BuildingsListForm : Form
	{
		public BuildingsListForm()
		{
			InitializeComponent();
		}

		private void DeleteButton_Click(object sender, EventArgs e)
		{
			DialogResult res = MessageBox.Show("Вы действительно хотите удалить данное здание?", "Удаление здания", MessageBoxButtons.YesNo);
			if (res == DialogResult.Yes) {
				MessageBox.Show("Здание удалено");
			}
		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			new AddBuildingForm().Show();
		}

		private void EditButton_Click(object sender, EventArgs e)
		{
			new EditBuildingsForm().Show();
		}
	}
}
