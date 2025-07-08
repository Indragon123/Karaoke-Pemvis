using KaraokeApp.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace KaraokeApp.Controllers
{
    public class TiketController
    {
        public List<Tiket> GetAll()
        {
            List<Tiket> list = new List<Tiket>();
            using (MySqlConnection conn = Koneksi.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Tiket", conn);
                using (var reader = cmd.ExecuteReader())
                {
while (reader.Read())
{
                            string rawJam = reader.GetString("JamMasuk");
                            TimeSpan jamMasuk;

                            if (!TimeSpan.TryParse(rawJam, out jamMasuk))
                            {
                                if (rawJam.Contains(' '))
                                {
                                    rawJam = rawJam.Split(' ')[1];
                                    TimeSpan.TryParse(rawJam, out jamMasuk);
                                }
                            }

                            list.Add(new Tiket
                            {
                                Id = reader.GetInt32("Id"),
                                NamaPemesan = reader.GetString("NamaPemesan"),
                                TanggalPesan = reader.GetDateTime("TanggalPesan"),
                                JumlahTiket = reader.GetInt32("JumlahTiket"),
                                JamMasuk = jamMasuk
                            });
}

                }
            }
            return list;
        }

        public void Tambah(Tiket tiket)
        {
            using (MySqlConnection conn = Koneksi.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO Tiket (NamaPemesan, TanggalPesan, JumlahTiket, JamMasuk) VALUES (@nama, @tanggal, @jumlah, @jam)", conn);
                cmd.Parameters.AddWithValue("@nama", tiket.NamaPemesan);
                cmd.Parameters.AddWithValue("@tanggal", tiket.TanggalPesan);
                cmd.Parameters.AddWithValue("@jumlah", tiket.JumlahTiket);
                cmd.Parameters.AddWithValue("@jam", tiket.JamMasuk);
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(Tiket tiket)
        {
            using (MySqlConnection conn = Koneksi.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE Tiket SET NamaPemesan=@nama, TanggalPesan=@tanggal, JumlahTiket=@jumlah, JamMasuk=@jam WHERE Id=@id", conn);
                cmd.Parameters.AddWithValue("@id", tiket.Id);
                cmd.Parameters.AddWithValue("@nama", tiket.NamaPemesan);
                cmd.Parameters.AddWithValue("@tanggal", tiket.TanggalPesan);
                cmd.Parameters.AddWithValue("@jumlah", tiket.JumlahTiket);
                cmd.Parameters.AddWithValue("@jam", tiket.JamMasuk);
                cmd.ExecuteNonQuery();
            }
        }

        public void Hapus(int id)
        {
            using (MySqlConnection conn = Koneksi.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM Tiket WHERE Id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}