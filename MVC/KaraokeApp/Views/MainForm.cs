using KaraokeApp.Controllers;
using KaraokeApp.Models;
using System;
using System.Windows.Forms;

namespace KaraokeApp.Views
{
    public partial class MainForm : Form
    {
        private TiketController controller = new TiketController();

        public MainForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            dgvTiket.DataSource = controller.GetAll();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            Tiket tiket = new Tiket
            {
                NamaPemesan = txtNama.Text,
                TanggalPesan = dtTanggal.Value.Date,
                JumlahTiket = int.Parse(txtJumlah.Text),
                JamMasuk = dtJamMasuk.Value.TimeOfDay
            };
            controller.Tambah(tiket);
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvTiket.CurrentRow != null)
            {
                Tiket tiket = new Tiket
                {
                    Id = Convert.ToInt32(dgvTiket.CurrentRow.Cells["Id"].Value),
                    NamaPemesan = txtNama.Text,
                    TanggalPesan = dtTanggal.Value.Date,
                    JumlahTiket = int.Parse(txtJumlah.Text),
                    JamMasuk = dtJamMasuk.Value.TimeOfDay
                };
                controller.Update(tiket);
                LoadData();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvTiket.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvTiket.CurrentRow.Cells["Id"].Value);
                controller.Hapus(id);
                LoadData();
            }
        }
    }
}