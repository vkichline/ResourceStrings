using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ResourceStrings
{
    public partial class frmFind : Form
    {
        public string findString { get; set; }

        public frmFind()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            findString = txtFind.Text;
        }

        private void frmFind_Shown(object sender, EventArgs e)
        {
            txtFind.Text = findString;
            txtFind.SelectAll();
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            btnOK.Enabled = txtFind.Text.Length > 0;
        }
    }
}
