using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach2
{
    internal class MainClass
    {
        public static void BlurBackground(Form model)
        {
            Form background = new Form();
            using (model)
            {
                background.StartPosition = FormStartPosition.Manual;
                background.FormBorderStyle = FormBorderStyle.None;
                background.Opacity = 0.5d;
                background.BackColor = Color.Black;
                background.Size = frmMain.Instance.Size;
                background.Location = frmMain.Instance.Location;
                background.ShowInTaskbar = false;
                background.Show();
                model.Owner = background;
                model.ShowDialog(background);
                background.Dispose();
            }
        }
        Ketnoi kn = new Ketnoi();

        public DataTable LoadData(string sqr)
        {
            SqlCommand cmd = new SqlCommand(sqr, kn.connection());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        // Catalog Table
        public void message(string sqr, string name)
        {
            DataTable dt = new DataTable();
            dt = AddData(sqr, name);
            MessageBox.Show(dt.Rows[0]["errmsg"].ToString());
        }
        public void message_edit(string sqr, int id, string name)
        {
            DataTable dt = new DataTable();
            dt = EditData(sqr, id, name);
            MessageBox.Show(dt.Rows[0]["errmsg"].ToString());
        }
        public void message_delete(string sqr, int id)
        {
            DataTable dt = new DataTable();
            dt = DeleteData(sqr, id);
            MessageBox.Show(dt.Rows[0]["errmsg"].ToString());


        }
        public DataTable AddData(string sqr, string name)
        {
            SqlCommand cmd = new SqlCommand(sqr, kn.connection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@catename", name);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable EditData(string sqr, int id, string name)
        {
            SqlCommand cmd = new SqlCommand(sqr, kn.connection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@catename", name);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable DeleteData(string sqr, int id)
        {
            SqlCommand cmd = new SqlCommand(sqr, kn.connection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable Search(string sqr, string name)
        {
            SqlCommand cmd = new SqlCommand(sqr, kn.connection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name ", name);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable ComboboxFill(string sqr, ComboBox cb)
        {
            SqlCommand cmd = new SqlCommand(sqr, kn.connection());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;


        }
    }
}
