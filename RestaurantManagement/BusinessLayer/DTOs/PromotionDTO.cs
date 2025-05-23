﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.DTOs
{
    public class PromotionDTO
    {
        public int PromotionID { get; set; }

        public string PromotionName { get; set; }

        public string Description { get; set; }

        public double DiscountPercentage { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
    }
}
