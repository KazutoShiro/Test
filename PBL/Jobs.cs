﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL
{
    public partial class Jobs : Form
    {
        public Jobs()
        {
            InitializeComponent();
        }


        private void rButton3_Click(object sender, EventArgs e)
        {
            JobPosts jp = new JobPosts();
            panel1.Controls.Add(jp);
        }

        private void Jobs_Load(object sender, EventArgs e)
        {
           
            JobPosts jp = new JobPosts();
            panel1.Controls.Add(jp);
        }
    }
}