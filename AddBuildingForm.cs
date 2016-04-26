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
	public partial class AddBuildingForm : Form
	{
		public AddBuildingForm()
		{
			InitializeComponent();
		}

		private bool formValidate()
		{
			return false;
		}

		private void addButton_Click(object sender, EventArgs e)
		{
			if (formValidate()) MessageBox.Show("Заполнены не все поля или введены некорректные данные.");
		}
	}
}
