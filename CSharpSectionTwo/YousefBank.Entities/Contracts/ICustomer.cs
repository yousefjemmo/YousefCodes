using System;

namespace YousefBank.Entities.Contracts
{
    public interface  ICustomer
    {
      Guid CustomerID { get; set; }  
        long CustomerCode { get; set; }
        string CustomerName { get; set; }
        string Address { get; set; }
        string Lndmark { get; set; }
        string City { get; set; }
        string Country { get; set; }
        string Phone { get; set; }  
    }
}
