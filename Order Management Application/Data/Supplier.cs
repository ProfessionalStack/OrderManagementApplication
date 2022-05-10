using System.ComponentModel.DataAnnotations;

namespace Order_Management_Application.Data
{
    public class Supplier
    {
        public int SupplierID { get; set; } = 0;
        [Required(ErrorMessage ="Supplier Name is required")]
        public string SupplierName { get; set; } = "";

        [Required(ErrorMessage = "Address Line 1 is required")]
        public string AddressLine1 { get; set; } = "";

        [Required(ErrorMessage = "Address Line 2 is required")]
        public string AddressLine2 { get; set; } = "";

        [Required(ErrorMessage = "City is required")]
        public string City { get; set; } = "";

        [Required(ErrorMessage = "Postal Code is required")]
        public string PostalCode { get; set; } = "";

        [Required(ErrorMessage = "State is required")]
        public string State { get; set; } = "";
        public bool isDelete { get; set; } = false;
    }
}
