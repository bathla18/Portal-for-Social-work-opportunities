using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)           // 
    {
        if (Session["user"] == null)  // checking condition for login
        {
            Response.Redirect("NGO.aspx");
        }
        else if ( Session["check"].ToString() == "pageload"){      // to show recommended opportunity to user acc to his / her city
        
            Label2.Text = Session["user"].ToString();
            Label1.Text = "Recommended opportunities";
            string x = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection s = new SqlConnection(x);
            s.Open();
            string insertQuery = "SELECT [name],[ngoname],[description],[country],[city],[startdate],[duration] FROM [dbo].[opportunity] where [city] = @city";
            SqlCommand sc = new SqlCommand(insertQuery, s);
            sc.Parameters.AddWithValue("@city", Session["city"].ToString());
            SqlDataReader sdr = sc.ExecuteReader();
            
            int i;
            if (sdr.HasRows)
            {
                int u = 0;
                while (sdr.Read())
                {
                    TableRow tRow = new TableRow();
                    Table1.Rows.Add(tRow);
                    for ( i = 0; i < 8; i++)
                    {
                        TableCell tCell = new TableCell();
                        if (i == 7)
                        {
                            Button btn = new Button();

                            btn.Style.Add("color", "red");
                            btn.Text = "Apply";
                            btn.Click += new EventHandler(btn_Click);
                            
                            tCell.Controls.Add(btn);
                            tRow.Cells.Add(tCell);
                        }
                        else
                        {
                            tCell.Text = sdr[i].ToString();
                            tRow.Cells.Add(tCell);
                        }
                    }
                    u++;
                }
                Label7.Text = u.ToString();
            }
            
            s.Close();
        }
        else if (Session["check"].ToString() == "total")       // to show all opportunity in system
        {
       
            Label2.Text = Session["user"].ToString();
            Label1.Text = "Total Opportunity";
            string x1 = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection s1 = new SqlConnection(x1);
            s1.Open();
            string x = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection s = new SqlConnection(x);
            s.Open();
            string insertQuery = "SELECT [name],[ngoname],[description],[country],[city],[startdate],[duration] FROM [dbo].[opportunity]";
            string insertQuery1 = "select count(*) as [count] from [dbo].[opportunity]";
            SqlCommand sc = new SqlCommand(insertQuery, s);
            SqlCommand sc1 = new SqlCommand(insertQuery1, s1);
            SqlDataReader sdr = sc.ExecuteReader();
            SqlDataReader sdr1 = sc1.ExecuteReader();
            if (sdr1.HasRows)
            {
                while (sdr1.Read())
                {
                    Label4.Text = sdr1[0].ToString();
                }
            }
            int u = 0;
            int i;
            if (sdr.HasRows)
            {

                while (sdr.Read())
                {
                    TableRow tRow = new TableRow();
                    Table1.Rows.Add(tRow);
                    for (i = 0; i < 8; i++)
                    {
                        TableCell tCell = new TableCell();
                        if (i == 7)
                        {
                            Button btn = new Button();
                            btn.Style.Add("color", "red");
                            btn.Text = "Apply";
                            btn.Click += new EventHandler(btn_Click);
                            tCell.Controls.Add(btn);
                            tRow.Cells.Add(tCell);
                        }
                        else
                        {
                            tCell.Text = sdr[i].ToString();
                            tRow.Cells.Add(tCell);
                        }
                    }
                    u++;
                }
            }
            s1.Close();
            s.Close();
            
        }
        else if (Session["check"].ToString() == "history")     // to show history of user
        {
            Label2.Text = Session["user"].ToString();
            Label1.Text = "History";

           
            string x1 = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection s1 = new SqlConnection(x1);
            s1.Open();
            string x = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection s = new SqlConnection(x);
            s.Open();
            string insertQuery = "SELECT [oppname],[ngoname],[description],[country],[city],[start],[duration] FROM [dbo].[useropp] where [Email] = @email and [start] < GETDATE()";
            string insertQuery1 = "select count(*) as [count] from [dbo].[useropp] where [email] = @email1 and [start] < GETDATE()";
            SqlCommand sc = new SqlCommand(insertQuery, s);
            SqlCommand sc1 = new SqlCommand(insertQuery1, s1);
            sc.Parameters.AddWithValue("@email", Session["Email"].ToString());
            sc1.Parameters.AddWithValue("@email1", Session["Email"].ToString());
            SqlDataReader sdr = sc.ExecuteReader();
            SqlDataReader sdr1 = sc1.ExecuteReader();
            if (sdr1.HasRows)
            {
                while (sdr1.Read())
                {
                    Label5.Text = sdr1[0].ToString();
                }
            }
            int i;
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    TableRow tRow = new TableRow();
                    Table1.Rows.Add(tRow);
                    for (i = 0; i < 8; i++)
                    {
                        TableCell tCell = new TableCell();
                        if (i == 7)
                        {
                            Button btn = new Button();
                            btn.Style.Add("color", "red");
                            btn.Text = "Withdraw";
                            btn.Click += new EventHandler(btn_Click);
                            tCell.Controls.Add(btn);
                            tRow.Cells.Add(tCell);

                        }
                        else
                        {
                            tCell.Text = sdr[i].ToString();
                            tRow.Cells.Add(tCell);
                        }
                    }
                }
            }
            s1.Close();
            s.Close();
           
        }
        else if (Session["check"].ToString() == "myopportunity")    // to show applied opportunity to user which will start in future
        {
       
            Label2.Text = Session["user"].ToString();
            Label1.Text = "My Opportunity";

            string x1 = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection s1 = new SqlConnection(x1);
            s1.Open();
            string x = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection s = new SqlConnection(x);
            s.Open();
            string insertQuery = "SELECT [oppname],[ngoname],[description],[country],[city],[start],[duration] FROM [dbo].[useropp] where [Email] = @email and [start] > GETDATE()";
            string insertQuery1 = "select count(*) as [count] from [dbo].[useropp] where [email] = @email1 and [start] > GETDATE()";
            SqlCommand sc = new SqlCommand(insertQuery, s);
            SqlCommand sc1 = new SqlCommand(insertQuery1, s1);
            sc1.Parameters.AddWithValue("@email1", Session["Email"].ToString());
            sc.Parameters.AddWithValue("@email", Session["Email"].ToString());
            SqlDataReader sdr = sc.ExecuteReader();
            SqlDataReader sdr1 = sc1.ExecuteReader();
            if (sdr1.HasRows)
            {
                while (sdr1.Read())
                {
                    Label6.Text = sdr1[0].ToString();
                }
            }
            int u = 0;
            int i;
            if (sdr.HasRows)
            {
                while (sdr.Read())
                {
                    TableRow tRow = new TableRow();
                    Table1.Rows.Add(tRow);
                    for (i = 0; i < 8; i++)
                    {
                        TableCell tCell = new TableCell();
                        if (i == 7)
                        {
                            Button btn = new Button();
                            btn.Style.Add("color", "red");
                            btn.Text = "Withdraw";
                            btn.Click += new EventHandler(btn_Click);
                            tCell.Controls.Add(btn);
                            tRow.Cells.Add(tCell);
                        }
                        else
                        {
                            tCell.Text = sdr[i].ToString();
                            tRow.Cells.Add(tCell);
                        }
                    }
                    u++;
                }
            }
            s1.Close();
            s.Close();
        }
        else if (Session["check"].ToString() == "searchopp")            // to show search opportunity which user entered on homepage
        {
            Label2.Text = Session["user"].ToString();
            Label1.Text = "Search Opportunity";
            string x = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection s = new SqlConnection(x);
            s.Open();
            string insertQuery = "SELECT [name],[ngoname],[description],[country],[city],[startdate],[duration] FROM [dbo].[opportunity] where [name] = @search";
            SqlCommand sc = new SqlCommand(insertQuery, s);
            sc.Parameters.AddWithValue("@search", Session["search"].ToString());
            SqlDataReader sdr = sc.ExecuteReader();
            int u = 0;
            int i;
            if (sdr.HasRows)
            {
                
                while (sdr.Read())
                {
                    TableRow tRow = new TableRow();
                    Table1.Rows.Add(tRow);
                    for ( i = 0; i < 8; i++)
                    {
                        TableCell tCell = new TableCell();
                        if (i == 7)
                        {
                            Button btn = new Button();
                            btn.Style.Add("color", "red");
                            btn.Text = "Apply";
                            btn.Click += new EventHandler(btn_Click);
                            tCell.Controls.Add(btn);
                            tRow.Cells.Add(tCell);
                        }
                        else
                        {
                            tCell.Text = sdr[i].ToString();
                            tRow.Cells.Add(tCell);
                        }
                    }
                    u++;
                }
            }
            s.Close();
        }
        
    }

    void btn_Click(object sender, EventArgs e)      // to enter button in table and define it's function 
    {
        Button button = sender as Button;
        TableCell cell = button.Parent as TableCell;
        TableRow row = cell.Parent as TableRow;
        int index = Table1.Rows.GetRowIndex(row);
        string s = Table1.Rows[index].Cells[0].Text;
        
        Session["Search"] = s;
        Response.Redirect("opportunitypage.aspx");
     
    }

    protected void LinkButton1_Click(object sender, EventArgs e)       // to show total op.
    {
       Session["check"] = "total";
       Response.Redirect("volunteerlanding.aspx");
    }

    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Session["check"] = "history";
        Response.Redirect("volunteerlanding.aspx");
    }

    protected void LinkButton3_Click(object sender, EventArgs e)
    {
     
        Session["check"] = "myopportunity";
        Response.Redirect("volunteerlanding.aspx");

    }

    protected void Button1_Click(object sender, EventArgs e)        // to search opportunity in system and redirect user to opportunity page
    {
        String search = TextBox1.Text;
        //query for database and open opportunity page for that opportunity 
        string x = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        SqlConnection s = new SqlConnection(x);
        s.Open();
        string insertQuery = "SELECT [name] FROM [dbo].[opportunity] where [name] = @sear";
        SqlCommand sc = new SqlCommand(insertQuery, s);
        sc.Parameters.AddWithValue("@sear", search);
        SqlDataReader sdr = sc.ExecuteReader();
        if (sdr.HasRows)
        {
           
            while (sdr.Read())
            {
                Session["search"] = sdr[0].ToString();
                Response.Write(Session["search"].ToString());
                break;
            }
            s.Close();
           
            Response.Redirect("opportunitypage.aspx");
        }
        else
        {
            
            Label3.Text = "not found";

        }
        s.Close();
    }

    protected void LinkButton4_Click(object sender, EventArgs e)  // logout button to logout from system
    {
        Session.Contents.RemoveAll();
        Response.Redirect("NGO.aspx");
    }
    protected void LinkButton5_Click(object sender, EventArgs e)     // to show recommend opportuntiy 
    {
        Session["check"] = "pageload";
        Response.Redirect("volunteerlanding.aspx");
    }
}

