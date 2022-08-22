using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class inventory : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataBind();
        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            getDetailByID();
        }
        //addButton
        protected void Button1_Click(object sender, EventArgs e)
        {
            addfunc();

        }
        //updateButton
        protected void Button3_Click(object sender, EventArgs e)
        {
            updatefunc();
        }

        //deleteButton
        protected void Button2_Click(object sender, EventArgs e)
        {
            deletefunc();
        }
        //user defined function
        void addfunc()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO Inventory_detail(order_id,name,date,contact_no,email_id,state,city,pincode,full_add) values(@order_id,@name,@date,@contact_no,@email_id,@state,@city,@pincode,@full_add)", con);
                cmd.Parameters.AddWithValue("@order_id", TextBox10.Text.Trim());
                cmd.Parameters.AddWithValue("@name", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@date", TextBox11.Text.Trim());
                cmd.Parameters.AddWithValue("@contact_no", TextBox12.Text.Trim());
                cmd.Parameters.AddWithValue("@email_id", TextBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@state", DropDownList1.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@city", TextBox6.Text.Trim());
                cmd.Parameters.AddWithValue("@pincode", TextBox7.Text.Trim());
                cmd.Parameters.AddWithValue("@full_add", TextBox14.Text.Trim());
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Details Added Successfully.');</script>");
                clearform();
                GridView1.DataBind();

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        void updatefunc()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                }
                SqlCommand cmd = new SqlCommand("UPDATE Inventory_detail SET order_id='" + TextBox10.Text.Trim() + "', name='" + TextBox2.Text.Trim() + "', date='" + TextBox11.Text.Trim() + "', contact_no ='" + TextBox12.Text.Trim() + "', email_id='" + TextBox3.Text.Trim() + "', state='" + DropDownList1.Text.Trim() + "', city='" + TextBox6.Text.Trim() + "', pincode='" + TextBox7.Text.Trim() + "', full_add='" + TextBox14.Text.Trim() + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                GridView1.DataBind();
                Response.Write("<script>alert('Details Updated');</script>");


            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        void deletefunc()
        {

            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("DELETE from Inventory_detail WHERE order_id='" + TextBox10.Text.Trim() + "'", con);

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Member Deleted Successfully');</script>");
                clearform();
                GridView1.DataBind();

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

            void clearform()
            {
                TextBox10.Text = " ";
                TextBox2.Text = " ";
                TextBox11.Text = " ";
                TextBox12.Text = " ";
                DropDownList1.Text = " ";
                TextBox6.Text = " ";
                TextBox7.Text = " ";
                TextBox14.Text = " ";

            }
            void getDetailByID()
            {
                try
                {
                    SqlConnection con = new SqlConnection(strcon);

                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = new SqlCommand("select * from Inventory_detail " +
            "where order_id='" + TextBox10.Text.Trim() + "'", con);

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            TextBox10.Text = dr.GetValue(0).ToString();
                            TextBox2.Text = dr.GetValue(1).ToString();
                            TextBox11.Text = dr.GetValue(2).ToString();
                            TextBox12.Text = dr.GetValue(3).ToString();
                            DropDownList1.Text = dr.GetValue(4).ToString();
                            TextBox6.Text = dr.GetValue(5).ToString();
                            TextBox7.Text = dr.GetValue(6).ToString();
                            TextBox14.Text = dr.GetValue(7).ToString();


                        }
                    }
                    else
                    {
                        Response.Write("<script>alert('Invalid Credentials');</script>");
                    }
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "');</script>");
                }
            }


        }
    }

