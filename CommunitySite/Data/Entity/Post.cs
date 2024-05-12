﻿using System;
using System.Collections.Generic;

namespace CommunitySite.Data.Entity;

public partial class Post
{
    public decimal Postid { get; set; }

    public decimal? Userid { get; set; }

    public decimal? Photoid { get; set; }

    public decimal? Groupid { get; set; }

    public string? PostText { get; set; }

    public string? PostDate { get; set; }

    public virtual Sitegroup? Group { get; set; }

    public virtual ICollection<Include> Includes { get; set; } = new List<Include>();

    public virtual Photo? Photo { get; set; }

    public virtual ICollection<Sitecomment> Sitecomments { get; set; } = new List<Sitecomment>();

    public virtual Siteuser? User { get; set; }
}