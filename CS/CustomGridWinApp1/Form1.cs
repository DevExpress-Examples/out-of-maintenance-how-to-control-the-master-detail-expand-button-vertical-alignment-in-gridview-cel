using System;
using System.Windows.Forms;

namespace CustomGridWinApp1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.ordersTableAdapter.Fill(this.nwindDataSet.Orders);
			this.employeesTableAdapter.Fill(this.nwindDataSet.Employees);
		}
	}
}
