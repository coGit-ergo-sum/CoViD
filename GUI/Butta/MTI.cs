using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoViD.GUI.Forms
{
	public partial class MTI : Form
	{
		public MTI()
		{
			InitializeComponent();
		}

		private void MTI_Load(object sender, EventArgs e)
		{
			var spread = new CoViD.GUI.Forms.Spread();

		}

		private void tabMDI_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (tabMDI.SelectedIndex == 0)
			{

				CoViD.GUI.Forms.Spread newFrm = new CoViD.GUI.Forms.Spread()
				{
					MdiParent = this,
					//FormBorderStyle = FormBorderStyle.None,
					BackColor = tabMDI.TabPages[0].BackColor,
					// This set the form parent as the tabClicked
					Parent = tabMDI.TabPages[0]
				};
				newFrm.Show();
			}
		}
	}
}
