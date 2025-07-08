using System;

namespace KaraokeApp.Models
{
    public class Tiket
    {
        public int Id { get; set; }
        public string NamaPemesan { get; set; }
        public DateTime TanggalPesan { get; set; }
        public int JumlahTiket { get; set; }
        public TimeSpan JamMasuk { get; set; }
    }
}