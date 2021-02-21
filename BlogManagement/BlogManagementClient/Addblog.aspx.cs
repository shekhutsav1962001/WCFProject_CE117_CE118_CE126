﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BlogManagementClient.ServiceReference1;
namespace BlogManagementClient
{
    public partial class Addblog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BlogManagementClient.ServiceReference1.Service1Client pr = new BlogManagementClient.ServiceReference1.Service1Client("BasicHttpBinding_IService1");
            if(TextBox1.Text=="" || TextBox2.Text=="" || TextArea1.Text=="")
            {
                Label1.Text = "All Data is required";
            }
            else
            {
                Blog b = new Blog();
                b.Title = TextBox1.Text;
                b.Description = TextArea1.Text;

                b.DateOfUpload = DateTime.Parse(TextBox2.Text);
                
                pr.AddBlog(b);
                Response.Redirect("index.aspx");
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }
    }
}