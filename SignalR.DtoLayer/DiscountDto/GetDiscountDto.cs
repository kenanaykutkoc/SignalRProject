﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DtoLayer.DiscountDto
{
    public class GetDiscountDto
    {
        public int DiscountID { get; set; }
        public string Title { get; set; }
        public string Amout { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
