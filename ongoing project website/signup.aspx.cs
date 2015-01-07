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
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
     //session part   
       
    }
    
    
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)            // to populate data in dropdownlist
    {
        DropDownList2.Items.Clear();
        Label6.Text = "";
        DropDownList2.Items.Add("select your city");
        if (DropDownList1.SelectedItem.Text == "India")
        {
            List<string> months = new List<string>() { "Hyderabad","Mumbai","Delhi","Kolkata","Chennai" };
            foreach (string month in months)
            {
               DropDownList2.Items.Add(month);
            }
        }
        else if (DropDownList1.SelectedItem.Text == "Bermuda")
        {
            List<string> months = new List<string>() { "Devonshire", "Hamilton", "Paget", "Pembroke", "St George's" };
            foreach (string month in months)
            {
                DropDownList2.Items.Add(month);
            }
        }
        else if (DropDownList1.SelectedItem.Text == "Canada")
        {
            List<string> months = new List<string>() { "Newfoundland and Labrador", "Northwest Territories", "Nova Scotia", "Nunavut", "Ontario" };
            foreach (string month in months)
            {
                DropDownList2.Items.Add(month);
            }
        }
        else if (DropDownList1.SelectedItem.Text == "Estonia")
        {
            List<string> months = new List<string>() { "Paide", "Kuressaare", "Valga", "Rakvere", "Sillamäe" };
            foreach (string month in months)
            {
                DropDownList2.Items.Add(month);
            }
        }
        else if (DropDownList1.SelectedItem.Text == "Isle of man")
        {
            List<string> months = new List<string>() { "Andreas", "Arbor", "Ballaugh", "Maughold", "Michael" };
            foreach (string month in months)
            {
                DropDownList2.Items.Add(month);
            }
        }
        else if (DropDownList1.SelectedItem.Text == "United kingdom")
        {
            List<string> months = new List<string>() { "Bath", "Kingston upon Hull", "Portsmouth", "Winchester", "Wolverhampton" };
            foreach (string month in months)
            {
                DropDownList2.Items.Add(month);
            }
        }
    }


    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)           // to populate pin number in list
    {
        DropDownList3.Items.Clear();
        Label7.Text = "";
        DropDownList3.Items.Add("select Your Pin");
        if ( DropDownList2.SelectedItem.Text == "Hyderabad" ){
            DropDownList3.Items.Add("500082");
        }
        if ( DropDownList2.SelectedItem.Text == "Mumbai" ){
            DropDownList3.Items.Add("400001");
        }
        if ( DropDownList2.SelectedItem.Text == "Delhi" ){
            DropDownList3.Items.Add("110001");
        }
        if ( DropDownList2.SelectedItem.Text == "Kolkata" ){
            DropDownList3.Items.Add("700001");
        }
        if ( DropDownList2.SelectedItem.Text == "Chennai" ){
            DropDownList3.Items.Add("600001");
        }
        if ( DropDownList2.SelectedItem.Text == "Devonshire" ){
            List<string> months = new List<string>() { "DV 01", "DV 02", "DV 03", "DV 04", "DV 05", "DV 06", "DV 07", "DV 08", "FL 01", "HM 15", "HM 16", "HM 18", "HM 20" };
            foreach (string month in months)
            {
                DropDownList3.Items.Add(month);
            }
        }
        if ( DropDownList2.SelectedItem.Text == "Hamilton" ){
            List<string> months = new List<string>() {"DV 03", "DV 04", "DV 05", "DV 06", "DV 07", "DV 08", "FL 01", "HM 15", "HM 16", "HM 18", "HM 20" };
            foreach (string month in months)
            {
                DropDownList3.Items.Add(month);
            }
        }
        if ( DropDownList2.SelectedItem.Text == "Paget" ){
            List<string> months = new List<string>() { "DV 01", "DV 02", "DV 03", "DV 04", "DV 05", "DV 06", "DV 07", "DV 08", "FL 01", "HM 15", "HM 16" };
            foreach (string month in months)
            {
                DropDownList3.Items.Add(month);
            }
        }
        if ( DropDownList2.SelectedItem.Text == "Pembroke" ){
            List<string> months = new List<string>() { "DV 01", "DV 02", "DV 03", "DV 04", "DV 05", "FL 01", "HM 15", "HM 16", "HM 18", "HM 20" };
            foreach (string month in months)
            {
                DropDownList3.Items.Add(month);
            }
        }
        if ( DropDownList2.SelectedItem.Text == "St George's" ){
            List<string> months = new List<string>() { "DV 01", "DV 06", "DV 07", "DV 08", "FL 01", "HM 15", "HM 16", "HM 18", "HM 20" };
            foreach (string month in months)
            {
                DropDownList3.Items.Add(month);
            }
        }
        if ( DropDownList2.SelectedItem.Text == "Newfoundland and Labrador" ){
            List<string> months = new List<string>() { "DV 01", "DV 06", "DV 07",  "HM 15", "HM 16", "HM 18", "HM 20" };
            foreach (string month in months)
            {
                DropDownList3.Items.Add(month);
            }
        }
        if ( DropDownList2.SelectedItem.Text == "Northwest Territories"){
            List<string> months = new List<string>() { "DV 01", "DV 06", "FL 01", "HM 15", "HM 16", "HM 18", "HM 20" };
            foreach (string month in months)
            {
                DropDownList3.Items.Add(month);
            }
        }
        if ( DropDownList2.SelectedItem.Text == "Nova Scotia" ){
            List<string> months = new List<string>() { "DV 01", "DV 07", "DV 08", "FL 01", "HM 15", "HM 16", "HM 18", "HM 20" };
            foreach (string month in months)
            {
                DropDownList3.Items.Add(month);
            }
        }
        if ( DropDownList2.SelectedItem.Text == "Nunavut" ){
            List<string> months = new List<string>() { "DV 01",  "DV 08", "FL 01", "HM 15", "HM 16", "HM 18", "HM 20" };
            foreach (string month in months)
            {
                DropDownList3.Items.Add(month);
            }
        }
        if ( DropDownList2.SelectedItem.Text == "Ontario"  ){
            List<string> months = new List<string>() { "DV 06", "DV 07", "DV 08", "FL 01", "HM 15", "HM 16", "HM 18", "HM 20" };
            foreach (string month in months)
            {
                DropDownList3.Items.Add(month);
            }
        }    
        if ( DropDownList2.SelectedItem.Text == "Paide"  ){
            List<string> months = new List<string>() {"EE-37","EE001","EN01","EO37" };
            foreach (string month in months)
            {
                DropDownList3.Items.Add(month);
            }
        }
        if ( DropDownList2.SelectedItem.Text == "Kuressaare"  ){
            List<string> months = new List<string>() { "EE-37","EE001","EN01","EO37","EE.HA" };
            foreach (string month in months)
            {
                DropDownList3.Items.Add(month);
            }
        }
        if ( DropDownList2.SelectedItem.Text == "Valga"  ){
            List<string> months = new List<string>() { "EE001","EN01","EO37","EE.HA"};
            foreach (string month in months)
            {
                DropDownList3.Items.Add(month);
            }
        }
        if ( DropDownList2.SelectedItem.Text == "Rakvere"  ){
            List<string> months = new List<string>() { "EE-37","EN01","EO37","EE.HA" };
            foreach (string month in months)
            {
                DropDownList3.Items.Add(month);
            }
        }
        if ( DropDownList2.SelectedItem.Text == "Sillamäe"  ){
            List<string> months = new List<string>() { "EE-37","EE001","EO37","EE.HA" };
            foreach (string month in months)
            {
                DropDownList3.Items.Add(month);
            }
        }
        if ( DropDownList2.SelectedItem.Text == "Andreas"  ){
            List<string> months = new List<string>() { "IM1","IM2","IM3","IM4","IM5"};
            foreach (string month in months)
            {
                DropDownList3.Items.Add(month);
            }
        }
        if ( DropDownList2.SelectedItem.Text == "Arbor"  ){
            List<string> months = new List<string>() { "IM1","IM3","IM4","IM5" };
            foreach (string month in months)
            {
                DropDownList3.Items.Add(month);
            }
        }
        if ( DropDownList2.SelectedItem.Text == "Ballaugh"  ){
            List<string> months = new List<string>() { "IM1","IM2","IM4","IM5" };
            foreach (string month in months)
            {
                DropDownList3.Items.Add(month);
            }
        }
        if ( DropDownList2.SelectedItem.Text == "Maughold"  ){
            List<string> months = new List<string>() { "IM1","IM2","IM3","IM5"};
            foreach (string month in months)
            {
                DropDownList3.Items.Add(month);
            }
        }
        if ( DropDownList2.SelectedItem.Text == "Michael"  ){
            List<string> months = new List<string>() { "IM1","IM2","IM3","IM4"};
            foreach (string month in months)
            {
                DropDownList3.Items.Add(month);
            }
        }
       
        if ( DropDownList2.SelectedItem.Text == "Bath"  ){
            List<string> months = new List<string>() { };
            foreach (string month in months)
            {
                DropDownList3.Items.Add(month);
            }
        }
        if ( DropDownList2.SelectedItem.Text == "Kingston upon Hull"  ){
            List<string> months = new List<string>() { "A9", "A99", "9AA", "A9A", "9AA"};
            foreach (string month in months)
            {
                DropDownList3.Items.Add(month);
            }
        }
        if ( DropDownList2.SelectedItem.Text == "Portsmouth"  ){
            List<string> months = new List<string>() { "A9","9AA","9AA", "A9A", "9AA" };
            foreach (string month in months)
            {
                DropDownList3.Items.Add(month);
            }
        }
        if ( DropDownList2.SelectedItem.Text == "Winchester"  ){
            List<string> months = new List<string>() {"A9","9AA", "A99", "A9A", "9AA" };
            foreach (string month in months)
            {
                DropDownList3.Items.Add(month);
            }
        }
        if ( DropDownList2.SelectedItem.Text == "Wolverhampton"  ){
            List<string> months = new List<string>() { "A9","9AA", "A99", "9AA", "A9A" };
            foreach (string month in months)
            {
                DropDownList3.Items.Add(month);
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)            // to enter data in database and validate user data
    {
        Label1.Text = "";
        Label2.Text = "";
        Label3.Text = "";
        Label5.Text = "";
        Label10.Text = "";
        Label6.Text = "";
        Label7.Text = "";
        Label8.Text = "";
        Label4.Text = "";
        Label11.Text = "";
        Label9.Text = "";
        String firstname = TextBox1.Text;
        String lastname = TextBox2.Text;
        String ssn = TextBox3.Text;
        string dateofbirth = TextBox8.Text;
        String email = TextBox4.Text;
        String address = TextBox5.Text;
        string country = DropDownList1.SelectedItem.Text;
        string city = DropDownList2.SelectedItem.Text;
        string pin = DropDownList3.SelectedItem.Text;
        string password = TextBox6.Text;
        string confirmpassword = TextBox7.Text;
        bool val = true;
        bool val1 = true;
        if (!validatename(firstname))
        {
            Label1.Text = "Entered name not correct";
            val = false;
        }
        if (!validatelastname(lastname))
        {

            Label2.Text = "Entered last name not correct";
            val = false;
        }
        if (ssn.Length != 6)
        {
            Label3.Text = "Entered ssn not correct";
            val = false;
        }
        if (!IsEmail(email))
        {
            Label5.Text = "Entered email not correct";
            
            val = false;
        
        }
        if (!isDuplicate(email))
        {
            val = false;
            Label5.Text = "Duplicate email already registered";
        }
        if ( address == "")
        {
            Label10.Text = "entered address not correct";
            val = false;
        }
        if (DropDownList1.SelectedItem.Text == "select your country" && val1 == true)
        {
            Label6.Text = "Enter your country first";
            val = false;
        }
        if (DropDownList2.SelectedItem.Text == "select your city" && val1 == true)
        {
         
            Label7.Text = "Entered your city first";
            val = false;
        }
        if (DropDownList3.SelectedItem.Text == "select your Pin" && val1 == true)
        {
            Label8.Text = "Enter your Pin";
            Label4.Text = "select country first";
            val = false;
        }
        if (password == "")
        {
            Label11.Text = "Enter password";
        }
        else if ( password != confirmpassword)
        {
            Label9.Text = "Entered password not matched";
            val = false;
        }
        if (Page.IsValid)
        {
            //enter in database userdata
            string x = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection s = new SqlConnection(x);
            s.Open();
            String pass= System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(password, "SHA1");      // to encrypt password
            string insertQuery = "Insert Into [dbo].[userdata] (firstname,lastname,ssn,dob,email,address,country,city,pin,password,status) VALUES (@firstname,@lastname,@ssn,@dob,@email,@address,@country,@city,@pin,@password,@status)";
            SqlCommand insrtcmd = new SqlCommand(insertQuery, s);
            insrtcmd.Parameters.AddWithValue("@firstname", firstname);
            insrtcmd.Parameters.AddWithValue("@lastname", lastname);
            insrtcmd.Parameters.AddWithValue("@ssn", ssn);
            insrtcmd.Parameters.AddWithValue("@dob", dateofbirth);
            insrtcmd.Parameters.AddWithValue("@email", email);
            insrtcmd.Parameters.AddWithValue("@address", address);
            insrtcmd.Parameters.AddWithValue("@country", country);
            insrtcmd.Parameters.AddWithValue("@city", city);
            insrtcmd.Parameters.AddWithValue("@pin", pin);
            insrtcmd.Parameters.AddWithValue("@password", pass);
            insrtcmd.Parameters.AddWithValue("@status", "0");
            //  Response.Write(firstname+lastname+ssn+dateofbirth+email+address+country+city+pin+password);
            insrtcmd.ExecuteNonQuery();      //edit for nnew values inserted
            s.Close();
            
            try
            {
                SendMail sendMail = new SendMail();
                string[] toMail = { TextBox4.Text };
                SendMail.sendMail(toMail, "New User Registration", "Username   " + TextBox4.Text + " Password " + TextBox6.Text);
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            s.Close();
            Response.Write("<script>window.alert('Registration  Sucessfull');window.location='NGO.aspx';</script>");
           // Response.Redirect("NGO.aspx");                
        }
    }

    public bool validatename(string name)      // to validate name
    {
        string MatchNamePattern = "^[a-zA-Z]*$";
        if (name != "") return Regex.IsMatch(name, MatchNamePattern);
        else return false;
    }

    public bool validatelastname(string name)       // to validate last name
    {
        string MatchNamePattern = "^[a-zA-Z]*$";
        if (name != "") return Regex.IsMatch(name, MatchNamePattern);
        else return false;
    }

    public bool IsEmail(string email)     // to validate email
    {
        string MatchEmailPattern = @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"+ @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
	    [0-9]{1,2}|25[0-5]|2[0-4][0-9])\."+ @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"+ @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})$";
        if (email != null) return Regex.IsMatch(email, MatchEmailPattern);
        else return false;
    }

    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)       
    {
        Label8.Text = "";
    }

    public bool isDuplicate(string email)      // to check duplicate email
    {
        string x = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        SqlConnection s = new SqlConnection(x);
        s.Open();
        string insertQuery = "SELECT [email] FROM [dbo].[userdata] where [email]=@sear";
        SqlCommand sc = new SqlCommand(insertQuery, s);
        sc.Parameters.AddWithValue("@sear", email);
        SqlDataReader sdr = sc.ExecuteReader();
        if (sdr.HasRows)
        {
            s.Close();
            return false;
        }
        else
        {
            s.Close();
            return true;
        }
    }
   
    protected void Button2_Click(object sender, EventArgs e)        // cancle button to redirect user back to home page
    {
        Response.Redirect("NGO.aspx");
    }
}    

