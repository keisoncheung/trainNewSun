using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace trainNewSun
{
    public partial class FrmAboutUs : Form
    {
        public FrmAboutUs()
        {
            InitializeComponent();
            loadData();
        }

        public void loadData()
        {
            labSofeName.Text = SystemInfo.SofeName;
            labVersion.Text = SystemInfo.Version;
            labAuthor.Text = SystemInfo.Author;
        }

        private void linlabAuthorEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmAboutAuthor frm = new FrmAboutAuthor();
            frm.ShowDialog();
        }
    }
}
