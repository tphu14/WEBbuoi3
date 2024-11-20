using Microsoft.AspNetCore.Mvc;
using System.Linq;


public class StudentController : Controller
{
    
    public ActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public ActionResult ShowKQ(string MSSV, string HoTen, float DiemTB, string ChuyenNganh)
    {
        
        var sinhVienDangKy = new[]
        {
            new { MSSV = "001", HoTen = "Nguyen Van A", ChuyenNganh = "CNPM" },
            new { MSSV = "002", HoTen = "Le Thi B", ChuyenNganh = "HTTT" }
        };

   
        int soLuong = sinhVienDangKy.Count(sv => sv.ChuyenNganh == ChuyenNganh);

        
        ViewBag.MSSV = MSSV;
        ViewBag.HoTen = HoTen;
        ViewBag.ChuyenNganh = ChuyenNganh;
        ViewBag.SoLuong = soLuong;

        return View();
    }
}
