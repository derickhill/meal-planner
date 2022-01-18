﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meal_Planner
{
    public partial class frmInitial : Form
    {
        public frmInitial()
        {
            InitializeComponent();
        }

        private void btnGeneratePlan_Click(object sender, EventArgs e)
        {
            this.Hide();

            new frmGeneratePlan().Show();
        }

        private void btnAddMeal_Click(object sender, EventArgs e)
        {
            this.Hide();

            new frmAddMeal().Show();
        }
    }
}
