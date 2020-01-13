using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace BankDetails_IFSC.Models
{
    public class BankRepository : IBankRepository
    {
        public BankDetails GetBankDetails(string IFSC)
        {
            try
            {
                using (var client = new WebClient())
                {
                    BankDetails _bank = new BankDetails();
                    client.Headers.Add("DY-X-Authorization: 8fe69b30f07a07692796fbd751d625a7d0920d1c");
                    var result = client.DownloadString("https://ifsc.datayuge.com/api/v1/" + IFSC.Trim());
                    var BankResult = JsonConvert.DeserializeObject<BankDetails>(result);
                    _bank.bank = BankResult.bank;
                    _bank.IFSC = BankResult.IFSC;
                    _bank.MICR = BankResult.MICR;
                    _bank.branch = BankResult.branch;
                    _bank.Address = BankResult.Address;
                    _bank.Contact = BankResult.Contact;
                    _bank.City = BankResult.City;
                    _bank.District = BankResult.District;
                    _bank.State = BankResult.State;
                    return _bank;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
