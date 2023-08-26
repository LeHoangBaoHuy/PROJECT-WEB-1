using Microsoft.AspNetCore.Mvc;

namespace PROJECT_WEB.Controllers
{
    public class TongHaiSoController : Controller
    {
        [HttpGet] //mặc định
        public IActionResult TongHaiSo()
        {
            ViewData["ThongBao"] = "";
            return View();
        }
        [HttpPost]
        public IActionResult TongHaiSo(int soNguyen1, int soNguyen2) //khi sử dụng HttpGet cho hàm này phải thay public bằng private.
                                                                     //khi gán biến không phân biệt viết hoa hay viết thường nhưng phải đúng tên biến
        {
            try
            {
                int tong = soNguyen1 / soNguyen2;
                ViewData["soNguyen1"] = soNguyen1; //ViewData có phân biệt hoa thường.
                ViewData["soNguyen2"] = soNguyen2;

                ViewData["KetQua"] = tong; // ViewData dung để truyền dữ liệu từ Controller về View.
                ViewData["ThongBao"] = "";
            }
            catch(DivideByZeroException e)
            {
                ViewData["ThongBao"] = "Khong duoc chia cho 0";
            }
            catch (Exception e) {
                ViewData["ThongBao"] = e.Message;
            }
            

            return View();
        }
    }
}
