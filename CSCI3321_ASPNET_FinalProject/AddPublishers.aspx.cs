﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;

namespace CSCI3321_ASPNET_FinalProject
{
    public partial class AddPublishers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddPublisher_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = WebConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "INSERT INTO Publishers VALUES ('" + txtPublishname.Text + "', '" + txtAddress.Text + "', '" + txtCity.Text + "', '" + txtPostcode.Text + "', '" + txtCountry.Text + "', '" + txtPhone.Text + "')";

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}