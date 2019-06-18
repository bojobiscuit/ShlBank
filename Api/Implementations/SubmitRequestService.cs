using System;
using System.Collections.Generic;
using Repository.Dtos;
using Repository.Interfaces;
using Api.Interfaces;
using Api.ViewModels;

namespace Api.Implementations
{
    public class SubmitRequestService : ISubmitRequestService
    {
        private readonly IUserRepository _userRepository;
        private readonly IBankRepository _bankRepository;

        public SubmitRequestService(IUserRepository userRepository, IBankRepository bankRepository)
        {
            _userRepository = userRepository;
            _bankRepository = bankRepository;
        }

        public SubmitRequestVM GetRequest(int userId)
        {
            var userAccount = _userRepository.GetUserAccount(userId);
            if (userAccount == null)
                return null;

            SubmitRequestVM requestVM = new SubmitRequestVM()
            {
                UserId = userAccount.Id,
                UserName = userAccount.UserName,
                IsBanker = userAccount.IsBanker
            };

            return requestVM;
        }

        public SubmitRequestVM GetUsersForRequest(int userId, SubmitRequestVM requestVM)
        {
            var userAccount = _userRepository.GetUserAccount(userId);
            if (userAccount == null)
                return null;

            requestVM.MatchingUsers = _bankRepository.GetMatchingUsers(requestVM.SubmittedNames);
            requestVM.ErrorNames = FindNamesNotMatched(requestVM);

            return requestVM;
        }

        public SubmitRequestVM SubmitRequest(int userId, SubmitRequestVM requestVM)
        {
            var userAccount = _userRepository.GetUserAccount(userId);
            if (userAccount == null)
                return null;

            if (IsValid(requestVM.Request))
            {
                int? submittedRequestId = _bankRepository.SubmitRequest(requestVM.Request);
                requestVM.SubmittedRequestId = submittedRequestId;
            }

            return requestVM;
        }

        private List<string> FindNamesNotMatched(SubmitRequestVM submitRequest)
        {
            List<string> errorNames = new List<string>();

            // TODO: Implement

            return errorNames;
        }

        private bool IsValid(GroupRequestDto request)
        {
            // TODO: Implement
            
            throw new NotImplementedException();
        }
    }
}
