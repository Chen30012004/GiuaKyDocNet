﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiuaKyDocNet
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void tourDLButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTourDL mainform = new frmTourDL();
            mainform.Show();
        }
    }
}
