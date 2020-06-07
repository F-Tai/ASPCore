using System;
using System.ComponentModel.DataAnnotations;


namespace ASPCore.Models
{
    internal class KiemTraNgaySinhAttribute : ValidationAttribute
    {
        /// <summary>
        /// Phá thoải mái
        /// </summary>
        /// <param name="value"></param>
        /// <param name="validationContext"></param>
        /// <returns></returns>
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime ngaysinh = (DateTime)value;
            if(ngaysinh > DateTime.Today)
            {               
                return new ValidationResult("Bé sinh trong tương lai hả");
            }
            //return base.IsValid(value, validationContext);
            return ValidationResult.Success;
        }

    }
}