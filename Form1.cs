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

        private void splcmd(string newad)
        {
            SqlDataAdapter sqlData = new SqlDataAdapter(newad,sql);
            DataSet dataSet = new DataSet();
            sqlData.Fill(dataSet, "Song");
            likesong.DataSource = dataSet.Tables[0];
        }

        private void Albumviem_Click(object sender, EventArgs e)
        {
            splcmd("Select *from song");
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
            sql.Close();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            Albumtime_text.Text = "";
            Albumname_text.Text = "";
            albumhistory_text.Text = "";
            Albumowner_text.Text = "";
            Albumsong_text.Text = "";
            likesong_text.Text = "";
            clear.BackColor = Color.FromArgb(137, 243, 54);
        }

        private void Albumviem_MouseLeave(object sender, EventArgs e)
        {
            Albumviem.BackColor = Color.FromArgb(0, 192, 0);

        }
        private void clear_MouseLeave(object sender, EventArgs e)
        {
            clear.BackColor = Color.FromArgb(0, 192, 0);
        }

    }
}
