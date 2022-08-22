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
    public partial class staffmanagement : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataBind();

        }

        //add button click
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (checkIfStaffExits())
            {
                Response.Write("<script>alert('Staff with same id already exits. Try to insert another ID.');</script>");
            }
            else
            {
                addNewStaff();
            }
        }
        //Update button click
        protected void Button3_Click(object sender, EventArgs e)
        {
            if (checkIfStaffExits())
            {
                updateStaff();
            }
            else
            {
                Response.Write("<script>alert('Staff with same id does not exits.');</script>");

            }
        }
        //delete button click
        protected void Button4_Click(object sender, EventArgs e)
        {
            if (checkIfStaffExits())
            {
                deleteStaff();
            }
            else
            {
                Response.Write("<script>alert('Staff with same id does not exits.');</script>");

            }
        }

        //Go button click
        protected void Button1_Click(object sender, EventArgs e)
        {
            getStaffByID();
        }
        //user defined function
        void getStaffByID()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("select * from staff_master_tbl" +
                    " where staff_id='" + TextBox1.Text.Trim() + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    TextBox2.Text = dt.Rows[0][1].ToString();
                }
                else
                {
                    Response.Write("<script>alert('Invalid Author ID');</script>");

                }


            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
                
            }
        }
        void deleteStaff()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("DELETE from staff_master_tbl WHERE staff_id ='" +
                    TextBox1.Text.Trim() + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert(' Staff Deleted Successfully');</script>");
                clearform();
                GridView1.DataBind();

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        
        void updateStaff()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("UPDATE staff_master_tbl SET staff_name=@staff_name WHERE staff_id ='" + TextBox1.Text.Trim() + "'", con);
                cmd.Parameters.AddWithValue("@staff_name", TextBox2.Text.Trim());
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert(' Staff Updated Successfully');</script>");
                clearform();
                GridView1.DataBind();


            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        void addNewStaff()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO staff_master_tbl(staff_id,staff_name) values(@staff_id,@staff_name)", con);
                cmd.Parameters.AddWithValue("@staff_id", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@staff_name", TextBox2.Text.Trim());
                

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert(' Staff added Successfully');</script>");
                clearform();
                GridView1.DataBind();

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        bool checkIfStaffExits()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("select * from staff_master_tbl" +
                    " where staff_id='" + TextBox1.Text.Trim() + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
                return false;
            }
        }
        void clearform()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";

        }

      
    }
}