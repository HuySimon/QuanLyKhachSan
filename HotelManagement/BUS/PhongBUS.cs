using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;
using HotelManagement.DTO;
using HotelManagement.DAO;
using System.Data;
using System.Windows.Forms;

namespace HotelManagement.BUS
{
    internal class PhongBUS
    {
        private static PhongBUS instance;
        public static PhongBUS Instance
        {
            get { if (instance == null) instance = new PhongBUS(); return instance; }
            private set { instance = value; }
        }
        private PhongBUS() { }
        public List<Phong> GetAllPhong()
        {
            return PhongDAO.Instance.GetAllPhongs();
        }
        public Phong FindePhong(string MaPh)
        {
            return PhongDAO.Instance.FindPhong(MaPh);
        }
        public List<Phong> FindPhongWithMaPH(string MaPh)
        {
            return PhongDAO.Instance.FindPhongWithMaPH(MaPh);
        }
        public void UpdateOrAdd(Phong phong)
        {
            PhongDAO.Instance.UpdateOrAdd(phong);
        }
        public List<Phong> FindPhongTrong(DateTime Checkin, DateTime Checkout, List<CTDP> DSPhongThem)
        {
            return PhongDAO.Instance.FindPhongTrong(Checkin, Checkout, DSPhongThem);   
        }
        public void RemovePhong(string maPH)
        {
            PhongDAO.Instance.RemovePhong(maPH);
        }

        public bool GetPhongByMaPH(string maPH) => PhongDAO.Instance.GetPhongById(maPH);

        public DataTable ImportFormExcelToDataTable(string filename)
        {
            DataTable dataTable = new DataTable();
            DataTable dataTable1 = new DataTable();
            DataTable result = dataTable;
            DataTable temp = dataTable1;
            bool isHeader = true;
            // Sử dụng FileStream để mở tệp Excel
            using (var wb = new XLWorkbook(filename))
            {
                var ws = wb.Worksheet(1);
                // Lấy tên của các cột từ dòng header (dòng đầu tiên)
                foreach (var row in ws.RowsUsed())
                {
                    if (row.CellsUsed().Any(cell => !string.IsNullOrEmpty(cell.Value.ToString())))
                    {
                        if (isHeader)
                        {
                            foreach (var cell in row.Cells())
                            {
                                temp.Columns.Add(cell.Value.ToString());
                            }
                            isHeader = false;
                        }
                        else
                        {
                            DataRow dataRow = temp.NewRow();
                            int colIndex = 0;
                            foreach (var cell in row.Cells())
                            {
                                if (colIndex < temp.Columns.Count)
                                {
                                    dataRow[colIndex++] = cell.Value;
                                }
                                else
                                {
                                    // MessageBox.Show("Not fit !");
                                }
                            }
                            temp.Rows.Add(dataRow);
                        }
                    }
                }
                result = sort(temp);// sort dựa trên cột ID truyền vào 

            }
            return result;
        }

        private DataTable sort(DataTable dt)
        {
            DataTable dataTable = new DataTable();
            DataTable sortedTable = dataTable;
            try
            {
                if (dt != null && dt.Rows.Count > 0)
                {
                    DataView dv = dt.DefaultView;
                    dv.Sort = "MaPH ASC";
                    sortedTable = dv.ToTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return sortedTable;
        }

        //public List<Phong> ImportFormExcelToList(string filename)
        //{
        //    List<Phong> phongList = new List<Phong>();
        //    bool isHeader = true;

        //    // Sử dụng ClosedXML để mở tệp Excel
        //    using (var wb = new XLWorkbook(filename))
        //    {
        //        var ws = wb.Worksheet(1);

        //        // Duyệt qua từng hàng của worksheet
        //        foreach (var row in ws.RowsUsed())
        //        {
        //            if (row.CellsUsed().Any(cell => !string.IsNullOrEmpty(cell.Value.ToString())))
        //            {
        //                if (isHeader)
        //                {
        //                    // Bỏ qua hàng tiêu đề (header)
        //                    isHeader = false;
        //                }
        //                else
        //                {
        //                    // Tạo đối tượng Phong mới
        //                    Phong phong = new Phong();
        //                    int colIndex = 0;

        //                    foreach (var cell in row.Cells())
        //                    {
        //                        switch (colIndex)
        //                        {
        //                            case 0:
        //                                phong.MaPH = cell.Value.ToString();
        //                                break;
        //                            case 1:
        //                                phong.TTPH = cell.Value.ToString();
        //                                break;
        //                            case 2:
        //                                phong.TTDD = cell.Value.ToString();
        //                                break;
        //                            case 3:
        //                                phong.GhiChu = cell.Value.ToString(); // GhiChu có thể null
        //                                break;
        //                            case 4:
        //                                phong.MaLPH = cell.Value.ToString();
        //                                break;
        //                            case 5:
        //                                phong.DaXoa = Convert.ToBoolean(cell.Value);
        //                                break;
        //                        }
        //                        colIndex++;
        //                    }

        //                    // Kiểm tra xem mã phòng đã tồn tại hay chưa
        //                    //if (!KiemTraMaPhongTonTai(phong.MaPH))
        //                    //{
        //                    //    // Thêm đối tượng Phong vào danh sách nếu mã phòng chưa tồn tại
        //                    //    phongList.Add(phong);
        //                    //}
        //                    //else
        //                    //{
        //                    //    Console.WriteLine($"Mã phòng {phong.MaPH} đã tồn tại trong hệ thống.");
        //                    //}
        //                    phongList.Add(phong);
        //                }
        //            }
        //        }
        //    }

        //    // Trả về danh sách phòng đã import từ Excel
        //    return phongList.OrderBy(p => p.MaPH).ToList(); // Sắp xếp theo mã phòng
        //}
    }
}
