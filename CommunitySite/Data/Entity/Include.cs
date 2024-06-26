﻿using System;
using System.Collections.Generic;

namespace CommunitySite.Data.Entity;

public partial class Include
{
    public decimal? Postid { get; set; }

    public decimal? Commentid { get; set; }

    public decimal Includerowid { get; set; }

    public virtual Sitecomment? Comment { get; set; }

    public virtual Post? Post { get; set; }
}
