﻿using System;

namespace BitAI.DataService.Models
{
    /// <summary>
    /// The result of the /public/getticker
    /// </summary>
    public class Ticker
    {
        public Decimal Bid { get; set; }
        public Decimal Ask { get; set; }
        public Decimal Last { get; set; }
    }
}
