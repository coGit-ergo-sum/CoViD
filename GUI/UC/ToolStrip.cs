using System;
using System.Windows.Forms;

namespace CoViD.GUI.UC
{
	/// <summary>
	/// A toolStrip control specialized for this applicaton
	/// </summary>
	public partial class ToolStrip:UserControl
	{
		//////////public delegate void ClickDelegate();
		//////////public event ClickDelegate Resume;
		//////////public event ClickDelegate Pause;

		/// <summary>
		/// Main contructor (Initializes Component)
		/// </summary>
		public ToolStrip()
		{
			InitializeComponent();
		}

		#region Run stop resume
		private void TsbPause_Click(object sender, EventArgs e)
		{
			tsbPause.Visible = false;
			tsbPlay.Visible = true;
			tsbPlay.Enabled = true;
			tsbSettings.Enabled = true;
		}

		private void TsbPlay_Click(object sender, EventArgs e)
		{
			tsbPlay.Visible = false;
			tsbPause.Visible = true;
			tsbSettings.Enabled = false;
		}

		private void TsbReplay_Click(object sender, EventArgs e)
		{
			tsbPlay.Visible = false;
			tsbPause.Visible = true;
			tsbPause.Enabled = true;
			tsbSettings.Enabled = false;
		}

		private void TsbNew_Click(object sender, EventArgs e)
		{
			tsbPlay.Visible = false;
			tsbPause.Visible = true;
			tsbPause.Enabled = false;
		}
		#endregion

		private void TsbSettings_Click(object sender, EventArgs e)
		{

		}

		private void TsbPeople_Click(object sender, EventArgs e)
		{

		}

	}
}
