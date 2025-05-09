
using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
        LoadData();
    }

    private void LoadData()
    {
        using (MySqlConnection conn = Koneksi.GetConnection())
        {
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM Tiket", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvTiket.DataSource = dt;
        }
    }

    private void btnTambah_Click(object sender, EventArgs e)
    {
        using (MySqlConnection conn = Koneksi.GetConnection())
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO Tiket (NamaPemesan, TanggalPesan, JumlahTiket, JamMasuk) VALUES (@nama, @tanggal, @jumlah, @jam)", conn);
            cmd.Parameters.AddWithValue("@nama", txtNama.Text);
            cmd.Parameters.AddWithValue("@tanggal", dtTanggal.Value.Date);
            cmd.Parameters.AddWithValue("@jumlah", int.Parse(txtJumlah.Text));
            cmd.Parameters.AddWithValue("@jam", dtJamMasuk.Value.ToString("HH:mm:ss"));
            cmd.ExecuteNonQuery();
        }
        LoadData();
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        if (dgvTiket.CurrentRow != null)
        {
            int id = Convert.ToInt32(dgvTiket.CurrentRow.Cells["Id"].Value);
            using (MySqlConnection conn = Koneksi.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE Tiket SET NamaPemesan=@nama, TanggalPesan=@tanggal, JumlahTiket=@jumlah, JamMasuk=@jam WHERE Id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nama", txtNama.Text);
                cmd.Parameters.AddWithValue("@tanggal", dtTanggal.Value.Date);
                cmd.Parameters.AddWithValue("@jumlah", int.Parse(txtJumlah.Text));
                cmd.Parameters.AddWithValue("@jam", dtJamMasuk.Value.TimeOfDay);
                cmd.ExecuteNonQuery();
            }
            LoadData();
        }
    }

    private void btnHapus_Click(object sender, EventArgs e)
    {
        if (dgvTiket.CurrentRow != null)
        {
            int id = Convert.ToInt32(dgvTiket.CurrentRow.Cells["Id"].Value);
            using (MySqlConnection conn = Koneksi.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM Tiket WHERE Id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            LoadData();
        }
    }

    private void txtNama_TextChanged(object sender, EventArgs e)
    {

    }
}
