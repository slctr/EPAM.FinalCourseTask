﻿using Microsoft.AspNet.Identity.EntityFramework;

namespace ProjectManagement.BLL.Interfacies.Entities
{
    public class BllUser : IdentityUser
    {
        public BllPerson WorkAccount { get; set; }
    }
}
