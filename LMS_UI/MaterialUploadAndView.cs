using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace LMS_UI
{
    public partial class MaterialUploadAndView : Form
    {
        string connectionString = "Server=DESKTOP-NIPH6M9\\SQLEXPRESS;Database=LMS_DB;Trusted_Connection=True;";
        SqlConnection con = new SqlConnection();
        SqlCommand cmd;

        public MaterialUploadAndView()
        {
            InitializeComponent();
            BindGrid();
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.ConnectionString = connectionString;
                con.Open();

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog1.FileName;
                    string fileName = Path.GetFileName(filePath);
                    string ext = Path.GetExtension(fileName);
                    string type = String.Empty;
                    if (ext.Equals(".pdf"))
                    {
                        type = "application/pdf";
                    }
                    if (type != String.Empty)
                    {
                        
                        Byte[] bytes = File.ReadAllBytes(filePath);
                        string query = "insert into Material(Name,Type,Material) Values(@Name,@Type,@data)";
                        cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@Name", fileName);
                        cmd.Parameters.AddWithValue("@Type", type);
                        cmd.Parameters.AddWithValue("@data", bytes);

                        //cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = fileName;
                        //cmd.Parameters.Add("@Type", SqlDbType.NVarChar).Value = type;
                        //cmd.Parameters.Add("@data", SqlDbType.Binary).Value = bytes;

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("INSERTED SUCCESSFULLY");
                        con.Close();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
            //MessageBox.Show(filePath + "\r\n"+fileName + ext);
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string path = openFileDialog1.FileName;
                    string fileName = Path.GetFileName(path);
                    byte[] bytes = File.ReadAllBytes(path);
                    string contentType = "";
                    //Set the contenttype based on File Extension

                    switch (Path.GetExtension(fileName))
                    {
                        case ".pdf":
                            contentType = "file/.pdf";
                            break;
                        case ".jpg":
                            contentType = "image/jpeg";
                            break;
                        case ".png":
                            contentType = "image/png";
                            break;
                        case ".gif":
                            contentType = "image/gif";
                            break;
                        case ".bmp":
                            contentType = "image/bmp";
                            break;
                    }

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string sql = "INSERT INTO Material(Name,Type,Material) VALUES(@Name, @ContentType, @Data)";
                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@Name", fileName);
                            cmd.Parameters.AddWithValue("@ContentType", contentType);
                            cmd.Parameters.AddWithValue("@Data", bytes);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                    }
                    
                }
            }
            BindGrid();
        }
        private void BindGrid()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("select Material_Id, Name from Material", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
                con.Close();
            }
        }
        private void MaterialUploadAndView_Load(object sender, EventArgs e)
        {
            //BindGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int id = Convert.ToInt16((row.Cells[0].Value));
                byte[] bytes;
                string fileName, contentType;
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "select Name, Material, type from Material where Material_Id=@Id";
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.Connection = con;
                        con.Open();
                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            sdr.Read();
                            bytes = (byte[])sdr["Material"];
                            contentType = sdr["Type"].ToString();
                            fileName = sdr["Name"].ToString();

                            Stream stream;
                            SaveFileDialog saveFileDialog = new SaveFileDialog();
                            saveFileDialog.Filter = "All files (*.*)|*.*";
                            saveFileDialog.FilterIndex = 1;
                            saveFileDialog.RestoreDirectory = true;
                            saveFileDialog.FileName = fileName;
                            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                            {
                                stream = saveFileDialog.OpenFile();
                                stream.Write(bytes, 0, bytes.Length);
                                stream.Close();
                            }
                        }
                    }
                    con.Close();
                }
            }

        }
    }
}