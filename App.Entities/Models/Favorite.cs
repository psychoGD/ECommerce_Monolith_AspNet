﻿using System;
using System.Collections.Generic;

namespace App.Entities.Models
{
    public partial class Favorite
    {
        public int FavoritesId { get; set; }
        public int? ProductId { get; set; }
        public string? CustomerId { get; set; }
    }
}
