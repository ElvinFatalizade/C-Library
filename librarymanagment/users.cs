﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace librarymanagment
{
    public partial class users : Form
    {
        public users()
        {
            InitializeComponent();
           
           

        }

        private void AddNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addbooks book = new addbooks();
            book.Show();
            
        }

        private void Users_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            srch sr = new srch();
            sr.Show();
           
        }

        private void AddNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addperson addpr = new addperson();
            addpr.Show();
           
        }

        private void CustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            
        }

        private void CustomeIssueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customer cs = new customer();
            cs.Show();

           

        }

        private void CustomerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            customeissue issue = new customeissue();
            issue.Show();
        }
    }
}
