
partial class MainForm
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.DataGridView dgvTiket;
    private System.Windows.Forms.TextBox txtNama;
    private System.Windows.Forms.TextBox txtJumlah;
    private System.Windows.Forms.DateTimePicker dtTanggal;
    private System.Windows.Forms.DateTimePicker dtJamMasuk;
    private System.Windows.Forms.Button btnTambah;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.Button btnHapus;

    private void InitializeComponent()
    {
        dgvTiket = new DataGridView();
        txtNama = new TextBox();
        txtJumlah = new TextBox();
        dtTanggal = new DateTimePicker();
        dtJamMasuk = new DateTimePicker();
        btnTambah = new Button();
        btnUpdate = new Button();
        btnHapus = new Button();
        ((System.ComponentModel.ISupportInitialize)dgvTiket).BeginInit();
        SuspendLayout();
        // 
        // dgvTiket
        // 
        dgvTiket.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvTiket.Location = new Point(12, 12);
        dgvTiket.Name = "dgvTiket";
        dgvTiket.Size = new Size(500, 150);
        dgvTiket.TabIndex = 0;
        // 
        // txtNama
        // 
        txtNama.Location = new Point(12, 180);
        txtNama.Name = "txtNama";
        txtNama.PlaceholderText = "Nama Pemesan";
        txtNama.Size = new Size(200, 23);
        txtNama.TabIndex = 1;
        txtNama.TextChanged += txtNama_TextChanged;
        // 
        // txtJumlah
        // 
        txtJumlah.Location = new Point(12, 240);
        txtJumlah.Name = "txtJumlah";
        txtJumlah.PlaceholderText = "Jumlah Tiket";
        txtJumlah.Size = new Size(200, 23);
        txtJumlah.TabIndex = 3;
        // 
        // dtTanggal
        // 
        dtTanggal.Location = new Point(12, 210);
        dtTanggal.Name = "dtTanggal";
        dtTanggal.Size = new Size(200, 23);
        dtTanggal.TabIndex = 2;
        // 
        // dtJamMasuk
        // 
        dtJamMasuk.Format = DateTimePickerFormat.Time;
        dtJamMasuk.Location = new Point(12, 270);
        dtJamMasuk.Name = "dtJamMasuk";
        dtJamMasuk.ShowUpDown = true;
        dtJamMasuk.Size = new Size(200, 23);
        dtJamMasuk.TabIndex = 4;
        // 
        // btnTambah
        // 
        btnTambah.Location = new Point(250, 181);
        btnTambah.Name = "btnTambah";
        btnTambah.Size = new Size(75, 23);
        btnTambah.TabIndex = 5;
        btnTambah.Text = "Tambah";
        btnTambah.UseVisualStyleBackColor = true;
        btnTambah.Click += btnTambah_Click;
        // 
        // btnUpdate
        // 
        btnUpdate.Location = new Point(250, 210);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(75, 23);
        btnUpdate.TabIndex = 6;
        btnUpdate.Text = "Update";
        btnUpdate.UseVisualStyleBackColor = true;
        btnUpdate.Click += btnUpdate_Click;
        // 
        // btnHapus
        // 
        btnHapus.Location = new Point(250, 240);
        btnHapus.Name = "btnHapus";
        btnHapus.Size = new Size(75, 23);
        btnHapus.TabIndex = 7;
        btnHapus.Text = "Hapus";
        btnHapus.UseVisualStyleBackColor = true;
        btnHapus.Click += btnHapus_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(534, 311);
        Controls.Add(dgvTiket);
        Controls.Add(txtNama);
        Controls.Add(dtTanggal);
        Controls.Add(txtJumlah);
        Controls.Add(dtJamMasuk);
        Controls.Add(btnTambah);
        Controls.Add(btnUpdate);
        Controls.Add(btnHapus);
        Name = "MainForm";
        Text = "Booking Karaoke";
        ((System.ComponentModel.ISupportInitialize)dgvTiket).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
}
