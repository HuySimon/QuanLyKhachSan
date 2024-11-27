using HotelManagement.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.BUS
{
    internal class ThongKeBUS
    {
        private ThongKeDAO thongKeDAO;

        public ThongKeBUS()
        {
            thongKeDAO = new ThongKeDAO();
        }

        // Load dữ liệu thống kê từ DAO
        public bool LoadData(DateTime ngayBD, DateTime ngayKT)
        {
            return thongKeDAO.LoadData(ngayBD, ngayKT);
        }

        // Lấy các dữ liệu thống kê doanh thu theo ngày
        public List<ThongKeDAO.DoanhThuTheoNgay> GetDoanhThuThuongDon()
        {
            return thongKeDAO.DoanhThuThuongDonList;
        }

        public List<ThongKeDAO.DoanhThuTheoNgay> GetDoanhThuThuongDoi()
        {
            return thongKeDAO.DoanhThuThuongDoiList;
        }

        public List<ThongKeDAO.DoanhThuTheoNgay> GetDoanhThuVipDon()
        {
            return thongKeDAO.DoanhThuVipDonList;
        }

        public List<ThongKeDAO.DoanhThuTheoNgay> GetDoanhThuVipDoi()
        {
            return thongKeDAO.DoanhThuVipDoiList;
        }

        public List<ThongKeDAO.DoanhThuTheoNgay> GetDoanhThuDichVu()
        {
            return thongKeDAO.DoanhThuDichVuList;
        }

        public List<ThongKeDAO.SoPhongTheoNgay> GetSoPhongDat()
        {
            return thongKeDAO.SoPhongDatList;
        }

        public int GetSoPhongDatNum()
        {
            return thongKeDAO.SoPhongDat;
        }

        public List<KeyValuePair<string, int>> GetTopDichVu()
        {
            return thongKeDAO.TopDichVuList;
        }

        // Lấy tổng doanh thu
        public decimal GetTongDoanhThuThue()
        {
            return thongKeDAO.TongDoanhThuThue;
        }

        public decimal GetTongDoanhThuDichVu()
        {
            return thongKeDAO.TongDoanhThuDichVu;
        }

        // Các thông tin thống kê khác
        public string GetTenLoaiPhongDoanhThuCaoNhat()
        {
            return thongKeDAO.TenLoaiPhongDoanhThuCaoNhat;
        }

        public decimal GetDoanhThuLoaiPhongCaoNhat()
        {
            return thongKeDAO.DoanhThuLoaiPhongCaoNhat;
        }

        public string GetTenLoaiPhongDuocDatNhieuNhat()
        {
            return thongKeDAO.TenLoaiPhongDuocDatNhieuNhat;
        }

        public int GetSoLanLoaiPhongDatNhieuNhat()
        {
            return thongKeDAO.SoLanLoaiPhongDatNhieuNhat;
        }

        public string GetTenDichVuDoanhThuCaoNhat()
        {
            return thongKeDAO.TenDichVuDoanhThuCaoNhat;
        }

        public decimal GetDoanhThuDichVuCaoNhat()
        {
            return thongKeDAO.DoanhThuDichVuCaoNhat;
        }
    }
}

