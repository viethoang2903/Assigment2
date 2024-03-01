﻿using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class Member
{
    public int MemberId { get; set; }

    public string Email { get; set; }

    public string CompanyName { get; set; }

    public string City { get; set; }

    public string Country { get; set; }

    public string Password { get; set; }

    public virtual ICollection<Order> Orders { get; } = new List<Order>();
}
