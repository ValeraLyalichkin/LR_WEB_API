﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects
{
    public class OrderForCreationDto
    {
        public string Cost { get; set; }
        public int Goods { get; set; }
        public string Date { get; set; }

    }
}
