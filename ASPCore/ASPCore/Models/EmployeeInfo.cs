using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCore.Models
{
    public class EmployeeInfo
    {
        [Display(Name = "Họ và tên")]
        [MinLength(5, ErrorMessage = "Tên ít nhất 5 ký tự !")]
        public String FullName { get; set; }


        [Display(Name = "Tuổi")]
        [Required(ErrorMessage = "Không để trống!")]
        [Range(18, 60, ErrorMessage = "Tuổi phải từ 18 đến 60 !")]
        [DataType(DataType.MultilineText)]
        public int Age { get; set; }
    }
}
