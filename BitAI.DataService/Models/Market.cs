﻿using System;

namespace BitAI.DataService.Models
{
    /// <summary>
    /// The result of the /public/getmarkets end point
    /// This contains the details of a tradeable market
    /// </summary>
    public class Market
    {
        public String MarketCurrency { get; set; }
        public String BaseCurrency { get; set; }
        public String MarketCurrencyLong { get; set; }
        public String BaseCurrencyLong { get; set; }
        public Decimal MinTradeSize { get; set; }
        public String MarketName { get; set; }
        public bool IsActive { get; set; }
        public DateTime Created { get; set; }
        public String Notice { get; set; }
        public bool? IsSponsored { get; set; }
        public String LogoUrl { get; set; }
    }
}
