using StockMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarket.Infrastructure
{
    public interface ICompanyRepositories
    {
        List<Stocks> GetAllCompany();

        Stocks GetCompanyById(string code);

        Stocks CreateCompany(Stocks companyDetails);
    }
}
