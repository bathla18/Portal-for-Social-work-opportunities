using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Web.Security;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] != null)          // check for condition if user is login in system or not  and load search and apply opportunity
        {
             //Response.Write("<script> getMap();</script>");
            Label1.Text = Session["user"].ToString();
            string search = Session["search"].ToString();
            string x = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection s = new SqlConnection(x);
            s.Open();
            string x1 = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection s1 = new SqlConnection(x1);
            s1.Open();
            string insertQuery = "SELECT [name],[ngoname],[description],[country],[city],[startdate],[duration] FROM [dbo].[opportunity] where [name]=@sear";
            string insertQuery1 = "SELECT [oppname] FROM [dbo].[useropp] where [oppname]=@sear1 and [email] = @email";
            SqlCommand sc = new SqlCommand(insertQuery, s);
            SqlCommand sc1 = new SqlCommand(insertQuery1, s1);
            sc.Parameters.AddWithValue("@sear", search);
            sc1.Parameters.AddWithValue("@sear1", search);
            sc1.Parameters.AddWithValue("@email", Session["email"].ToString());
            SqlDataReader sdr = sc.ExecuteReader();
            SqlDataReader sdr1 = sc1.ExecuteReader();
            if (sdr1.HasRows)
            {
                Button1.Enabled=false;
            }
            else
            {
                Button3.Enabled = false;
            }
            if (sdr.HasRows)
            {

                while (sdr.Read())
                {
                    Label2.Text = sdr[0].ToString();
                    Label3.Text = sdr[1].ToString();
                    Label4.Text = sdr[5].ToString();
                    Label5.Text = sdr[6].ToString();
                    Label6.Text = sdr[3].ToString();
                    Label7.Text = sdr[4].ToString();
                    Label8.Text = sdr[2].ToString();
                }
            }
            else
            {
                Response.Write("not found");
            }
            s.Close();
            s1.Close();
            string x2 = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection s2 = new SqlConnection(x2);
            s2.Open();
            string insertQuery2 = "select count(*) as [count] from [dbo].[useropp] where [oppname] = @sear";
            SqlCommand sc2 = new SqlCommand(insertQuery2, s2);
            sc2.Parameters.AddWithValue("@sear", search);
            SqlDataReader sdr2 = sc2.ExecuteReader();
            if (sdr2.HasRows)
            {
                while (sdr2.Read())
                {
                    Label9.Text = sdr2[0].ToString();
                }
            }
            s2.Close();
        }
        else
        {
            Response.Redirect("NGO.aspx");
        }
    }

    protected void LinkButton1_Click(object sender, EventArgs e)             // logout button 
    {
        Session.Contents.RemoveAll();
        Response.Redirect("NGO.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)             // to apply for opportunity and send emial to user ad admin and also check all and validate data entered
    {
      //  Response.Write("apply");
        string x = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        SqlConnection s = new SqlConnection(x);
        s.Open();       
        string email = Session["Email"].ToString();
        string oppname = Label2.Text;
        string ngoname = Label3.Text;
        string date = Label4.Text;
        DateTime dt = Convert.ToDateTime(date);
        Response.Write(dt);
        string duration = Label5.Text;
        string country = Label6.Text;
        string city = Label7.Text;
        string description = Label8.Text;
        string insertQuery = "insert into [dbo].[useropp] ([email],[oppname],[ngoname],[description],[country],[city],[start],[duration],[status]) values (@email,@oppname,@ngoname,@desc,@country,@city,@start,@duration,@status)";
        SqlCommand insrtcmd = new SqlCommand(insertQuery, s);
        insrtcmd.Parameters.AddWithValue("@email",email);
        insrtcmd.Parameters.AddWithValue("@oppname", oppname);
        insrtcmd.Parameters.AddWithValue("@ngoname", ngoname);
        insrtcmd.Parameters.AddWithValue("@desc", description);
        insrtcmd.Parameters.AddWithValue("@country", country);
        insrtcmd.Parameters.AddWithValue("@city", city);
        insrtcmd.Parameters.AddWithValue("@start", dt);
        insrtcmd.Parameters.AddWithValue("@duration", duration);
        insrtcmd.Parameters.AddWithValue("@status", "active");
        insrtcmd.ExecuteNonQuery();
        s.Close();
        string[] admin = {"ankit.bathla6@gmail.com"};
        try
        {
            SendMail sendMail = new SendMail();
            string[] toMail = { Session["Email"].ToString() };
            SendMail.sendMail(toMail, "opportunity applied", "sucessfull applied for opportunity " + oppname);
            SendMail adminmail = new SendMail();
            
            SendMail.sendMail(admin, "opportunity applied", "sucessfull applied for opportunity " + oppname +" by " + Session["user"] + "registered with email" + Session["Email"].ToString());
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
        Response.Write("<script>window.alert('Applied Sucessfully');window.location='volunteerlanding.aspx';</script>");
    }

    protected void Button2_Click(object sender, EventArgs e)          // cancel button
    {
        Response.Redirect("volunteerlanding.aspx");
    }

    protected void Button3_Click(object sender, EventArgs e)        // withdraw button from opportunity and send email to user 
    {
        string x = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        SqlConnection s = new SqlConnection(x);
        s.Open();   
        string email = Session["Email"].ToString();
        string oppname = Label2.Text;
        string insertQuery = "delete from [dbo].[useropp] where Email = @email and oppname=@oppname";
        SqlCommand insrtcmd = new SqlCommand(insertQuery, s);
        insrtcmd.Parameters.AddWithValue("@email",email);
        insrtcmd.Parameters.AddWithValue("@oppname", oppname);
        insrtcmd.ExecuteNonQuery();
        s.Close();
        try
        {
            SendMail sendMail = new SendMail();
            string[] toMail = { Session["Email"].ToString() };
            SendMail.sendMail(toMail, "opportunity withdraw","Application withdraw for opportunity " + oppname);
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
        Response.Write("<script>window.alert('Withdraw Sucessfully');window.location='volunteerlanding.aspx';</script>");
       // ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Withdraw  sucessfully')", true);
       // Response.Redirect("volunteerlanding.aspx");
    }
}