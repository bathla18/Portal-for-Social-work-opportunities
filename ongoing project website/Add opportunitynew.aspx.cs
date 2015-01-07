using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Data.SqlClient;
using System.Configuration;
using System.Text.RegularExpressions;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] == null || Session["status"] == "0")
        {
            Response.Redirect("NGO.aspx");
        }
        else
        {
            Label8.Text = Session["user"].ToString();
        }
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)      // to populate list with city
    {
        DropDownList2.Items.Clear();
        DropDownList2.Items.Add("select your city");
        if (DropDownList1.SelectedItem.Text == "India")
        {
            List<string> citys = new List<string>() { "Hyderabad", "Mumbai", "Delhi", "Kolkata", "Chennai" };
            foreach (string city in citys)
            {
                DropDownList2.Items.Add(city);
            }
        }
        else if (DropDownList1.SelectedItem.Text == "Bermuda")
        {
            List<string> citys = new List<string>() { "Devonshire", "Hamilton", "Paget", "Pembroke", "St George's" };

            foreach (string city in citys)
            {
                DropDownList2.Items.Add(city);
            }
        }
        else if (DropDownList1.SelectedItem.Text == "Canada")
        {
            List<string> citys = new List<string>() { "Newfoundland and Labrador", "Northwest Territories", "Nova Scotia", "Nunavut", "Ontario" };
            foreach (string city in citys)
            {
                DropDownList2.Items.Add(city);
            }
        }
        else if (DropDownList1.SelectedItem.Text == "Estonia")
        {
            List<string> citys = new List<string>() { "Paide", "Kuressaare", "Valga", "Rakvere", "Sillamäe" };
            foreach (string city in citys)
            {
                DropDownList2.Items.Add(city);
            }
        }
        else if (DropDownList1.SelectedItem.Text == "Isle of man")
        {
            List<string> citys = new List<string>() { "Andreas", "Arbor", "Ballaugh", "Maughold", "Michael" };
            foreach (string city in citys)
            {
                DropDownList2.Items.Add(city);
            }
        }
        else if (DropDownList1.SelectedItem.Text == "United kingdom")
        {
            List<string> citys = new List<string>() { "Bath", "Kingston upon Hull", "Portsmouth", "Winchester", "Wolverhampton" };
            foreach (string city in citys)
            {
                DropDownList2.Items.Add(city);
            }
        }
    }

    protected void Button1_Click1(object sender, EventArgs e)    // to submit opportunity and check whether all details are correct or not 
    {
        Label2.Text = "";
        Label1.Text = "";
        Label3.Text = "";
        Label4.Text = "";
        Label5.Text = "";
        Label7.Text = "";
        string name = TextBox1.Text;
        string desc = TextBox4.Text;
        string ngoname = TextBox2.Text;
        string country = DropDownList1.SelectedItem.Text;
        string city = DropDownList2.SelectedItem.Text;
        string dat = TextBox5.Text;
        string duration = TextBox3.Text;   
        bool val1 = true;
        Guid id = Guid.NewGuid();
        bool val = true;
        
        if (!validatename(name))
        {
            Label2.Text = "Entered name not correct";
            val = false;
            
        }
        if (desc == "")
        {
            Label1.Text = "Entered description not correct";
            val = false;
           
        }
        if (!validatengoname(ngoname))
        {
            Label3.Text = "Entered name not correct";
            val = false;
            
        }
        if (DropDownList1.SelectedItem.Text == "select your country" && val1 == true)
        {
            
            Label4.Text = "Enter your country first";
            val = false;
            
        }
        if (DropDownList2.SelectedItem.Text == "select your city" && val1 == true)
        {
            
            Label5.Text = "Enter your city first";
            val = false;
                   
        }

        if (!validateduration(duration))
        {
            Label7.Text = "Entered duration not correct";
            val = false;
            
        }
        if (val)
        {
            string x = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection s = new SqlConnection(x);
            s.Open();
            SqlCommand sc = new SqlCommand();
            DateTime creation = DateTime.Today;
            string insertQuery = "Insert Into [dbo].[opportunity] (name,ngoname,description,country,city,startdate,duration,creationdate,oppid) VALUES (@name,@ngoname,@description,@country,@city,@date,@duration,@creationdate,@oppid)";
            SqlCommand insrtcmd = new SqlCommand(insertQuery, s);
            insrtcmd.Parameters.AddWithValue("@name", name);
            insrtcmd.Parameters.AddWithValue("@description", desc);
            insrtcmd.Parameters.AddWithValue("@country", country);
            insrtcmd.Parameters.AddWithValue("@date", dat);
            insrtcmd.Parameters.AddWithValue("@city", city);
            insrtcmd.Parameters.AddWithValue("@ngoname", ngoname);
            insrtcmd.Parameters.AddWithValue("@duration", duration);
            insrtcmd.Parameters.AddWithValue("@creationdate", creation);
            insrtcmd.Parameters.AddWithValue("@oppid", id);
            insrtcmd.ExecuteNonQuery();     
            s.Close();
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('opportunity created')", true);
        }
    }
     
    public bool validateduration(string duration)      //to validate duration
    {
        string regex = "^[0-9][a-zA-z ]";
        if (duration != "") return Regex.IsMatch(duration, regex);
        else return false;
    }

    
    public bool validatename(string name)                          // to validate name
    {
        string MatchNamePattern = "^[a-zA-Z ]*$";
        if (name != "") return Regex.IsMatch(name, MatchNamePattern);
        else return false;
    }

    public bool validatengoname(string ngoname)                                 // ti validate name
    {
        string MatchngonamePattern = "^[a-zA-Z ]*$";
        if (ngoname != "") return Regex.IsMatch(ngoname, MatchngonamePattern);
        else return false;
    }

    protected void Button2_Click(object sender, EventArgs e)                         // cancel button redirect to nog page 
    {
        Response.Redirect("NGO.aspx");
    }

    protected void LinkButton1_Click(object sender, EventArgs e)                  // logout button logout from system
    {
        Session.Contents.RemoveAll();
        Response.Redirect("NGO.aspx");
    }

}