using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ImageShowByUrl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string cid1 = "http://192.168.1.188:9001/api/resource/{0}/cid1/1/?token=hbpc";
        string cid2 = "http://192.168.1.188:9001/api/resource/{0}/cid2/1/?token=hbpc";
        string cidhead = "http://192.168.1.188:9001/api/resource/{0}/cidhead/1/?token=hbpc";
        private void button1_Click(object sender, EventArgs e)
        {
            string url1 = String.Format(cid1, textBox1.Text);
            string url2 = String.Format(cid1, textBox1.Text);
            string url3 = String.Format(cid1, textBox1.Text);
            myURLImage1.ImageUrl = url1;
            myURLImage2.ImageUrl = url2;
            myURLImage3.ImageUrl = url3;
            //bbWebRequest(img1, url1);
            //bbWebRequest(img2, url2);
            //bbWebRequest(img3, url3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myURLImage1.Image = myURLImage2.Image = myURLImage3.Image = null;
        }

      
    }
}

