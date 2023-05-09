using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


public partial class StaffDataEntry : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Generate and assign a unique ID number
        string connectionString = "YourConnectionString";
        SqlConnection conn = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Staff", conn);
        conn.Open();
        int count = (int)cmd.ExecuteScalar();
        conn.Close();
        string staffID = "S" + (count + 1).ToString("D4");
        StaffID.Text = staffID;
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        // Insert staff data into the database
        string connectionString = "D:/Program Files/Microsoft SQL Server/MSSQL14.MSSQLSERVER/MSSQL/DATA/p2720877.mdf";
        SqlConnection conn = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand("INSERT INTO dbo.tblStaff (FirstName, LastName, Address, Email, Phone, Gender) VALUES (@StaffID, @FirstName, @LastName, @Address, @Email, @Phone, @Gender)", conn);
      
        cmd.Parameters.AddWithValue("@FirstName", FirstName.Text);
        cmd.Parameters.AddWithValue("@LastName", LastName.Text);
        cmd.Parameters.AddWithValue("@Address", address.Text);
        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
        cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
        cmd.Parameters.AddWithValue("@Gender", ddlGender.SelectedValue);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();

        // Redirect to home page
        Response.Redirect("home.aspx");
    }
}
