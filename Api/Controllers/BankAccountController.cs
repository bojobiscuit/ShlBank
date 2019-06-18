using Repository.Dtos;
using Microsoft.AspNetCore.Mvc;
using Api.Interfaces;
using Api.ViewModels;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankAccountController : ControllerBase
    {
        private readonly IBankAccountService _bankAccountService;

        public BankAccountController(IBankAccountService bankAccountService)
        {
            _bankAccountService = bankAccountService;
        }

        [HttpGet("{userId}")]
        public ActionResult<BankAccountVM> GetBankAccountVM(int userId)
        {
            BankAccountVM bankAccount = _bankAccountService.GetBankAccountVM(userId);
            return bankAccount;
        }

                [HttpGet("user/{userId}")]
        public ActionResult<UserAccountDto> GetUser(int userId)
        {
            UserAccountDto userAccount = _bankAccountService.GetUser(userId);
            return userAccount;
        }

        [HttpPost("purchase")]
        public ActionResult<int?> PostPurchase([FromBody] NewPurchaseDto purchase)
        {
            int? addedTransactionId = _bankAccountService.AddPurchase(purchase);
            return addedTransactionId;
        }

        [HttpPut("toggleFree500/{userId}")]
        public void PostToggleFree500(int userId)
        {
            _bankAccountService.ToggleFree500(userId);
        }

        [HttpPut("toggleShlTraining/{userId}")]
        public void PostToggleShlTraining(int userId)
        {
            _bankAccountService.ToggleShlTraining(userId);
        }
    }
}
