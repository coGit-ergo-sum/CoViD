using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoViD.GUI
{
	public partial class MDI : Form
	{
		private int childFormNumber = 0;

		public MDI()
		{
			InitializeComponent();
			tsmSpread_Click(null, null);
		}

		private void ShowNewForm(object sender, EventArgs e)
		{
			Form childForm = new Form();
			childForm.MdiParent = this;
			childForm.Text = "Window " + childFormNumber++;
			childForm.Show();
		}

		private void OpenFile(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
			if (openFileDialog.ShowDialog(this) == DialogResult.OK)
			{
				string FileName = openFileDialog.FileName;
			}
		}

		private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
			if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
			{
				string FileName = saveFileDialog.FileName;
			}
		}

		private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void CutToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			toolStrip.Visible = toolBarToolStripMenuItem.Checked;
		}

		private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			statusStrip.Visible = statusBarToolStripMenuItem.Checked;
		}

		private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.Cascade);
		}

		private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.TileVertical);
		}

		private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.TileHorizontal);
		}

		private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			LayoutMdi(MdiLayout.ArrangeIcons);
		}

		private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			foreach (Form childForm in MdiChildren)
			{
				childForm.Close();
			}
		}

		private void tsmInfection_Click(object sender, EventArgs e)
		{
			var frmInfection = new CoViD.GUI.Forms.Infection()
			{
				TopLevel = false,
				MdiParent = this,
				//FormBorderStyle = FormBorderStyle.None,
				//BackColor = tabMDI.TabPages[0].BackColor,
				// This set the form parent as the tabClicked
				//Parent = this.tabs.SelectedTab,
				WindowState = FormWindowState.Normal,
				StartPosition = FormStartPosition.CenterParent
			};
			frmInfection.Show();
		}

		private void tsmPerson_Click(object sender, EventArgs e)
		{
			var frmPerson = new CoViD.GUI.Forms.Person()
			{
				//TopLevel = false,
				MdiParent = this,
				//FormBorderStyle = FormBorderStyle.None,
				//BackColor = tabMDI.TabPages[0].BackColor,
				// This set the form parent as the tabClicked
				//Parent = this.tabs.SelectedTab,
				WindowState = FormWindowState.Normal,
				StartPosition = FormStartPosition.CenterParent
			};
			frmPerson.Show();
		}

		private void tsmSpread_Click(object sender, EventArgs e)
		{
			var frmSpread = new CoViD.GUI.Forms.Spread()
			{
				TopLevel = false,
				MdiParent = this,
				//FormBorderStyle = FormBorderStyle.None,
				//BackColor = tabMDI.TabPages[0].BackColor,
				// This set the form parent as the tabClicked
				//Parent = this.tabs.SelectedTab,
				WindowState = FormWindowState.Normal,
				StartPosition = FormStartPosition.CenterParent
			};
			frmSpread.Show();
		}
	}
}
