﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuctionWarehouse.Models
{
    public class ItemsDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }

        public string UserId { get; set; }
    }
}