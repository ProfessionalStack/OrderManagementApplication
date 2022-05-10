using Order_Management_Application.Data;
using Order_Management_Application.DBContextFolder;
using Order_Management_Application.IRepository;
using System.Collections.Generic;
using System.Linq;

namespace Order_Management_Application.Repository
{
    public class SupplierRepository : ISupplierRepository
    {
        ContextDB _contextDB;
        public SupplierRepository(ContextDB contextDB)
        {
            _contextDB = contextDB;
        }
        public void Delete(int supplierID)
        {
            var supplier = _contextDB.Suppliers.FirstOrDefault(x => x.SupplierID == supplierID);
            supplier.isDelete = !supplier.isDelete;
            _contextDB.Suppliers.Update(supplier);
            _contextDB.SaveChanges();
        }

        public Supplier Get(int supplierID)
        {
            return _contextDB.Suppliers.FirstOrDefault(x => x.SupplierID == supplierID && !x.isDelete);
        }

        public List<Supplier> Gets()
        {
            return _contextDB.Suppliers.Where(x=>!x.isDelete).ToList();
        }

        public Supplier Save(Supplier objSupplier)
        {
            _contextDB.Suppliers.Add(objSupplier);
            _contextDB.SaveChanges();
            return this.Get(objSupplier.SupplierID);
        }

        public Supplier Update(Supplier objSupplier)
        {
            _contextDB.Suppliers.Update(objSupplier);
            _contextDB.SaveChanges();
            return this.Get(objSupplier.SupplierID);
        }
    }
}
