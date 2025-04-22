using Microsoft.AspNetCore.Http;

namespace B2BEcommerce.Models.Management
{
    public class ExcelImportModel
    {
        public string DENEME { get; set; }
        public IFormFile FILE { get; set; }
    }
}
