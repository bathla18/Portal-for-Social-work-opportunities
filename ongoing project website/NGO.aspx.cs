using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)               // show top 10 opportunities 
    {
        string x = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        SqlConnection s = new SqlConnection(x);
        s.Open();
        string insertQuery = "SELECT TOP (10)  [name],[ngoname],[description],[country],[city],[startdate],[duration] FROM [dbo].[opportunity] ORDER BY [startdate] DESC" ;
        SqlCommand sc = new SqlCommand(insertQuery, s);
        SqlDataReader sdr = sc.ExecuteReader();
        if (sdr.HasRows)
        {
            int u = 1;
            while (sdr.Read())
            {
                if (u == 11)
                {
                    break;
                }
                Table1.Rows[u].Cells[0].Text = sdr[0].ToString();
                Table1.Rows[u].Cells[1].Text = sdr[1].ToString();
                Table1.Rows[u].Cells[2].Text = sdr[2].ToString();
                Table1.Rows[u].Cells[3].Text = sdr[3].ToString();
                Table1.Rows[u].Cells[4].Text = sdr[4].ToString();
                Table1.Rows[u].Cells[5].Text = sdr[5].ToString();
                Table1.Rows[u].Cells[6].Text = sdr[6].ToString();
                u++;
                
            }
        }
        s.Close();
    }

    protected void Button1_Click(object sender, EventArgs e)                      // to search opportunity in system and redirect user to voluteer landing after login
    {
        if (Session["user"] == null)
        {         
            String search = TextBox1.Text;
            string x = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection s = new SqlConnection(x);
            s.Open();
            string insertQuery = "SELECT [name] FROM [dbo].[opportunity] WHERE [name]=@sear";
            SqlCommand sc = new SqlCommand(insertQuery, s);
            sc.Parameters.AddWithValue("@sear", search);
            SqlDataReader sdr = sc.ExecuteReader();
            if (sdr.HasRows)
            {
              
                while (sdr.Read())
                {
                    Session["search"] = sdr[0].ToString();
                    Session["check"] = "searchopp";
                }
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Not Found')", true);
                //Label5.Text = "not found";
            }
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
            s.Close();
        }
    }
   
    protected void Button3_Click(object sender, EventArgs e)         //to apply for opportunity in system and redirect user to voluteer landing after login
    {
        if (Session["user"] == null)
        {
            String search = Table1.Rows[1].Cells[0].Text; 
           
            string x = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection s = new SqlConnection(x);
            s.Open();
            string insertQuery = "SELECT [name] FROM [dbo].[opportunity] WHERE [name]=@sear";
            SqlCommand sc = new SqlCommand(insertQuery, s);
            sc.Parameters.AddWithValue("@sear", search);
            SqlDataReader sdr = sc.ExecuteReader();
            if (sdr.HasRows)
            {                          
                Session["search"] = search;
                Session["check"] = "searchopp";
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Not Found')", true);
            }
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
            s.Close();
        }
    }

    protected void Button4_Click(object sender, EventArgs e)        //to apply for opportunity in system and redirect user to voluteer landing after login
    {
        if (Session["user"] == null)
        {
            String search = Table1.Rows[2].Cells[0].Text;
           
            string x = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection s = new SqlConnection(x);
            s.Open();
            string insertQuery = "SELECT [name] FROM [dbo].[opportunity] WHERE [name]=@sear";
            SqlCommand sc = new SqlCommand(insertQuery, s);
            sc.Parameters.AddWithValue("@sear", search);
            SqlDataReader sdr = sc.ExecuteReader();
            if (sdr.HasRows)
            {
                
                Session["search"] = search;
                Session["check"] = "searchopp";
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Not Found')", true);
            }
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
            s.Close();
        }

    }


    protected void Button5_Click(object sender, EventArgs e)           //to apply for opportunity in system and redirect user to voluteer landing after login
    {
        if (Session["user"] == null)
        {
            String search = Table1.Rows[3].Cells[0].Text;
           
            string x = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection s = new SqlConnection(x);
            s.Open();
            string insertQuery = "SELECT [name] FROM [dbo].[opportunity] WHERE [name]=@sear";
            SqlCommand sc = new SqlCommand(insertQuery, s);
            sc.Parameters.AddWithValue("@sear", search);
            SqlDataReader sdr = sc.ExecuteReader();
            if (sdr.HasRows)
            {
               
                Session["search"] = search;
                Session["check"] = "searchopp";
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Not Found')", true);
            }
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
            s.Close();
        }
    }

    protected void Button6_Click(object sender, EventArgs e)           //to apply for opportunity in system and redirect user to voluteer landing after login
    {
        if (Session["user"] == null)
        {
            String search = Table1.Rows[4].Cells[0].Text;
       
            string x = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection s = new SqlConnection(x);
            s.Open();
            string insertQuery = "SELECT [name] FROM [dbo].[opportunity] WHERE [name]=@sear";
            SqlCommand sc = new SqlCommand(insertQuery, s);
            sc.Parameters.AddWithValue("@sear", search);
            SqlDataReader sdr = sc.ExecuteReader();
            if (sdr.HasRows)
            {
               
                Session["search"] = search;
                Session["check"] = "searchopp";
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Not Found')", true);
            }
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
            s.Close();
        }
    }

    protected void Button7_Click(object sender, EventArgs e)        //to apply for opportunity in system and redirect user to voluteer landing after login
    {
        if (Session["user"] == null)
        {
            String search = Table1.Rows[5].Cells[0].Text;
       
            string x = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection s = new SqlConnection(x);
            s.Open();
            string insertQuery = "SELECT [name] FROM [dbo].[opportunity] WHERE [name]=@sear";
            SqlCommand sc = new SqlCommand(insertQuery, s);
            sc.Parameters.AddWithValue("@sear", search);
            SqlDataReader sdr = sc.ExecuteReader();
            if (sdr.HasRows)
            {
               
                Session["search"] = search;
                Session["check"] = "searchopp";
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Not Found')", true);
            }
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
            s.Close();
        }
    }

    protected void Button8_Click(object sender, EventArgs e)          //to apply for opportunity in system and redirect user to voluteer landing after login
    {
        if (Session["user"] == null)
        {
            String search = Table1.Rows[6].Cells[0].Text;
       
            string x = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection s = new SqlConnection(x);
            s.Open();
            string insertQuery = "SELECT [name] FROM [dbo].[opportunity] WHERE [name]=@sear";
            SqlCommand sc = new SqlCommand(insertQuery, s);
            sc.Parameters.AddWithValue("@sear", search);
            SqlDataReader sdr = sc.ExecuteReader();
            if (sdr.HasRows)
            {
               
                Session["search"] = search;
                Session["check"] = "searchopp";
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Not Found')", true);
            }
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
            s.Close();
        }
    }

    protected void Button9_Click(object sender, EventArgs e)            //to apply for opportunity in system and redirect user to voluteer landing after login
    {
        if (Session["user"] == null)
        {
            String search = Table1.Rows[7].Cells[0].Text;
       
            string x = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection s = new SqlConnection(x);
            s.Open();
            string insertQuery = "SELECT [name] FROM [dbo].[opportunity] WHERE [name]=@sear";
            SqlCommand sc = new SqlCommand(insertQuery, s);
            sc.Parameters.AddWithValue("@sear", search);
            SqlDataReader sdr = sc.ExecuteReader();
            if (sdr.HasRows)
            {               
                Session["search"] = search;
                Session["check"] = "searchopp";
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Not Found')", true);

            }
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
            s.Close();
        }
    }

    protected void Button10_Click(object sender, EventArgs e)           //to apply for opportunity in system and redirect user to voluteer landing after login
    {
        if (Session["user"] == null)
        {
            String search = Table1.Rows[8].Cells[0].Text;
       
            string x = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection s = new SqlConnection(x);
            s.Open();
            string insertQuery = "SELECT [name] FROM [dbo].[opportunity] WHERE [name]=@sear";
            SqlCommand sc = new SqlCommand(insertQuery, s);
            sc.Parameters.AddWithValue("@sear", search);
            SqlDataReader sdr = sc.ExecuteReader();
            if (sdr.HasRows)
            {
               
                Session["search"] = search;
                Session["check"] = "searchopp";
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Not Found')", true);

            }
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
            s.Close();
        }
    }

    protected void Button12_Click(object sender, EventArgs e)           //to apply for opportunity in system and redirect user to voluteer landing after login
    {
        if (Session["user"] == null)
        {
            String search = Table1.Rows[9].Cells[0].Text;
       
            string x = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection s = new SqlConnection(x);
            s.Open();
            string insertQuery = "SELECT [name] FROM [dbo].[opportunity] WHERE [name]=@sear";
            SqlCommand sc = new SqlCommand(insertQuery, s);
            sc.Parameters.AddWithValue("@sear", search);
            SqlDataReader sdr = sc.ExecuteReader();
            if (sdr.HasRows)
            {               
                Session["search"] = search;
                Session["check"] = "searchopp";
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Not Found')", true);

            }
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
            s.Close();
        }
    }

    protected void Button13_Click(object sender, EventArgs e)            //to apply for opportunity in system and redirect user to voluteer landing after login
    {
        if (Session["user"] == null)
        {
            String search = Table1.Rows[10].Cells[0].Text;
       
            string x = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection s = new SqlConnection(x);
            s.Open();
            string insertQuery = "SELECT [name] FROM [dbo].[opportunity] WHERE [name]=@sear";
            SqlCommand sc = new SqlCommand(insertQuery, s);
            sc.Parameters.AddWithValue("@sear", search);
            SqlDataReader sdr = sc.ExecuteReader();
            if (sdr.HasRows)
            {             
                Session["search"] = search;
                Session["check"] = "searchopp";
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Not Found')", true);

            }
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
            s.Close();
        }
    }
        
    public bool IsEmail(string email)               //to validate email
    {
        string MatchEmailPattern = @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@" + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
	    [0-9]{1,2}|25[0-5]|2[0-4][0-9])\." + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|" + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})$";
        if (email != null) return Regex.IsMatch(email, MatchEmailPattern);
        else return false;
    }

    protected void LinkButton1_Click(object sender, EventArgs e)           //login function to check login credentials
    {
        Label2.Text = "";
        Label3.Text = "";
        bool val = true;
        String email = TextBox2.Text;
        String password = TextBox3.Text;
        if (password == "")
        {

            Label3.Text = "Enter your Password!!!";
            val = false;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true); 
        }
        if (!IsEmail(email))
        {
            Label2.Text = "Please enter your Emailid again";
            val = false;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true); 
        }

       // password = Decrypt(password);
        if (val)
        {
            string x = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection s = new SqlConnection(x);
            s.Open();
            string pass =System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(password, "SHA1");         // to encrypt password
            string insertQuery = "SELECT [email],[password],[status],[firstname],[city] FROM [dbo].[userdata] WHERE [email]=@name AND ([Password]=@password OR [forgotrecovery]=@password)";
            SqlCommand sc = new SqlCommand(insertQuery, s);
            sc.Parameters.AddWithValue("@name", email);
            sc.Parameters.AddWithValue("@password", pass);
            SqlDataReader sdr = sc.ExecuteReader();
            Response.Write(sdr.HasRows);
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    string status1 = sdr[2].ToString();
                    if (status1 == "1")
                    {
                        string username = sdr[3].ToString();
                        Session["user"] = username;
                        Session["Email"] = email;
                        Session["city"] = sdr[4].ToString();
                        Session["status"] = "1";
                        if (Session["check"] == null)
                        {
                            Session["check"] = "pageload";
                        }
                        Response.Redirect("Add opportunitynew.aspx");
                    }
                    else
                    {
                        string username = sdr[3].ToString();
                        Session["user"] = username;
                        Session["Email"] = email;
                        Session["status"] = "0";
                        Session["city"] = sdr[4].ToString();
                        if (Session["check"] == null)
                        {
                            Session["check"] = "pageload";
                        }
                        s.Close();
                        Response.Redirect("volunteerlanding.aspx");
                    }
                }

            }
            else
            {
                Label2.Text = "enter email id not exist or password isn't correct";
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);                
            }
            s.Close();
        }
    }

    protected void LinkButton2_Click(object sender, EventArgs e)                     // in case of forgot password this function will work
    {
        string[] email = { TextBox2.Text };
        string password = Membership.GeneratePassword(12, 1);
       
        string x = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        SqlConnection s = new SqlConnection(x);
        s.Open();
        string pass = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(password, "SHA1");
        string insertQuery = "update [dbo].[userdata] set [forgotrecovery] = @sendThisInEmail WHERE Email = @email";
        SqlCommand sc = new SqlCommand(insertQuery, s);
        sc.Parameters.AddWithValue("@email", TextBox2.Text);
        sc.Parameters.AddWithValue("@sendThisInEmail", pass);
        SqlDataReader sdr = sc.ExecuteReader();
        s.Close();
        try
        {
            string sendthistouser = "User <b>" + email + "</b>. " + " Your temporary password is " + password + ".";
            SendMail sendMail = new SendMail();

            SendMail.sendMail(email, "Forgot password recovery", sendthistouser);
            Response.Write("<script>window.alert('Mail sent to your registered email');window.location='NGO.aspx';</script>");            
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
        s.Close();
    }      
}