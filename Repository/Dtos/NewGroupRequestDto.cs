using System;
using System.Collections.Generic;

namespace Repository.Dtos
{
    public class NewGroupRequestDto
    {
        public int CreatorId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<NewRequestDto> PendingRequests { get; set; }

        public bool IsValid()
        {
            if (PendingRequests == null || PendingRequests.Count == 0)
                return false;

            if (CreatorId <= 1)
                return false;

            if (Title == null || Description == null)
                return false;

            foreach (var request in PendingRequests)
            {
                if (!request.IsValid())
                    return false;
            }

            return true;
        }
    }
}
