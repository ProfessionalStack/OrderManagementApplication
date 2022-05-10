using Order_Management_Application.Data;
using System.Collections.Generic;

namespace Order_Management_Application.IRepository
{
    public interface ISupplierRepository
    {
        public Supplier Save(Supplier objSupplier);
        public Supplier Update(Supplier objSupplier);
        public Supplier Get(int supplierID);
        public void Delete(int supplierID);
        public List<Supplier> Gets();

    }
}
