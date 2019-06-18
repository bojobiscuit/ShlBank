using Repository.Dtos;
using Microsoft.AspNetCore.Mvc;
using Api.Interfaces;
using Api.ViewModels;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankController : ControllerBase
    {
        private readonly IBankService _bankService;

        public BankController(IBankService bankService)
        {
            _bankService = bankService;
        }

        [HttpGet("{userId}")]
        public ActionResult<BankVM> GetBank(int userId)
        {
            BankVM bankAccount = _bankService.GetBankVM(userId);
            return bankAccount;
        }
    }
}
