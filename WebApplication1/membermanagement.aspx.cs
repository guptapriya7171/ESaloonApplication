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
    public partial class membermanagement : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataBind();
        }
        //Go Button
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            getMemberByID();
        }
        //Active Button

        protected void Button3_Click(object sender, EventArgs e)
        {
            updateMemberStatusByID("active");
        }
        //pending Button
        protected void Button4_Click(object sender, EventArgs e)
        {
            updateMemberStatusByID("pending");

        }
        //deactive Button
        protected void Button5_Click(object sender, EventArgs e)
        {
            updateMemberStatusByID("deactive");

        }
        //delete Button
        protected void Button2_Click(object sender, EventArgs e)
        {
            deleteMemberByID();
        }

        //user defined func
        bool checkIfMemberExists()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * from member_master_table where member_id='" + TextBox1.Text.Trim() + "';", con);
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
        void deleteMemberByID()
        {
            if (checkIfMemberExists())
            {
                try
                {
                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    SqlCommand cmd = new SqlCommand("DELETE from member_master_table WHERE member_id='" + TextBox1.Text.Trim() + "'", con);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    Response.Write("<script>alert('Member Deleted Successfully');</script>");
                    clearForm();
                    GridView1.DataBind();

                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "');</script>");
                }

            }
            else
            {
                Response.Write("<script>alert('Invalid Member ID');</script>");
            }
        }
        void getMemberByID()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("select * from member_master_tbl " +
        "where member_id='" + TextBox10.Text.Trim() + "'", con);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        TextBox2.Text = dr.GetValue(0).ToString();
                        TextBox1.Text = dr.GetValue(10).ToString();
                        TextBox11.Text = dr.GetValue(1).ToString();
                        TextBox12.Text = dr.GetValue(2).ToString();
                        TextBox3.Text = dr.GetValue(3).ToString();
                        TextBox1.Text = dr.GetValue(10).ToString();
                        TextBox9.Text = dr.GetValue(4).ToString();
                        TextBox4.Text = dr.GetValue(5).ToString();
                        TextBox13.Text = dr.GetValue(6).ToString();
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
        void updateMemberStatusByID(string status)
        {
            if (checkIfMemberExists())
            {
                try
                {
                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();

                    }
                    SqlCommand cmd = new SqlCommand("UPDATE member_master_table SET account_status='" + status + "' WHERE member_id='" + TextBox1.Text.Trim() + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    GridView1.DataBind();
                    Response.Write("<script>alert('Member Status Updated');</script>");


                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "');</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Invalid Member ID');</script>");
            }

        }
        void clearForm()
        {
            TextBox2.Text = " ";
            TextBox1.Text = " ";
            TextBox11.Text = " ";
            TextBox12.Text = " ";
            TextBox1.Text = " ";
            TextBox9.Text = " ";
            TextBox4.Text = " ";
            TextBox13.Text = " ";
            TextBox14.Text = " ";
        }
      }

    }
