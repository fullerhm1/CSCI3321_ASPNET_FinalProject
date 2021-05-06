using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace CSCI3321_ASPNET_FinalProject
{
    public partial class MyBooks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /// TODO: Dynamiclly build your book collection with the following information
            /// 1. Book title
            /// 2. Author's LastName and FirstName
            /// 3. Price
            /// 4. Publish date
            /// 5. Publisher's name
            /// 6. Genre
            /// 
            // 1. Create a SqlConnection object
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = WebConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;

            // 2. Create a SqlCommand object using the above connection object
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT Books.Title, Books.Price, Books.PublishDate, Authors.LastName, Authors.FirstName, Publishers.PublisherName, Genres.GenreName FROM Books INNER JOIN Authors ON Authors.AuthorID = Books.AuthorID INNER JOIN Publishers ON Publishers.PublisherID = Books.PublisherID INNER JOIN Genres ON Genres.GenreID = Books.GenreID";

            // 3. Open the connection and execute the command
            // store the returned data in a SqlDataReader object
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            // 4. if there is data in the SqlDataReader object
            // then loop through each record to build the table to display the books
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    TableRow row = new TableRow();
                    TableCell cell = new TableCell();

                    cell.Text = reader["Title"].ToString();
                    row.Cells.Add(cell);

                    cell = new TableCell();
                    cell.Text = reader["LastName"].ToString();
                    row.Cells.Add(cell);

                    cell = new TableCell();
                    cell.Text = reader["FirstName"].ToString();
                    row.Cells.Add(cell);

                    cell = new TableCell();
                    cell.Text = reader["Price"].ToString();
                    row.Cells.Add(cell);

                    cell = new TableCell();
                    cell.Text = reader["PublishDate"].ToString();
                    row.Cells.Add(cell);

                    cell = new TableCell();
                    cell.Text = reader["PublisherName"].ToString();
                    row.Cells.Add(cell);

                    cell = new TableCell();
                    cell.Text = reader["GenreName"].ToString();
                    row.Cells.Add(cell);

                    tblBookCollect.Rows.Add(row);
                }
            }
            conn.Close();
        }
    }
}