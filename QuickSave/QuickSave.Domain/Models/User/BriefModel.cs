using System;
using System.Collections.Generic;
using System.Text;

namespace QuickSave.Domain.Models.User
{
    public class BriefModel
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public static BriefModel MapFrom(Entities.User user)
        {
            return new BriefModel()
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email
            };
        }
    }
}
