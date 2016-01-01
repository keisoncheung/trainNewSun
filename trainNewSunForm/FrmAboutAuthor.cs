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
    public partial class FrmAboutAuthor : Form
    {
        public FrmAboutAuthor()
        {
            InitializeComponent();
            loadData();
        }

        public void loadData()
        {
            tbxAuthor.Text = "作者：" + SystemInfo.Author + "  QQ: " + SystemInfo.QQ + "  Email: " + SystemInfo.AuthorEmail + "";
        }

    }
}
