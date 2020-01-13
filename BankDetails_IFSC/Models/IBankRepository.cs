using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankDetails_IFSC.Models
{
    public interface IBankRepository
    {
        BankDetails GetBankDetails(string IFSC);
    }
}
