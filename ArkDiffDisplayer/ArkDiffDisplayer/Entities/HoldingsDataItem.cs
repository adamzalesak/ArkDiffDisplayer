﻿namespace ArkDiffDisplayer.Entities;

public class HoldingsDataItem
{
    public DateTime Date { get; set; }
    public string Fund { get; set; }
    public string Company { get; set; }
    public string Ticker { get; set; }
    public string Cusip { get; set; }
    public long Shares { get; set; }
    public double MarketValue { get; set; }
    public double Weight { get; set; }
}