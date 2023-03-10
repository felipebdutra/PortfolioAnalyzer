using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PortfolioAnalyzer.Core.BankAggregate;
using PortfolioAnalyzer.Repository.Bank;

namespace PortfolioAnalyzer.Services.Bank
{
    public class BankService : IBankService
    {
        private IBankRepository _bankRepository;
        private ICurrencyConvertionService _currencyConvertion;

        public BankService(
            IBankRepository bankRepository,
            ICurrencyConvertionService currencyConvertion
        )
        {
            _bankRepository = bankRepository;
            _currencyConvertion = currencyConvertion;
        }

        public Task<IList<BankAccount>> GetTotalCashValueAsync()
        {
            return _bankRepository.GetAllAccountsAsync();
        }
    }
}
