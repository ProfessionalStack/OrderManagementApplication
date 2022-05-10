namespace Order_Management_Application.Data
{
    public class Supplier
    {
        public int SupplierID { get; set; } = 0;
        public string SupplierName { get; set; } = "";
        public string AddressLine1 { get; set; } = "";
        public string AddressLine2 { get; set; } = "";
        public string City { get; set; } = "";
        public string PostalCode { get; set; } = "";
        public string State { get; set; } = "";
        public bool isDelete { get; set; } = false;
    }
}
