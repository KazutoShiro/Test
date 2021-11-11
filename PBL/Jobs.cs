using System;
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
            
            panel1.AutoScroll = true;
            string[] jobs = {"Microsoft","Google","Rakuten","Lazada"};//get data from database jobname and add to string[]
            string[] Field = { "Software", "Design", "Service", "Stuff" };//get data from database jobfield and add to string[]
            string[] loc = { "Las Pinas", "Makati", "Japan", "Korea" };
            for (int i = 0; i < jobs.Length; i++) 
            {
                JobPosts jp = new JobPosts();
                jp.FieldName = Field[i];
                jp.CompanyName = jobs[i];
                jp.Location = loc[i];
                panel1.Controls.Add(jp);
                
            }
            
        }
        
    }
}
