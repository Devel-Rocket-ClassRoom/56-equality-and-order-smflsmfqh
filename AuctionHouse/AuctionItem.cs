using System;
using System.Collections.Generic;
using System.Text;

class AuctionItem
{
    public string Name;
    public int CurrentBid;
    public int BidCount;
    public string Category;

    public AuctionItem(string name, int currentBid, int bidCount, string category)
    {
        Name = name;
        CurrentBid = currentBid;
        BidCount = bidCount;
        Category = category;
    }

    public override string ToString()
    {
        return $"  {Name} [{Category}] - 입찰가: {CurrentBid}골드 (입찰 {BidCount}회)";
    }
}