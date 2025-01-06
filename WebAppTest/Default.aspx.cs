using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppTest
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["ConnCms"].ConnectionString;
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT TOP (1) Man FROM Meny ORDER BY Id DESC", conn);
                cmd.CommandType = CommandType.Text;

                SqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                reader.Close();
                conn.Close();
            }
            //sjekk hvordan indeks endres - husk å legge til labels med samme navn.
            LabelMan.Text= dt.Rows[0][0].ToString();
            LabelTir.Text= dt.Rows[0][1].ToString();
            LabelOns.Text= dt.Rows[0][2].ToString();

        }

        //kun eksempelkode som ikke har noe med kantina å gjøre
        protected void ButtonSearchLastName_Click(object sender, EventArgs e)
        {
            //SqlParameter param;
            //var connectionString = ConfigurationManager.ConnectionStrings["ConnCms"].ConnectionString;
            //DataTable dt = new DataTable();
            //using (SqlConnection conn = new SqlConnection(connectionString))
            //{
            //    conn.Open();

            //    SqlCommand cmd = new SqlCommand("SELECT * from Person where etternavn = @lastName", conn);
            //    cmd.CommandType = CommandType.Text;

            //    //params here
            //    param = new SqlParameter("@lastName", SqlDbType.NChar);
            //    param.Value = TextBoxLastName.Text; //variabel som blir sendt inn til metoden. Kommer fra bruker som tastet dette inn i et tekstfelt.
            //    cmd.Parameters.Add(param);

                

            //    SqlDataReader reader = cmd.ExecuteReader();
            //    dt.Load(reader);
            //    reader.Close();
            //    conn.Close();
            //}
            //GridView1.DataSource = dt;
            //GridView1.DataBind();
        }

        //kun eksempelkode som ikke har noe med kantina å gjøre
        protected void ButtonSearchFirstName_Click(object sender, EventArgs e)
        {
            //SqlParameter param;
            //var connectionString = ConfigurationManager.ConnectionStrings["ConnCms"].ConnectionString;
            //DataTable dt = new DataTable();
            //using (SqlConnection conn = new SqlConnection(connectionString))
            //{
            //    conn.Open();

            //    SqlCommand cmd = new SqlCommand("SELECT * from Person where fornavn = @forNavn", conn);
            //    cmd.CommandType = CommandType.Text;

            //    //params here
            //    param = new SqlParameter("@forNavn", SqlDbType.NChar);
            //    param.Value = TextBoxFirstName.Text; //variabel som blir sendt inn til metoden. Kommer fra bruker som tastet dette inn i et tekstfelt.
            //    cmd.Parameters.Add(param);



            //    SqlDataReader reader = cmd.ExecuteReader();
            //    dt.Load(reader);
            //    reader.Close();
            //    conn.Close();
            //}
            //GridView1.DataSource = dt;
            //GridView1.DataBind();
        }
    }
}
