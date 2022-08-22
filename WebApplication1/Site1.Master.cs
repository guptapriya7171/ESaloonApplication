using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try {
                if(Session["role"].Equals(""))
                {
                    LinkButton1.Visible = true; //user login link button
                    LinkButton2.Visible = true; // signup link button

                    LinkButton3.Visible = false; //logout link button
                    LinkButton7.Visible = false; //hello user link button

                    LinkButton6.Visible = true;   //Admin login button
                    LinkButton5.Visible = false;  //Staff management button
                    LinkButton8.Visible = false;  //Member management button
                    LinkButton9.Visible = false;  //Inventory button
                    LinkButton10.Visible = true; //Contact button
                    LinkButton4.Visible = true;  //Policies button

                }
                else if (Session["role"].Equals("user"))
                {
                    LinkButton1.Visible = false; //user login link button
                    LinkButton2.Visible = false; // signup link button

                    LinkButton3.Visible = true; //logout link button
                    LinkButton7.Visible = true; //hello user link button
                    LinkButton7.Text = "Hello " + Session["fullname"].ToString();

                    LinkButton6.Visible = true;   //Admin login button
                    LinkButton5.Visible = false;  //Staff management button
                    LinkButton8.Visible = false;  //Member management button
                    LinkButton9.Visible = false;  //Inventory button
                    LinkButton10.Visible = true; //Contact button
                    LinkButton4.Visible = true;  //Policies button
                }
                else if (Session["role"].Equals("admin"))
                {
                    LinkButton1.Visible = false; //user login link button
                    LinkButton2.Visible = false; // signup link button

                    LinkButton3.Visible = true; //logout link button
                    LinkButton7.Visible = true; //hello user link button
                    LinkButton7.Text = "Hello " + Session["fullname"].ToString();

                    LinkButton6.Visible = false;   //Admin login button
                    LinkButton5.Visible = true;  //Staff management button
                    LinkButton8.Visible = true;  //Member management button
                    LinkButton9.Visible = true;  //Inventory button
                    LinkButton10.Visible = true; //Contact button
                    LinkButton4.Visible = true;  //Policies button
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
            

        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminlogin.aspx");
        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Response.Redirect("staffmanagement.aspx");
        }

        protected void LinkButton8_Click(object sender, EventArgs e)
        {
            Response.Redirect("membermanagement.aspx");
        }

        protected void LinkButton9_Click(object sender, EventArgs e)
        {
            Response.Redirect("inventory.aspx");
        }

        protected void LinkButton10_Click(object sender, EventArgs e)
        {
            Response.Redirect("contact.aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Policies.aspx");
        }
        protected void LinkButton11_Click(object sender, EventArgs e)
        {
            Response.Redirect("payment.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Session["username"] = "" ;
            Session["fullname"] = "";
            Session["role"] = "";
            Session["status"] = "";

            LinkButton1.Visible = true; //user login link button
            LinkButton2.Visible = true; // signup link button

            LinkButton3.Visible = false; //logout link button
            LinkButton7.Visible = false; //hello user link button

            LinkButton6.Visible = true;   //Admin login button
            LinkButton5.Visible = false;  //Staff management button
            LinkButton8.Visible = false;  //Member management button
            LinkButton9.Visible = false;  //Inventory button
            LinkButton10.Visible = true; //Contact button
            LinkButton4.Visible = true;  //Policies button

            Response.Redirect("homepage.aspx");
        }
    }
}