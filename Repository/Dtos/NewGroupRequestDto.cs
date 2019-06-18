using System;
using System.Collections.Generic;

namespace Repository.Dtos
{
    public class NewGroupRequestDto
    {
        public int UserId { get; set; }
        public string Title { get; set; }
        public List<NewRequestDto> Requests { get; set; }
    }
}
