using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace album
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection sql = new SqlConnection("Data Source=DESKTOP-J6DB392\\SQLEXPRESS;Initial Catalog=Plack;Integrated Security=True;");

        private void splcmd()
        {
            sql.Open();
            SqlCommand cmd = new SqlCommand("select * from Song", sql);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                likesong.ColumnCount = 7;
                likesong.Columns[0].Name = "Album name";   
                likesong.Columns[1].Name = "Album history";
                likesong.Columns[2].Name = "Albums owner";
                likesong.Columns[3].Name = "Album's song";
                likesong.Columns[4].Name = "Time";
                likesong.Columns[5].Name = "TOTALtime";
                likesong.Columns[6].Name = "Like's song";
                likesong.Rows.Add();
                likesong.Rows[likesong.Rows.Count - 1].Cells[0].Value = dr["Album name"].ToString();
                likesong.Rows[likesong.Rows.Count - 1].Cells[1].Value = dr["Album history"].ToString();
                likesong.Rows[likesong.Rows.Count - 1].Cells[2].Value = dr["Albums owner"].ToString();
                likesong.Rows[likesong.Rows.Count - 1].Cells[3].Value = dr["Album's song"].ToString();
                likesong.Rows[likesong.Rows.Count - 1].Cells[4].Value = dr["Time"].ToString();
                likesong.Rows[likesong.Rows.Count - 1].Cells[5].Value = dr["TOTALtime"].ToString();
                likesong.Rows[likesong.Rows.Count - 1].Cells[6].Value = dr["Like's song"].ToString();

            }
            sql.Close();
        }

        private void Albumviem_Click(object sender, EventArgs e)
        {
            splcmd();
            Albumviem.BackColor = Color.FromArgb(137, 243, 54);
        }

        private void albumadd_Click(object sender, EventArgs e)
        {
            sql.Open();
            SqlCommand cmd = new SqlCommand("insert into Song([Album name],[Album history],[Albums owner],[Album's song],[Time],[TOTALtime],[Like's song]) values(@name,@history,@owner,@song,@time,@total,@like)", sql);
            cmd.Parameters.AddWithValue("@name", Albumname_text.Text);
            cmd.Parameters.AddWithValue("@history", albumhistory_text.Text);
            cmd.Parameters.AddWithValue("@owner", Albumowner_text.Text);
            cmd.Parameters.AddWithValue("@song", Albumsong_text.Text);
            cmd.Parameters.AddWithValue("@time", Albumtime_text.Text);
            cmd.Parameters.AddWithValue("@total",totaltime_text.Text);
            cmd.Parameters.AddWithValue("@like", likesong_text.Text);
            cmd.ExecuteNonQuery();
            splcmd();
            sql.Close();
        }

    }
}
