using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyNotesApp
{
    public partial class Form1 : Form
    {
        // Connection string ke database lokal
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Hp\\Documents\\NotesDB.mdf;Integrated Security=True;Connect Timeout=30";
        public Form1()
        {
            InitializeComponent();
            LoadNotes();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
       
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Notes (Title, Content) VALUES (@title, @content)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@title", titleTxt.Text);
                cmd.Parameters.AddWithValue("@content", contentTxt.Text);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Catatan berhasil disimpan!");
            LoadNotes();
            titleTxt.Clear();
            contentTxt.Clear();
        }

        private void LoadNotes()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Id, Title, CreatedAt FROM Notes ORDER BY CreatedAt DESC";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                notesGrid.DataSource = dt;
            }
        }

        private void notesGrid_CellDoubleClick( object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(notesGrid.Rows[e.RowIndex].Cells["Id"].Value);
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Content FROM Notes Where Id=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                string content = cmd.ExecuteScalar().ToString();
                MessageBox.Show(content, "Isi Catatan");
            }
        }
    }
}
