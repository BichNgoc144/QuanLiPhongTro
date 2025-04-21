using Microsoft.AspNetCore.Identity;

namespace QuanLiPhongTro.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string ? HoTen { get; set; }
        public string? SoDienThoai { get; set; }
        public override string Email { get; set; }

    }
}
