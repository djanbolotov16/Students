﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Students
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void специальностиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.специальностиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.wINFORMSDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'wINFORMSDataSet.Специальности' table. You can move, or remove it, as needed.
            this.специальностиTableAdapter.Fill(this.wINFORMSDataSet.Специальности);

        }
    }
}
