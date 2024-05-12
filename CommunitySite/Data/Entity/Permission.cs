﻿using System;
using System.Collections.Generic;

namespace CommunitySite.Data.Entity;

public partial class Permission
{
    public decimal Permissionid { get; set; }

    public string? PermissionName { get; set; }

    public virtual ICollection<Siteuser> Siteusers { get; set; } = new List<Siteuser>();
}