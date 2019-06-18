using Repository.Dtos;
using Microsoft.AspNetCore.Mvc;
using Api.Interfaces;
using Api.ViewModels;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubmitRequestController : ControllerBase
    {
        private readonly ISubmitRequestService submitRequestServic;

        public SubmitRequestController(ISubmitRequestService submitRequestService)
        {
            submitRequestServic = submitRequestService;
        }

        [HttpGet("{userId}")]
        public ActionResult<SubmitRequestVM> GetSubmitRequestPage(int userId)
        {
            SubmitRequestVM submitRequestVM = submitRequestServic.GetRequest(userId);
            return submitRequestVM;
        }

        [HttpGet("checkNames/{userId}")]
        public ActionResult<SubmitRequestVM> GetResultsFromNames(int userId, [FromBody]SubmitRequestVM submitRequest)
        {
            SubmitRequestVM submitRequestVM = submitRequestServic.GetUsersForRequest(userId, submitRequest);
            return submitRequestVM;
        }

        [HttpPost("submit/{userId}")]
        public ActionResult<SubmitRequestVM> PostSubmitRequest(int userId, [FromBody]SubmitRequestVM submitRequest)
        {
            SubmitRequestVM submitRequestVM = submitRequestServic.SubmitRequest(userId, submitRequest);
            return submitRequestVM;
        }
    }
}
