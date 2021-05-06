using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;

namespace CSCI3321_ASPNET_FinalProject
{
    public partial class AddBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddBook_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = WebConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "INSERT INTO Books (Title, AuthorID, Price, PublishDate, PublisherID, GenreID) VALUES ('" + txtBooktitle.Text + "', '" + ddlAuthor.SelectedValue + "', '" + txtPrice.Text + "', '" + txtPublishdate.Text + "', '" + ddlPublishers.SelectedValue + "', '" + ddlGenres.SelectedValue + "')";

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}