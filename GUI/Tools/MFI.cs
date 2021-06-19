using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vi.Tools.Extensions.Object;

namespace CoViD.GUI.Forms
{
    public partial class MFI: Form
    {
        CoViD.GUI.Forms.Infection frmInfection = null;
        CoViD.GUI.Forms.Person frmPerson = null;
        public MFI()
        {
            InitializeComponent();
            //this.tabMFI.Visible = false;
        }

        private void tsmPerson_Click(object sender, EventArgs e)
        {
            CoViD.GUI.Forms.Person person = new CoViD.GUI.Forms.Person()
            {
                TopLevel = false,
                //MdiParent = this,
                //FormBorderStyle = FormBorderStyle.None,
                //WindowState = FormWindowState.Maximized,
                //BackColor = tabMDI.TabPages[0].BackColor,
                // This set the form parent as the tabClicked
                //Parent = this.pnlMain // tabMFI.TabPages[0] 
            };
            person.Show();
        }

        private void tsmDisease_Click(object sender, EventArgs e)
        {
            CoViD.GUI.Forms.Infection infection = new CoViD.GUI.Forms.Infection()
            {
                TopLevel = false,
                //MdiParent = this,
                //FormBorderStyle = FormBorderStyle.None,
                //BackColor = tabMDI.TabPages[0].BackColor,
                // This set the form parent as the tabClicked
                //Parent = this.pnlMain
            };
            infection.Show();
        }

        private void tsmSpread_Click(object sender, EventArgs e)
        {
            CoViD.GUI.Forms.Spread spread = new CoViD.GUI.Forms.Spread()
            {
                TopLevel = false,
                //MdiParent = this,
                //FormBorderStyle = FormBorderStyle.None,
                //BackColor = tabMDI.TabPages[0].BackColor,
                // This set the form parent as the tabClicked
                //Parent = this.pnlMain
            };
            spread.Show();
        }

        private void tabs_SelectedIndexChanged(object sender, EventArgs e)
        {


            switch (tabs.SelectedIndex)
            {
                case 0:
                    if (this.frmInfection.IsNull())
                    {
                        this.frmInfection = new CoViD.GUI.Forms.Infection()
                        {
                            TopLevel = false,
                            MdiParent = this,
                            FormBorderStyle = FormBorderStyle.None,
                            //BackColor = tabMDI.TabPages[0].BackColor,
                            // This set the form parent as the tabClicked
                            Parent = this.tabs.SelectedTab,
                            WindowState = FormWindowState.Maximized
                        };
                        this.frmInfection.Show();
                    }
                    break;
                case 1:
                    if (this.frmPerson.IsNull())
                    {
                        this.frmPerson = new CoViD.GUI.Forms.Person()
                        {
                            TopLevel = false,
                            MdiParent = this,
                            FormBorderStyle = FormBorderStyle.None,
                            //BackColor = tabMDI.TabPages[0].BackColor,
                            // This set the form parent as the tabClicked
                            Parent = this.tabs.SelectedTab,
                            WindowState = FormWindowState.Maximized
                        };
                        this.frmPerson.Show();
                    }
                    break;

                default: break;

            }
                
            //Graphics g = tabs.CreateGraphics();
            //int TabsWidth = 0;
            //int pad = tabs.Padding.X;
            //for (int i = 0; i < tabs.SelectedIndex; i++)
            //{
            //    TabsWidth += (int)g.MeasureString(tabs.TabPages[i].Text, tabs.Font).Width + pad;
            //}

            //TabsWidth += pad;
            //Rectangle rect = new Rectangle(TabsWidth, tabs.Padding.Y, (int)g.MeasureString(tabs.SelectedTab.Text, tabs.Font).Width, (int)g.MeasureString(tabs.SelectedTab.Text, tabs.Font).Height + tabs.Padding.Y);
            //g.FillRectangle(Brushes.LightBlue, rect);
            //g.DrawString(tabs.SelectedTab.Text, new Font(tabs.SelectedTab.Font, FontStyle.Bold), Brushes.Red, rect);

        }
    }
}
