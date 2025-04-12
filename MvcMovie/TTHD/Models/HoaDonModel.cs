namespace TTHD.Models
{
    public class HoaDonModel
    {
        public int SoLuong { get; set; }
        public double DonGia { get; set; }
        public double ThanhTien => SoLuong * DonGia;
    }
}
