﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant2
{
    public partial class BusboyForm : Form
    {
        public BusboyForm()
        {
            InitializeComponent();
        }
        FloorPlan Table = new FloorPlan();

        private void btnTable1_Click(object sender, EventArgs e)
        {
            Table.table1 = "Clean";
        }

        private void btnTable2_Click(object sender, EventArgs e)
        {

        }

        private void btnTable3_Click(object sender, EventArgs e)
        {

        }

        private void btnTable4_Click(object sender, EventArgs e)
        {

        }

        private void btnTable5_Click(object sender, EventArgs e)
        {

        }

        private void btnTable6_Click(object sender, EventArgs e)
        {

        }

        private void btnTable7_Click(object sender, EventArgs e)
        {

        }
    }
}